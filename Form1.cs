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
	}
}