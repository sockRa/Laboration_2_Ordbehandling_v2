﻿namespace Laboration_2_Ordbehandling_v2
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
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
			this.nyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.nyToolStripMenuItem.Text = "Ny";
			this.nyToolStripMenuItem.Click += new System.EventHandler(this.NyToolStripMenuItem_Click);
			// 
			// öppnaToolStripMenuItem
			// 
			this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
			this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.öppnaToolStripMenuItem.Text = "Öppna";
			this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.ÖppnaToolStripMenuItem_Click);
			// 
			// sparaToolStripMenuItem
			// 
			this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
			this.sparaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.sparaToolStripMenuItem.Text = "Spara";
			this.sparaToolStripMenuItem.Click += new System.EventHandler(this.SparaToolStripMenuItem_Click);
			// 
			// sparaSomToolStripMenuItem
			// 
			this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
			this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.sparaSomToolStripMenuItem.Text = "Spara som...";
			this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.SparaSomToolStripMenuItem_Click);
			// 
			// stängToolStripMenuItem
			// 
			this.stängToolStripMenuItem.Name = "stängToolStripMenuItem";
			this.stängToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
			this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.label4);
			this.flowLayoutPanel1.Controls.Add(this.label5);
			this.flowLayoutPanel1.Controls.Add(this.label6);
			this.flowLayoutPanel1.Controls.Add(this.label7);
			this.flowLayoutPanel1.Controls.Add(this.label8);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 451);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(443, 50);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bokstäver:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(72, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(92, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Bokstäver (utan space):";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(232, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(252, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ord:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(288, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(14, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "0";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(308, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 15);
			this.label7.TabIndex = 6;
			this.label7.Text = "Rader:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(358, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(14, 15);
			this.label8.TabIndex = 7;
			this.label8.Text = "0";
			// 
			// saveFileDialog1
			// 
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}
