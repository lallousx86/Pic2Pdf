using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;

namespace Pic2Pdf
{
    public partial class Form1 : Form
    {
        const string STR_TITLE = "Pic2Pdf - v1.0 - lallouslab.net";
    
        public Form1()
        {
            InitializeComponent();
        }

        private void lvNotes_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(
                e.Item,
                DragDropEffects.Copy);
        }

        private void lvNotes_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                lvFiles.Items.Add(s[i]);
        }

        private void lvNotes_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btMovenUp_Click(object sender, EventArgs e)
        {
            X_LvMoveUp(lvFiles);
        }

        private void X_LvMoveUp(ListView lv)
        {
            ListViewItem lvi;
            if (lv.SelectedItems.Count == 0 || (lvi = lv.SelectedItems[0]) == null)
                return;

            lvi.MoveUp();
        }

        private void X_LvMoveDown(ListView lv)
        {
            ListViewItem lvi;
            if (lv.SelectedItems.Count == 0 || (lvi = lv.SelectedItems[0]) == null)
                return;

            lvi.MoveDown();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            X_LvMoveDown(lvFiles);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lvFiles.BeginUpdate();

            while (lvFiles.SelectedItems.Count > 0)
                lvFiles.Items.Remove(lvFiles.SelectedItems[0]);

            lvFiles.EndUpdate();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (sfdBrowsePdf.ShowDialog() != DialogResult.OK)
                return;

            txtOutfile.Text = sfdBrowsePdf.FileName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ofdBrowsePics.ShowDialog() != DialogResult.OK)
                return;

            lvFiles.BeginUpdate();

            foreach (var f in ofdBrowsePics.FileNames)
                lvFiles.Items.Add(f);

            lvFiles.EndUpdate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string OutFile = txtOutfile.Text;
            
            int c = lvFiles.Items.Count;
            if (c == 0)
                return;

            DateTime timeit = DateTime.Now;
            
            bool bIgnoreError = chkIgnoreError.Checked;

            PdfDocument doc = new PdfDocument();
            int i = 0;
            string err = null;
            foreach (ListViewItem lvi in lvFiles.Items)
            {
                string ImgFile = lvi.Text;
                if (!File.Exists(ImgFile))
                    continue;

                PdfPage page = new PdfPage();
                doc.Pages.Add(page);

                XGraphics xgr;
                XImage img;

                try
                {
                    xgr = XGraphics.FromPdfPage(page);
                    img = XImage.FromFile(ImgFile);
                }
                catch (Exception ex)
                {
                    err = string.Format(
                        "An exception while processing {0}\nDetail:\n{1}",
                        ImgFile,
                        ex.Message);

                    doc.Pages.Remove(page);
                    if (bIgnoreError)
                        continue;

                    break;
                }

                page.Width = img.PointWidth;
                page.Height = img.PointHeight;

                xgr.DrawImage(img, 0, 0);

                i++;
                Text = string.Format("{0} - processing {1}/{2}", STR_TITLE, i, c);

                Application.DoEvents();
            }

            try
            {
                doc.Save(OutFile);
                doc.Close();
            }
            catch (Exception ex)
            {
                err = string.Format(
                    "Could not write PDF file {0}!\nDetail:\n{1}",
                    OutFile,
                    ex.Message);
                return;
           }

            Text = string.Format(
                "{0} - converted {1} pictures in {2} seconds", 
                STR_TITLE,
                c, 
                (float)(DateTime.Now - timeit).Seconds);

            if (!string.IsNullOrEmpty(err))
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (chkOpenAfterConvert.Checked)
            {
                Process.Start(OutFile);
            }
            else
            {
                MessageBox.Show(
                    "Finished conversion",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = STR_TITLE;
#if DEBUG
            txtOutfile.Text = @"t:\downloads\t.pdf";
            foreach (string s in Directory.EnumerateFiles(@"t:\downloads\", "*.jpg"))
            {
                lvFiles.Items.Add(s);
            }
#endif
        }

        private void lvNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Up)
                    X_LvMoveUp(lvFiles);
                else if (e.KeyCode == Keys.Down)
                    X_LvMoveDown(lvFiles);
                else if (e.KeyCode == Keys.A)
                    lvFiles.SelectAll();
                else
                    return;

                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                lvFiles.DeleteSelected();
                e.Handled = true;
            }
        }

        private void lvFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lvFiles.SelectedItems.Count > 0)
                Process.Start(lvFiles.SelectedItems[0].Text);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortOrder so;
            if (lvFiles.Tag == null)
                so = SortOrder.Ascending;
            else
                so = (SortOrder)lvFiles.Tag;

            if (so == SortOrder.Ascending)
                so = SortOrder.Descending;
            else
                so = SortOrder.Ascending;
            
            lvFiles.Tag = so;
            lvFiles.Sorting = so;
            lvFiles.Sort();
            lvFiles.Sorting = SortOrder.None;
        }

        private void btnOpenPDF_Click(object sender, EventArgs e)
        {
            Process.Start(txtOutfile.Text);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            STR_TITLE + "\n\n"
            + "Created by:\n"
            + "\tElias Bachaalany <lallousz-x86@yahoo.com>\n\n"
            + "\thttp://lallouslab.net/\n"
            + "\n\n"
            + "Powered by:\n"
            + "\tPDF Sharp - http://pdfsharp.codeplex.com/"
            ,

            "About",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
