using System;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling_v2
{
	public partial class Form1 : Form
	{
		private readonly NewDocumentOperations _dockOperations;

		public Form1()

		{
			InitializeComponent();
			_dockOperations = new NewDocumentOperations(richTextBox1, this);
		}

		private void NyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_dockOperations.NewDocument();
		}

		private void RichTextBox1_TextChanged(object sender, EventArgs e)
		{
			_dockOperations.UpdateInformationTable();
			// Only allow update if the document have not been imported.
			// This bool ensures that when the event is triggered, due to text change when importing files,
			// it will not trigger the first time.
			if (_dockOperations.DocumentHaveBeenDropped)
			{
				_dockOperations.DocumentHaveBeenDropped = false;
				return;
			}

			_dockOperations.MarkDocumentAsChanged();
		}

		private void SparaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_dockOperations.SaveDocument();
		}

		private void SparaSomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_dockOperations.SaveAs();
		}

		private void ÖppnaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_dockOperations.OpenDocument();
		}

		private void StängToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_dockOperations.CloseApplication();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			_dockOperations.ApplicationIsClosing(e);
		}

		private void RichTextBox1_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
		}

		private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
		{
			var file = (string[])e.Data.GetData(DataFormats.FileDrop);

			if (file == null) throw new ArgumentNullException(nameof(file));

			//We only handle one drag and drop file
			_dockOperations.RetrieveDropText(file[0]);
		}
	}
}