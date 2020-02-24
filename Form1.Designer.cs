namespace Laboration_2_Ordbehandling_v2
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.nyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stängToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.num_letters = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.num_letters_no_space = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.num_words = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.num_rows = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.toolStrip1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(443, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyToolStripMenuItem,
            this.öppnaToolStripMenuItem,
            this.sparaToolStripMenuItem,
            this.sparaSomToolStripMenuItem,
            this.stängToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(47, 22);
			this.toolStripDropDownButton1.Text = "Arkiv";
			this.toolStripDropDownButton1.ToolTipText = "Arkiv";
			// 
			// nyToolStripMenuItem
			// 
			this.nyToolStripMenuItem.Name = "nyToolStripMenuItem";
			this.nyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.nyToolStripMenuItem.Text = "Ny";
			this.nyToolStripMenuItem.Click += new System.EventHandler(this.NyToolStripMenuItem_Click);
			// 
			// öppnaToolStripMenuItem
			// 
			this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
			this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.öppnaToolStripMenuItem.Text = "Öppna";
			this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.ÖppnaToolStripMenuItem_Click);
			// 
			// sparaToolStripMenuItem
			// 
			this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
			this.sparaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.sparaToolStripMenuItem.Text = "Spara";
			this.sparaToolStripMenuItem.Click += new System.EventHandler(this.SparaToolStripMenuItem_Click);
			// 
			// sparaSomToolStripMenuItem
			// 
			this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
			this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.sparaSomToolStripMenuItem.Text = "Spara som...";
			this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.SparaSomToolStripMenuItem_Click);
			// 
			// stängToolStripMenuItem
			// 
			this.stängToolStripMenuItem.Name = "stängToolStripMenuItem";
			this.stängToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.stängToolStripMenuItem.Text = "Stäng";
			this.stängToolStripMenuItem.Click += new System.EventHandler(this.StängToolStripMenuItem_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(0, 25);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(443, 476);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			this.richTextBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.RichTextBox1_DragDrop);
			this.richTextBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.RichTextBox1_DragEnter);
			this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.num_letters);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.num_letters_no_space);
			this.flowLayoutPanel1.Controls.Add(this.label5);
			this.flowLayoutPanel1.Controls.Add(this.num_words);
			this.flowLayoutPanel1.Controls.Add(this.label7);
			this.flowLayoutPanel1.Controls.Add(this.num_rows);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 473);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(443, 28);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tecken:";
			// 
			// num_letters
			// 
			this.num_letters.AutoSize = true;
			this.num_letters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num_letters.Location = new System.Drawing.Point(59, 0);
			this.num_letters.Name = "num_letters";
			this.num_letters.Size = new System.Drawing.Size(14, 15);
			this.num_letters.TabIndex = 1;
			this.num_letters.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(79, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tecken (utan space):";
			// 
			// num_letters_no_space
			// 
			this.num_letters_no_space.AutoSize = true;
			this.num_letters_no_space.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num_letters_no_space.Location = new System.Drawing.Point(206, 0);
			this.num_letters_no_space.Name = "num_letters_no_space";
			this.num_letters_no_space.Size = new System.Drawing.Size(14, 15);
			this.num_letters_no_space.TabIndex = 3;
			this.num_letters_no_space.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(226, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ord:";
			// 
			// num_words
			// 
			this.num_words.AutoSize = true;
			this.num_words.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num_words.Location = new System.Drawing.Point(262, 0);
			this.num_words.Name = "num_words";
			this.num_words.Size = new System.Drawing.Size(14, 15);
			this.num_words.TabIndex = 5;
			this.num_words.Text = "0";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(282, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 15);
			this.label7.TabIndex = 6;
			this.label7.Text = "Rader:";
			// 
			// num_rows
			// 
			this.num_rows.AutoSize = true;
			this.num_rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num_rows.Location = new System.Drawing.Point(332, 0);
			this.num_rows.Name = "num_rows";
			this.num_rows.Size = new System.Drawing.Size(14, 15);
			this.num_rows.TabIndex = 7;
			this.num_rows.Text = "1";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(443, 501);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.toolStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(459, 540);
			this.Name = "Form1";
			this.Text = "dok1.txt - NotPad";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem nyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stängToolStripMenuItem;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		internal System.Windows.Forms.Label num_letters;
		internal System.Windows.Forms.Label num_letters_no_space;
		internal System.Windows.Forms.Label num_words;
		internal System.Windows.Forms.Label num_rows;
	}
}

