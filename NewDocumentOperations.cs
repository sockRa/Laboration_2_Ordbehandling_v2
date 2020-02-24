using System;
using System.IO;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling_v2
{
	internal class NewDocumentOperations
	{
		private const string ProgramName = " - NotPad";
		private const string DefaultDocumentName = "dok1.txt";
		private static bool _documentHaveBeenChanged;
		private static bool _importedDocument;
		private static bool SaveWereCanceled { get; set; }
		private static bool DocumentNotSaved { get; set; }
		public bool DocumentHaveBeenDropped;
		private static OpenFileDialog _openDialog;
		private static SaveFileDialog _saveDialog;
		private static string CurrentFilePath { get; set; }
		private RichTextBox RichText { get; }
		private Form1 MainForm1 { get; }

		public NewDocumentOperations(RichTextBox richTextBox1, Form1 form1)
		{
			RichText = richTextBox1;
			MainForm1 = form1;

			//Allow drag and drop into the rich text box
			RichText.AllowDrop = true;

			SaveWereCanceled = false;

			_openDialog = new OpenFileDialog();
			_saveDialog = new SaveFileDialog();

			_openDialog.Filter = "Text Files (*.txt)|*.txt";
			_saveDialog.Filter = _openDialog.Filter;
		}

		public void NewDocument()
		{
			if (_documentHaveBeenChanged)
			{
				SaveDocument();
			}

			//Ensure that the document were saved.
			if (SaveWereCanceled) return;
			// Clear text box
			RichText.Text = "";
			_documentHaveBeenChanged = false;
			_importedDocument = false;
			SetDefaultDocumentName();
		}

		public void MarkDocumentAsChanged()
		{
			// Append *, only if the document have not been changed already.
			if (_documentHaveBeenChanged) return;

			//Get the title and append * upon it
			var documentName = MainForm1.Text;
			documentName = documentName.Split(' ')[0] + '*';

			MainForm1.Text = documentName + ProgramName;
			_documentHaveBeenChanged = true;
		}

		private void SetDefaultDocumentName()
		{
			MainForm1.Text = DefaultDocumentName;
		}

		public void SaveDocument()
		{
			DocumentNotSaved = false;

			switch (SaveChangesMessage())
			{
				// If the document have been imported, we can assume that it exists, thus we don't need
				// to ask the user for a save location.
				case DialogResult.Yes when _importedDocument:
					File.WriteAllText(CurrentFilePath, RichText.Text);
					SaveWereCanceled = false;
					DocumentNotSaved = false;
					break;

				case DialogResult.Yes:
					SaveAs();
					break;

				case DialogResult.Cancel:
					SaveWereCanceled = true;
					DocumentNotSaved = true;
					break;

				case DialogResult.No:
					SaveWereCanceled = false;
					DocumentNotSaved = true;
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}

			//Don't remove * from title if the save were canceled or declined
			if (DocumentNotSaved) return;

			//Remove * from document name
			if (CurrentFilePath != null) SetDocumentTitle(CurrentFilePath);
			_documentHaveBeenChanged = false;
		}

		public void SaveAs()
		{
			switch (_saveDialog.ShowDialog())
			{
				case DialogResult.OK:
					File.WriteAllText(_saveDialog.FileName, RichText.Text);
					SaveWereCanceled = false;
					DocumentNotSaved = false;
					break;

				case DialogResult.Cancel:
					SaveWereCanceled = true;
					break;
			}
		}

		public void OpenDocument()
		{
			if (_documentHaveBeenChanged)
			{
				SaveDocument();
			}

			//Return if the user canceled the save
			if (SaveWereCanceled) return;
			//If the user did not choose any document to open, return.
			if (_openDialog.ShowDialog() != DialogResult.OK) return;

			RichText.Text = File.ReadAllText(_openDialog.FileName);
			SetDocumentTitle(_openDialog.FileName);

			//Save filepath
			CurrentFilePath = _openDialog.FileName;

			// New document is not changed upon import
			_documentHaveBeenChanged = false;

			_importedDocument = true;

			//Place cursor at the end of the file
			RichText.SelectionStart = RichText.Text.Length;
		}

		private void SetDocumentTitle(string filePath)
		{
			MainForm1.Text = Path.GetFileName(filePath) + ProgramName;
		}

		public void CloseApplication()
		{
			if (_documentHaveBeenChanged)
			{
				SaveDocument();
			}

			//Abort if the user canceled the save
			if (SaveWereCanceled) return;

			Application.Exit();
		}

		private static DialogResult SaveChangesMessage()
		{
			// If get file name returns null, assign the default document name
			var documentName = Path.GetFileName(CurrentFilePath) ?? DefaultDocumentName;

			return MessageBox.Show("Vill du spara ändringarna för " + documentName + "?", "NotPad",
				MessageBoxButtons.YesNoCancel);
		}

		public void ApplicationIsClosing(FormClosingEventArgs e)
		{
			if (_documentHaveBeenChanged)
			{
				SaveDocument();
			}

			if (SaveWereCanceled)
			{
				// Abort if the user canceled the save.
				e.Cancel = true;
			}
		}

		public void UpdateInformationTable()
		{
			if (RichText == null) return;

			MainForm1.num_letters.Text = GetNumOfCharacters();
			MainForm1.num_letters_no_space.Text = GetNumOfCharactersNoWhiteSpace();
			MainForm1.num_rows.Text = GetNumRows();
			MainForm1.num_words.Text = GetNumWords();
		}

		private string GetNumWords()
		{
			var newWord = true;
			var word = 0;

			foreach (var character in RichText.Text)
			{
				if (character == ' ')
				{
					//New word encountered
					newWord = true;
				}
				else
				{
					if (!newWord) continue;
					word++;
					newWord = false;
				}
			}

			return word.ToString();
		}

		private string GetNumRows()
		{
			return RichText.Text.Split('\n').Length.ToString();
		}

		private string GetNumOfCharactersNoWhiteSpace()
		{
			return (RichText.Text.Length - RichText.Text.Split(' ').Length).ToString();
		}

		private string GetNumOfCharacters()
		{
			//It is assumed that space is a character
			return RichText.Text.Length.ToString();
		}

		public void RetrieveDropText(string filePath)
		{
			var documentText = File.ReadAllText(filePath);

			switch (Control.ModifierKeys)
			{
				case Keys.Control:
					RichText.AppendText(documentText);
					break;

				case Keys.Shift:
					AppendTextAtCursor(documentText);
					break;

				default:
					if (ReplaceText(filePath, documentText)) return;
					break;
			}

			//Place cursor at the end of the file
			RichText.SelectionStart = RichText.Text.Length;
		}

		private bool ReplaceText(string filePath, string documentText)
		{
			if (_documentHaveBeenChanged)
			{
				SaveDocument();
			}

			//Abort if the save were canceled
			if (SaveWereCanceled) return true;

			RichText.Text = documentText;
			SetDocumentTitle(Path.GetFileName(filePath));
			CurrentFilePath = filePath;
			_importedDocument = true;
			DocumentHaveBeenDropped = true;
			return false;
		}

		private void AppendTextAtCursor(string documentText)
		{
			//Find the index where the cursor is located
			var i = RichText.SelectionStart;
			//Save everything after the selection in sub string.
			var document = RichText.Text;
			var subString = document.Substring(i);

			//Set the text to everything from 0 to the cursor selection
			RichText.Text = RichText.Text.Substring(0, i);

			//Stitch everything together
			RichText.Text += documentText + subString;
		}
	}
}