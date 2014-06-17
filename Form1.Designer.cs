namespace Pic2Pdf
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
            this.lvFiles = new System.Windows.Forms.ListView();
            this.btMovenUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutfile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.ofdBrowsePics = new System.Windows.Forms.OpenFileDialog();
            this.sfdBrowsePdf = new System.Windows.Forms.SaveFileDialog();
            this.chkIgnoreError = new System.Windows.Forms.CheckBox();
            this.chkOpenAfterConvert = new System.Windows.Forms.CheckBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenPDF = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvFiles
            // 
            this.lvFiles.AllowDrop = true;
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvFiles.Location = new System.Drawing.Point(0, 0);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(278, 340);
            this.lvFiles.TabIndex = 3;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            this.lvFiles.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvNotes_ItemDrag);
            this.lvFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvNotes_DragDrop);
            this.lvFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvNotes_DragEnter);
            this.lvFiles.DoubleClick += new System.EventHandler(this.lvFiles_DoubleClick);
            this.lvFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvNotes_KeyDown);
            // 
            // btMovenUp
            // 
            this.btMovenUp.ForeColor = System.Drawing.Color.Red;
            this.btMovenUp.Location = new System.Drawing.Point(306, 136);
            this.btMovenUp.Name = "btMovenUp";
            this.btMovenUp.Size = new System.Drawing.Size(75, 56);
            this.btMovenUp.TabIndex = 5;
            this.btMovenUp.Text = "&UP";
            this.btMovenUp.UseVisualStyleBackColor = true;
            this.btMovenUp.Click += new System.EventHandler(this.btMovenUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.ForeColor = System.Drawing.Color.Red;
            this.btnMoveDown.Location = new System.Drawing.Point(306, 198);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 56);
            this.btnMoveDown.TabIndex = 6;
            this.btnMoveDown.Text = "&DOWN";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(306, 74);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 56);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "D&ELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Output PDF filename:";
            // 
            // txtOutfile
            // 
            this.txtOutfile.Location = new System.Drawing.Point(395, 60);
            this.txtOutfile.Name = "txtOutfile";
            this.txtOutfile.ReadOnly = true;
            this.txtOutfile.Size = new System.Drawing.Size(301, 20);
            this.txtOutfile.TabIndex = 9;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(395, 86);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 56);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "&BROWSE";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(306, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 56);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "&ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(395, 264);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 56);
            this.btnAbout.TabIndex = 12;
            this.btnAbout.Text = "AB&OUT";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(593, 86);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(103, 56);
            this.btnConvert.TabIndex = 13;
            this.btnConvert.Text = "CON&VERT";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ofdBrowsePics
            // 
            this.ofdBrowsePics.Filter = "PNG files|*.png|JPEG|*.jpeg;*.jpg";
            this.ofdBrowsePics.FilterIndex = 2;
            this.ofdBrowsePics.Multiselect = true;
            // 
            // sfdBrowsePdf
            // 
            this.sfdBrowsePdf.FileName = "*.pdf";
            this.sfdBrowsePdf.Filter = "PDF Files|*.pdf|All files|*.*";
            // 
            // chkIgnoreError
            // 
            this.chkIgnoreError.AutoSize = true;
            this.chkIgnoreError.Location = new System.Drawing.Point(395, 171);
            this.chkIgnoreError.Name = "chkIgnoreError";
            this.chkIgnoreError.Size = new System.Drawing.Size(150, 17);
            this.chkIgnoreError.TabIndex = 14;
            this.chkIgnoreError.Text = "&Ignore errors and continue";
            this.chkIgnoreError.UseVisualStyleBackColor = true;
            // 
            // chkOpenAfterConvert
            // 
            this.chkOpenAfterConvert.AutoSize = true;
            this.chkOpenAfterConvert.Location = new System.Drawing.Point(395, 148);
            this.chkOpenAfterConvert.Name = "chkOpenAfterConvert";
            this.chkOpenAfterConvert.Size = new System.Drawing.Size(181, 17);
            this.chkOpenAfterConvert.TabIndex = 15;
            this.chkOpenAfterConvert.Text = "Open document after conversion";
            this.chkOpenAfterConvert.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File name";
            this.columnHeader1.Width = 254;
            // 
            // btnOpenPDF
            // 
            this.btnOpenPDF.Location = new System.Drawing.Point(496, 86);
            this.btnOpenPDF.Name = "btnOpenPDF";
            this.btnOpenPDF.Size = new System.Drawing.Size(75, 56);
            this.btnOpenPDF.TabIndex = 17;
            this.btnOpenPDF.Text = "OPEN &PDF";
            this.btnOpenPDF.UseVisualStyleBackColor = true;
            this.btnOpenPDF.Click += new System.EventHandler(this.btnOpenPDF_Click);
            // 
            // btnSort
            // 
            this.btnSort.ForeColor = System.Drawing.Color.Red;
            this.btnSort.Location = new System.Drawing.Point(306, 264);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 56);
            this.btnSort.TabIndex = 18;
            this.btnSort.Text = "S&ORT";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 340);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnOpenPDF);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkOpenAfterConvert);
            this.Controls.Add(this.chkIgnoreError);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtOutfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btMovenUp);
            this.Controls.Add(this.lvFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pic2Pdf";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.Button btMovenUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutfile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.OpenFileDialog ofdBrowsePics;
        private System.Windows.Forms.SaveFileDialog sfdBrowsePdf;
        private System.Windows.Forms.CheckBox chkIgnoreError;
        private System.Windows.Forms.CheckBox chkOpenAfterConvert;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpenPDF;
        private System.Windows.Forms.Button btnSort;
    }
}

