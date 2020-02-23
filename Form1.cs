using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration_2_Ordbehandling_v2
{
	public partial class Form1 : Form
	{
		private readonly DocumentHandler _dockHandler;
		private bool _documentHaveBeenDropped;

		public Form1()

		{
			InitializeComponent();
			_dockHandler = new DocumentHandler(richTextBox1, this);
		}

		private void NyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_dockHandler.NewDocument();
		}

		private void RichTextBox1_TextChanged(object sender, EventArgs e)
		{
			// Only allow update if the document have not been imported.
			// This bool ensures that when the event is triggered, due to text change when importing files,
			// it will not trigger the first time.
			if (_documentHaveBeenDropped)
			{
				_documentHaveBeenDropped = false;
				return;
			}

			_dockHandler.UpdateInformationTable();
			_dockHandler.MarkDocumentAsChanged();
		}

		private void SparaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_dockHandler.SaveDocument();
		}

		private void SparaSomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_dockHandler.SaveAs();
		}

		private void ÖppnaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_dockHandler.OpenDocument();
		}

		private void StängToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_dockHandler.CloseApplication();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			_dockHandler.ApplicationIsClosing(e);
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
			_dockHandler.RetrieveDropText(file[0]);

			_documentHaveBeenDropped = true;
		}
	}
}