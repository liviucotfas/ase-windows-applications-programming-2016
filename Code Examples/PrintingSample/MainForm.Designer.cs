﻿namespace PrintingSample
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtDocument = new System.Windows.Forms.TextBox();
			this.btnPageSetup = new System.Windows.Forms.Button();
			this.btnPrintDialog = new System.Windows.Forms.Button();
			this.btnPrintPreview = new System.Windows.Forms.Button();
			this.printDialog = new System.Windows.Forms.PrintDialog();
			this.printDocument = new System.Drawing.Printing.PrintDocument();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.SuspendLayout();
			// 
			// txtDocument
			// 
			this.txtDocument.AccessibleDescription = "TextBox to contain text for printing";
			this.txtDocument.AccessibleName = "TextBox for printing";
			this.txtDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtDocument.Location = new System.Drawing.Point(12, 43);
			this.txtDocument.Multiline = true;
			this.txtDocument.Name = "txtDocument";
			this.txtDocument.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDocument.Size = new System.Drawing.Size(400, 272);
			this.txtDocument.TabIndex = 12;
			// 
			// btnPageSetup
			// 
			this.btnPageSetup.AccessibleDescription = "Button with text \"Page Setup\"";
			this.btnPageSetup.AccessibleName = "Page Setup button";
			this.btnPageSetup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnPageSetup.Location = new System.Drawing.Point(204, 11);
			this.btnPageSetup.Name = "btnPageSetup";
			this.btnPageSetup.Size = new System.Drawing.Size(88, 23);
			this.btnPageSetup.TabIndex = 11;
			this.btnPageSetup.Text = "Page &Setup";
			this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
			// 
			// btnPrintDialog
			// 
			this.btnPrintDialog.AccessibleDescription = "Button with text \"Print Dialog\"";
			this.btnPrintDialog.AccessibleName = "Print Dialog button";
			this.btnPrintDialog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnPrintDialog.Location = new System.Drawing.Point(108, 11);
			this.btnPrintDialog.Name = "btnPrintDialog";
			this.btnPrintDialog.Size = new System.Drawing.Size(88, 23);
			this.btnPrintDialog.TabIndex = 10;
			this.btnPrintDialog.Text = "Print &Dialog";
			this.btnPrintDialog.Click += new System.EventHandler(this.btnPrintDialog_Click);
			// 
			// btnPrintPreview
			// 
			this.btnPrintPreview.AccessibleDescription = "Button with text \"Print Preview\"";
			this.btnPrintPreview.AccessibleName = "Print Preview button";
			this.btnPrintPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnPrintPreview.Location = new System.Drawing.Point(12, 11);
			this.btnPrintPreview.Name = "btnPrintPreview";
			this.btnPrintPreview.Size = new System.Drawing.Size(88, 23);
			this.btnPrintPreview.TabIndex = 9;
			this.btnPrintPreview.Text = "Print &Preview";
			this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
			// 
			// printDialog
			// 
			this.printDialog.UseEXDialog = true;
			// 
			// printDocument
			// 
			this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 324);
			this.Controls.Add(this.txtDocument);
			this.Controls.Add(this.btnPageSetup);
			this.Controls.Add(this.btnPrintDialog);
			this.Controls.Add(this.btnPrintPreview);
			this.Name = "MainForm";
			this.Text = "Printing Sample";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.TextBox txtDocument;
		internal System.Windows.Forms.Button btnPageSetup;
		internal System.Windows.Forms.Button btnPrintDialog;
		internal System.Windows.Forms.Button btnPrintPreview;
		private System.Windows.Forms.PrintDialog printDialog;
		private System.Drawing.Printing.PrintDocument printDocument;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
	}
}

