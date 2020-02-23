using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling_v2
{
	internal class DocumentHandler
	{
		private const string ProgramName = " - NotPad";
		private const string DefaultDocumentName = "dok1.txt";
		private static bool _documentHaveBeenChanged;
		private static bool _importedDocument;
		private static bool SaveWereCanceled { get; set; }
		private static bool DocumentNotSaved { get; set; }
		private static OpenFileDialog _openDialog;
		private static SaveFileDialog _saveDialog;
		private static string CurrentFilePath { get; set; }
		private RichTextBox RichText { get; }
		private Form1 MainForm1 { get; }

		public DocumentHandler(RichTextBox richTextBox1, Form1 form1)
		{
			RichText = richTextBox1;
			MainForm1 = form1;

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
			var temp = MainForm1.Text.Split(' ')[0] + '*';

			MainForm1.Text = temp + ProgramName;
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
			SetDocumentTitle(CurrentFilePath);
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

			int word = 0, letter = 0, row = 1;
			var newWord = true;

			foreach (var character in RichText.Text)
			{
				switch (character)
				{
					case ' ':
						//New word have been encountered.
						newWord = true;
						break;

					case '\n':
						//Row have been encountered
						row++;
						break;

					default:
						if (newWord)
						{
							word++;
							newWord = false;
						}

						letter++;
						break;
				}
			}

			//It is assumed that space is a character
			MainForm1.num_letters.Text = RichText.Text.Length.ToString();
			MainForm1.num_letters_no_space.Text = letter.ToString();
			MainForm1.num_rows.Text = row.ToString();
			MainForm1.num_words.Text = word.ToString();
		}
	}
}