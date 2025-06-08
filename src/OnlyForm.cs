// <copyright file="OnlyForm.cs" company="OnlyTXT Developers">
// Copyright (c) 2025 Neil McNeight.
// Read the LICENSE file in the root project directory for more details.
// </copyright>

using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OnlyTXT
{
    /// <summary>
    ///
    /// </summary>
    [Flags]
    public enum EndOfLineStyle
    {
        /// <summary>
        ///
        /// </summary>
        Unknown = 0,

        /// <summary>
        ///
        /// </summary>
        CR = 1,

        /// <summary>
        ///
        /// </summary>
        LF = 2,

        /// <summary>
        ///
        /// </summary>
        CRLF = CR | LF,

        /// <summary>
        ///
        /// </summary>
        Unix = LF,

        /// <summary>
        ///
        /// </summary>
        macOS = CR,

        /// <summary>
        ///
        /// </summary>
        Windows = CRLF,
    }

    /// <summary>
    ///
    /// </summary>
    public partial class OnlyForm : Form
    {
        private EndOfLineStyle _eolStyle;

        private string _baseTitle;
        private string _currentFileName;

        public string BaseTitle
        {
            get => _baseTitle;
            set
            {
                Text = "OnlyTXT (" + (_baseTitle = value) + (tb.Modified ? ") *" : ")");
            }
        }

        public string CurrentFileName
        {
            get => _currentFileName;
            set
            {
                BaseTitle = Path.GetFileName(_currentFileName = value);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public OnlyForm()
        {
            InitializeComponent();
        }

        private void OnlyForm_Load(object sender, EventArgs e)
        {
            BaseTitle = "untitled";

            tb.DeselectAll();
            tb.DataBindings.Add(new Binding("BackColor", Properties.Settings.Default, "BackgroundColor", true, DataSourceUpdateMode.OnPropertyChanged));
            tb.DataBindings.Add(new Binding("Font", Properties.Settings.Default, "Font", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void OnlyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void tsmiFileNew_Click(object sender, EventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                var result = MessageBox.Show("The text buffer is not empty. Are you sure you want to erase everything?",
                    "OnlyTXT",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            tb.Clear();
        }

        private void tsmiFileOpen_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                CurrentFileName = ofd.FileName;
                tb.Text = File.ReadAllText(CurrentFileName, Encoding.UTF8);
            }
        }

        private void tsmiFileSave_Click(object sender, EventArgs e)
        {
            if (CurrentFileName is null && sfd.ShowDialog(this) == DialogResult.OK)
            {
                CurrentFileName = sfd.FileName;
            }

            if (!(CurrentFileName is null))
            {
                File.WriteAllText(CurrentFileName, tb.Text, Encoding.UTF8);
            }
        }

        private void tsmiFileSaveAs_Click(object sender, EventArgs e)
        {
        }

        private void tsmiFilePageSetup_Click(object sender, EventArgs e)
        {
            // Initialize the dialog's PrinterSettings property to hold user
            // defined printer settings.
            psd.PageSettings =
                new System.Drawing.Printing.PageSettings();

            // Initialize dialog's PrinterSettings property to hold user
            // set printer settings.
            psd.PrinterSettings =
                new System.Drawing.Printing.PrinterSettings();

            //Show the dialog storing the result.
            DialogResult result = psd.ShowDialog();

            // If the result is OK, display selected settings in
            // ListBox1. These values can be used when printing the
            // document.
            if (result == DialogResult.OK)
            {
                object[] results = new object[]{
                    psd.PageSettings.Margins,
                    psd.PageSettings.PaperSize,
                    psd.PageSettings.Landscape,
                    psd.PrinterSettings.PrinterName,
                    psd.PrinterSettings.PrintRange};
            }
        }

        private void tsmiFilePrint_Click(object sender, EventArgs e)
        {
            // If the result is OK then print the document.
            if (pd.ShowDialog() == DialogResult.OK)
            {
                pdoc.Print();
            }
        }

        /// <summary>
        /// The PrintDialog will print the document by handling the document's PrintPage event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Insert code to render the page here.
            // This code will be called when the control is drawn.

            // Sets the value of charactersOnPage to the number of characters
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(tb.Text, tb.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, out int charactersOnPage, out int linesPerPage);

            // Draws the string within the bounds of the page
            e.Graphics.DrawString(tb.Text, tb.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            tb.Text = tb.Text.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (tb.Text.Length > 0);
        }

        private void tsmiFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiEditUndo_Click(object sender, System.EventArgs e)
        {
            tb.Undo();
        }

        private void tsmiEditRedo_Click(object sender, System.EventArgs e)
        {
        }

        private void tsmiEditCut_Click(object sender, System.EventArgs e)
        {
            tb.Cut();
        }

        private void tsmiEditCopy_Click(object sender, System.EventArgs e)
        {
            tb.Copy();
        }

        private void tsmiEditPaste_Click(object sender, System.EventArgs e)
        {
            tb.Paste();
        }

        private void tsmiEditSelectAll_Click(object sender, EventArgs e)
        {
            tb.SelectAll();
        }

        private void tsmiEditInsertDate_Click(object sender, EventArgs e)
        {
            tb.Paste(DateTime.Now.ToString("D"));
        }

        private void tsmiEditInsertTime_Click(object sender, EventArgs e)
        {
            tb.Paste(DateTime.Now.ToString("T"));
        }

        private void tsmiEditInsertISO8601_Click(object sender, EventArgs e)
        {
            tb.Paste(DateTime.Now.ToString("O"));
        }

        private void tsmiEditEOLWin_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem tsmi)
            {
                tsslEOL.Text = tsmi.Text;
                _eolStyle = EndOfLineStyle.Windows;
            }
        }

        private void tsmiEditEOLUnix_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem tsmi)
            {
                tsslEOL.Text = tsmi.Text;
                _eolStyle = EndOfLineStyle.Unix;
            }
        }

        private void tsmiEditEOLMac_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem tsmi)
            {
                tsslEOL.Text = tsmi.Text;
                _eolStyle = EndOfLineStyle.macOS;
            }
        }

        private void tsmiOptionsWordWrap_Click(object sender, System.EventArgs e)
        {
            tb.WordWrap = tsmiOptionsWordWrap.Checked;
            if (tb.WordWrap)
            {
                tb.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                tb.ScrollBars = ScrollBars.Both;
            }
        }

        private void tsmiOptionsFont_Click(object sender, System.EventArgs e)
        {
            fd.ShowColor = true;

            fd.Font = tb.Font;
            fd.Color = tb.ForeColor;

            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                tb.Font = fd.Font;
                tb.ForeColor = fd.Color;
            }
        }

        private void tsmiOptionsBackground_Click(object sender, System.EventArgs e)
        {
            // Keeps the user from selecting a custom color.
            cd.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            cd.ShowHelp = true;
            // Sets the initial color select to the current text color.
            cd.Color = tb.BackColor;

            // Update the text box color if the user clicks OK
            if (cd.ShowDialog() != DialogResult.Cancel)
            {
                tb.BackColor = cd.Color;
            }
        }

        private void tb_ModifiedChanged(object sender, EventArgs e)
        {
            UpdateStatusStrip();
        }

        private void tb_SizeChanged(object sender, EventArgs e)
        {
            UpdateStatusStrip();
        }

        private void tb_TextChanged(object sender, System.EventArgs e)
        {
            UpdateStatusStrip();
        }

        private void UpdateStatusStrip()
        {
            tsslLength.Text = "Length : " + tb.TextLength;
            tsslLines.Text = "Lines : " + tb.Lines.Length;
        }
    }
}