namespace OnlyTXT
{
    partial class OnlyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlyForm));
            this.ss = new System.Windows.Forms.StatusStrip();
            this.tsslLength = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLines = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEmpty = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEOL = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslEncoding = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFile1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilePageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFile2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.tssEdit1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tssEdit2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditInsertDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditInsertTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditInsertISO8601 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEditEOL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditEOLWin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditEOLUnix = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditEOLMac = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptionsWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowEndOfLine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.tssView1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOptionsFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptionsBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tb = new System.Windows.Forms.TextBox();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAs = new System.Windows.Forms.ToolStripButton();
            this.tssTool1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCut = new System.Windows.Forms.ToolStripButton();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbPaste = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tssTool2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUndo = new System.Windows.Forms.ToolStripButton();
            this.tsbRedo = new System.Windows.Forms.ToolStripButton();
            this.tssTool3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInsertDate = new System.Windows.Forms.ToolStripButton();
            this.tsbInsertTime = new System.Windows.Forms.ToolStripButton();
            this.tsbInsertISO8601 = new System.Windows.Forms.ToolStripButton();
            this.tssTool4 = new System.Windows.Forms.ToolStripSeparator();
            this.fd = new System.Windows.Forms.FontDialog();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.pd = new System.Windows.Forms.PrintDialog();
            this.pdoc = new System.Drawing.Printing.PrintDocument();
            this.psd = new System.Windows.Forms.PageSetupDialog();
            this.ss.SuspendLayout();
            this.ms.SuspendLayout();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // ss
            // 
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslLength,
            this.tsslLines,
            this.tsslEmpty,
            this.tsslEOL,
            this.tsslEncoding,
            this.tsslMode});
            this.ss.Location = new System.Drawing.Point(0, 426);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(800, 24);
            this.ss.TabIndex = 0;
            this.ss.Text = "statusStrip1";
            // 
            // tsslLength
            // 
            this.tsslLength.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslLength.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsslLength.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslLength.Name = "tsslLength";
            this.tsslLength.Size = new System.Drawing.Size(63, 19);
            this.tsslLength.Text = "Length : 0";
            this.tsslLength.ToolTipText = "Length";
            // 
            // tsslLines
            // 
            this.tsslLines.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslLines.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsslLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslLines.Name = "tsslLines";
            this.tsslLines.Size = new System.Drawing.Size(53, 19);
            this.tsslLines.Text = "Lines : 0";
            this.tsslLines.ToolTipText = "Lines";
            // 
            // tsslEmpty
            // 
            this.tsslEmpty.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslEmpty.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsslEmpty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsslEmpty.Name = "tsslEmpty";
            this.tsslEmpty.Size = new System.Drawing.Size(408, 19);
            this.tsslEmpty.Spring = true;
            // 
            // tsslEOL
            // 
            this.tsslEOL.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslEOL.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsslEOL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslEOL.Name = "tsslEOL";
            this.tsslEOL.Size = new System.Drawing.Size(131, 19);
            this.tsslEOL.Text = "Windows (CR LF | \\r\\n)";
            // 
            // tsslEncoding
            // 
            this.tsslEncoding.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslEncoding.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsslEncoding.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslEncoding.Name = "tsslEncoding";
            this.tsslEncoding.Size = new System.Drawing.Size(101, 19);
            this.tsslEncoding.Text = "Encoding : UTF-8";
            // 
            // tsslMode
            // 
            this.tsslMode.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslMode.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsslMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslMode.Name = "tsslMode";
            this.tsslMode.Size = new System.Drawing.Size(29, 19);
            this.tsslMode.Text = "INS";
            this.tsslMode.ToolTipText = "Mode";
            // 
            // ms
            // 
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiOptions,
            this.tsmiHelp});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(800, 24);
            this.ms.TabIndex = 1;
            this.ms.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileNew,
            this.tsmiFileOpen,
            this.tsmiFileSave,
            this.tsmiFileSaveAs,
            this.tssFile1,
            this.tsmiFilePageSetup,
            this.tsmiFilePrint,
            this.tssFile2,
            this.tsmiFileExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "&File";
            // 
            // tsmiFileNew
            // 
            this.tsmiFileNew.Name = "tsmiFileNew";
            this.tsmiFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiFileNew.Size = new System.Drawing.Size(195, 22);
            this.tsmiFileNew.Text = "&New";
            this.tsmiFileNew.Click += new System.EventHandler(this.tsmiFileNew_Click);
            // 
            // tsmiFileOpen
            // 
            this.tsmiFileOpen.Name = "tsmiFileOpen";
            this.tsmiFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiFileOpen.Size = new System.Drawing.Size(195, 22);
            this.tsmiFileOpen.Text = "&Open...";
            this.tsmiFileOpen.Click += new System.EventHandler(this.tsmiFileOpen_Click);
            // 
            // tsmiFileSave
            // 
            this.tsmiFileSave.Name = "tsmiFileSave";
            this.tsmiFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiFileSave.Size = new System.Drawing.Size(195, 22);
            this.tsmiFileSave.Text = "&Save";
            this.tsmiFileSave.Click += new System.EventHandler(this.tsmiFileSave_Click);
            // 
            // tsmiFileSaveAs
            // 
            this.tsmiFileSaveAs.Name = "tsmiFileSaveAs";
            this.tsmiFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiFileSaveAs.Size = new System.Drawing.Size(195, 22);
            this.tsmiFileSaveAs.Text = "Save &As...";
            this.tsmiFileSaveAs.Click += new System.EventHandler(this.tsmiFileSaveAs_Click);
            // 
            // tssFile1
            // 
            this.tssFile1.Name = "tssFile1";
            this.tssFile1.Size = new System.Drawing.Size(192, 6);
            // 
            // tsmiFilePageSetup
            // 
            this.tsmiFilePageSetup.Name = "tsmiFilePageSetup";
            this.tsmiFilePageSetup.Size = new System.Drawing.Size(195, 22);
            this.tsmiFilePageSetup.Text = "Page Set&up...";
            this.tsmiFilePageSetup.Click += new System.EventHandler(this.tsmiFilePageSetup_Click);
            // 
            // tsmiFilePrint
            // 
            this.tsmiFilePrint.Name = "tsmiFilePrint";
            this.tsmiFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiFilePrint.Size = new System.Drawing.Size(195, 22);
            this.tsmiFilePrint.Text = "&Print...";
            this.tsmiFilePrint.Click += new System.EventHandler(this.tsmiFilePrint_Click);
            // 
            // tssFile2
            // 
            this.tssFile2.Name = "tssFile2";
            this.tssFile2.Size = new System.Drawing.Size(192, 6);
            // 
            // tsmiFileExit
            // 
            this.tsmiFileExit.Name = "tsmiFileExit";
            this.tsmiFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiFileExit.Size = new System.Drawing.Size(195, 22);
            this.tsmiFileExit.Text = "E&xit";
            this.tsmiFileExit.Click += new System.EventHandler(this.tsmiFileExit_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditUndo,
            this.tsmiEditRedo,
            this.tssEdit1,
            this.tsmiEditCut,
            this.tsmiEditCopy,
            this.tsmiEditPaste,
            this.tsmiEditDelete,
            this.tssEdit2,
            this.tsmiEditSelectAll,
            this.tsmiEditInsert,
            this.toolStripSeparator1,
            this.tsmiEditEOL});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(39, 20);
            this.tsmiEdit.Text = "&Edit";
            // 
            // tsmiEditUndo
            // 
            this.tsmiEditUndo.Name = "tsmiEditUndo";
            this.tsmiEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiEditUndo.Size = new System.Drawing.Size(164, 22);
            this.tsmiEditUndo.Text = "&Undo";
            this.tsmiEditUndo.Click += new System.EventHandler(this.tsmiEditUndo_Click);
            // 
            // tsmiEditRedo
            // 
            this.tsmiEditRedo.Name = "tsmiEditRedo";
            this.tsmiEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmiEditRedo.Size = new System.Drawing.Size(164, 22);
            this.tsmiEditRedo.Text = "&Redo";
            this.tsmiEditRedo.Click += new System.EventHandler(this.tsmiEditRedo_Click);
            // 
            // tssEdit1
            // 
            this.tssEdit1.Name = "tssEdit1";
            this.tssEdit1.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmiEditCut
            // 
            this.tsmiEditCut.Name = "tsmiEditCut";
            this.tsmiEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiEditCut.Size = new System.Drawing.Size(164, 22);
            this.tsmiEditCut.Text = "Cu&t";
            this.tsmiEditCut.Click += new System.EventHandler(this.tsmiEditCut_Click);
            // 
            // tsmiEditCopy
            // 
            this.tsmiEditCopy.Name = "tsmiEditCopy";
            this.tsmiEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiEditCopy.Size = new System.Drawing.Size(164, 22);
            this.tsmiEditCopy.Text = "&Copy";
            this.tsmiEditCopy.Click += new System.EventHandler(this.tsmiEditCopy_Click);
            // 
            // tsmiEditPaste
            // 
            this.tsmiEditPaste.Name = "tsmiEditPaste";
            this.tsmiEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiEditPaste.Size = new System.Drawing.Size(164, 22);
            this.tsmiEditPaste.Text = "&Paste";
            this.tsmiEditPaste.Click += new System.EventHandler(this.tsmiEditPaste_Click);
            // 
            // tsmiEditDelete
            // 
            this.tsmiEditDelete.Name = "tsmiEditDelete";
            this.tsmiEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmiEditDelete.Size = new System.Drawing.Size(164, 22);
            this.tsmiEditDelete.Text = "&Delete";
            // 
            // tssEdit2
            // 
            this.tssEdit2.Name = "tssEdit2";
            this.tssEdit2.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmiEditSelectAll
            // 
            this.tsmiEditSelectAll.Name = "tsmiEditSelectAll";
            this.tsmiEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiEditSelectAll.Size = new System.Drawing.Size(164, 22);
            this.tsmiEditSelectAll.Text = "Select &All";
            this.tsmiEditSelectAll.Click += new System.EventHandler(this.tsmiEditSelectAll_Click);
            // 
            // tsmiEditInsert
            // 
            this.tsmiEditInsert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditInsertDate,
            this.tsmiEditInsertTime,
            this.tsmiEditInsertISO8601});
            this.tsmiEditInsert.Name = "tsmiEditInsert";
            this.tsmiEditInsert.Size = new System.Drawing.Size(164, 22);
            this.tsmiEditInsert.Text = "Insert";
            // 
            // tsmiEditInsertDate
            // 
            this.tsmiEditInsertDate.Name = "tsmiEditInsertDate";
            this.tsmiEditInsertDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiEditInsertDate.Size = new System.Drawing.Size(138, 22);
            this.tsmiEditInsertDate.Text = "&Date";
            this.tsmiEditInsertDate.Click += new System.EventHandler(this.tsmiEditInsertDate_Click);
            // 
            // tsmiEditInsertTime
            // 
            this.tsmiEditInsertTime.Name = "tsmiEditInsertTime";
            this.tsmiEditInsertTime.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.tsmiEditInsertTime.Size = new System.Drawing.Size(138, 22);
            this.tsmiEditInsertTime.Text = "&Time";
            this.tsmiEditInsertTime.Click += new System.EventHandler(this.tsmiEditInsertTime_Click);
            // 
            // tsmiEditInsertISO8601
            // 
            this.tsmiEditInsertISO8601.Name = "tsmiEditInsertISO8601";
            this.tsmiEditInsertISO8601.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.tsmiEditInsertISO8601.Size = new System.Drawing.Size(138, 22);
            this.tsmiEditInsertISO8601.Text = "&ISO 8601";
            this.tsmiEditInsertISO8601.Click += new System.EventHandler(this.tsmiEditInsertISO8601_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // tsmiEditEOL
            // 
            this.tsmiEditEOL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditEOLWin,
            this.tsmiEditEOLUnix,
            this.tsmiEditEOLMac});
            this.tsmiEditEOL.Name = "tsmiEditEOL";
            this.tsmiEditEOL.Size = new System.Drawing.Size(164, 22);
            this.tsmiEditEOL.Text = "EOL";
            // 
            // tsmiEditEOLWin
            // 
            this.tsmiEditEOLWin.Name = "tsmiEditEOLWin";
            this.tsmiEditEOLWin.Size = new System.Drawing.Size(209, 22);
            this.tsmiEditEOLWin.Text = "Windows (CR LF | \\r\\n)";
            this.tsmiEditEOLWin.Click += new System.EventHandler(this.tsmiEditEOLWin_Click);
            // 
            // tsmiEditEOLUnix
            // 
            this.tsmiEditEOLUnix.Name = "tsmiEditEOLUnix";
            this.tsmiEditEOLUnix.Size = new System.Drawing.Size(209, 22);
            this.tsmiEditEOLUnix.Text = "UNIX && macOS X (LF | \\n)";
            this.tsmiEditEOLUnix.Click += new System.EventHandler(this.tsmiEditEOLUnix_Click);
            // 
            // tsmiEditEOLMac
            // 
            this.tsmiEditEOLMac.Name = "tsmiEditEOLMac";
            this.tsmiEditEOLMac.Size = new System.Drawing.Size(209, 22);
            this.tsmiEditEOLMac.Text = "MacOS (CR | \\r)";
            this.tsmiEditEOLMac.Click += new System.EventHandler(this.tsmiEditEOLMac_Click);
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptionsWordWrap,
            this.tsmiShowEndOfLine,
            this.tsmi,
            this.tssView1,
            this.tsmiOptionsFont,
            this.tsmiOptionsBackground});
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(61, 20);
            this.tsmiOptions.Text = "&Options";
            // 
            // tsmiOptionsWordWrap
            // 
            this.tsmiOptionsWordWrap.Checked = true;
            this.tsmiOptionsWordWrap.CheckOnClick = true;
            this.tsmiOptionsWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiOptionsWordWrap.Name = "tsmiOptionsWordWrap";
            this.tsmiOptionsWordWrap.Size = new System.Drawing.Size(179, 22);
            this.tsmiOptionsWordWrap.Text = "Word Wrap";
            this.tsmiOptionsWordWrap.Click += new System.EventHandler(this.tsmiOptionsWordWrap_Click);
            // 
            // tsmiShowEndOfLine
            // 
            this.tsmiShowEndOfLine.CheckOnClick = true;
            this.tsmiShowEndOfLine.Name = "tsmiShowEndOfLine";
            this.tsmiShowEndOfLine.Size = new System.Drawing.Size(179, 22);
            this.tsmiShowEndOfLine.Text = "Show End Of Line";
            // 
            // tsmi
            // 
            this.tsmi.Name = "tsmi";
            this.tsmi.Size = new System.Drawing.Size(179, 22);
            this.tsmi.Text = "Show Spaces";
            // 
            // tssView1
            // 
            this.tssView1.Name = "tssView1";
            this.tssView1.Size = new System.Drawing.Size(176, 6);
            // 
            // tsmiOptionsFont
            // 
            this.tsmiOptionsFont.Name = "tsmiOptionsFont";
            this.tsmiOptionsFont.Size = new System.Drawing.Size(179, 22);
            this.tsmiOptionsFont.Text = "Font...";
            this.tsmiOptionsFont.Click += new System.EventHandler(this.tsmiOptionsFont_Click);
            // 
            // tsmiOptionsBackground
            // 
            this.tsmiOptionsBackground.Name = "tsmiOptionsBackground";
            this.tsmiOptionsBackground.Size = new System.Drawing.Size(179, 22);
            this.tsmiOptionsBackground.Text = "Background Color...";
            this.tsmiOptionsBackground.Click += new System.EventHandler(this.tsmiOptionsBackground_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmiHelp.Text = "&Help";
            // 
            // tb
            // 
            this.tb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb.Font = new System.Drawing.Font("Fira Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(0, 49);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb.Size = new System.Drawing.Size(800, 376);
            this.tb.TabIndex = 2;
            this.tb.Text = resources.GetString("tb.Text");
            this.tb.ModifiedChanged += new System.EventHandler(this.tb_ModifiedChanged);
            this.tb.SizeChanged += new System.EventHandler(this.tb_SizeChanged);
            this.tb.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // ts
            // 
            this.ts.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOpen,
            this.tsbSave,
            this.tsbSaveAs,
            this.tssTool1,
            this.tsbCut,
            this.tsbCopy,
            this.tsbPaste,
            this.tsbDelete,
            this.tssTool2,
            this.tsbUndo,
            this.tsbRedo,
            this.tssTool3,
            this.tsbInsertDate,
            this.tsbInsertTime,
            this.tsbInsertISO8601,
            this.tssTool4});
            this.ts.Location = new System.Drawing.Point(0, 24);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(800, 27);
            this.ts.TabIndex = 3;
            this.ts.Text = "Tool Strip";
            // 
            // tsbNew
            // 
            this.tsbNew.AutoSize = false;
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNew.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(24, 24);
            this.tsbNew.Text = "";
            this.tsbNew.ToolTipText = "New";
            this.tsbNew.Click += new System.EventHandler(this.tsmiFileNew_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.AutoSize = false;
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOpen.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(24, 24);
            this.tsbOpen.Text = "";
            this.tsbOpen.ToolTipText = "Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsmiFileOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.AutoSize = false;
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(24, 24);
            this.tsbSave.Text = "";
            this.tsbSave.ToolTipText = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsmiFileSave_Click);
            // 
            // tsbSaveAs
            // 
            this.tsbSaveAs.AutoSize = false;
            this.tsbSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSaveAs.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveAs.Image")));
            this.tsbSaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAs.Name = "tsbSaveAs";
            this.tsbSaveAs.Size = new System.Drawing.Size(24, 24);
            this.tsbSaveAs.Text = "";
            this.tsbSaveAs.ToolTipText = "Save As";
            this.tsbSaveAs.Click += new System.EventHandler(this.tsmiFileSaveAs_Click);
            // 
            // tssTool1
            // 
            this.tssTool1.Name = "tssTool1";
            this.tssTool1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbCut
            // 
            this.tsbCut.AutoSize = false;
            this.tsbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCut.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCut.Image = ((System.Drawing.Image)(resources.GetObject("tsbCut.Image")));
            this.tsbCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCut.Name = "tsbCut";
            this.tsbCut.Size = new System.Drawing.Size(24, 24);
            this.tsbCut.Text = "";
            this.tsbCut.ToolTipText = "Cut";
            this.tsbCut.Click += new System.EventHandler(this.tsmiEditCut_Click);
            // 
            // tsbCopy
            // 
            this.tsbCopy.AutoSize = false;
            this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCopy.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopy.Image")));
            this.tsbCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(24, 24);
            this.tsbCopy.Text = "";
            this.tsbCopy.ToolTipText = "Copy";
            this.tsbCopy.Click += new System.EventHandler(this.tsmiEditCopy_Click);
            // 
            // tsbPaste
            // 
            this.tsbPaste.AutoSize = false;
            this.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPaste.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsbPaste.Image")));
            this.tsbPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPaste.Name = "tsbPaste";
            this.tsbPaste.Size = new System.Drawing.Size(24, 24);
            this.tsbPaste.Text = "";
            this.tsbPaste.ToolTipText = "Paste";
            this.tsbPaste.Click += new System.EventHandler(this.tsmiEditPaste_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.AutoSize = false;
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDelete.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(24, 24);
            this.tsbDelete.Text = "";
            this.tsbDelete.ToolTipText = "Delete";
            // 
            // tssTool2
            // 
            this.tssTool2.Name = "tssTool2";
            this.tssTool2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbUndo
            // 
            this.tsbUndo.AutoSize = false;
            this.tsbUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbUndo.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbUndo.Image = ((System.Drawing.Image)(resources.GetObject("tsbUndo.Image")));
            this.tsbUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUndo.Name = "tsbUndo";
            this.tsbUndo.Size = new System.Drawing.Size(24, 24);
            this.tsbUndo.Text = "";
            this.tsbUndo.ToolTipText = "Undo";
            this.tsbUndo.Click += new System.EventHandler(this.tsmiEditUndo_Click);
            // 
            // tsbRedo
            // 
            this.tsbRedo.AutoSize = false;
            this.tsbRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRedo.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbRedo.Image = ((System.Drawing.Image)(resources.GetObject("tsbRedo.Image")));
            this.tsbRedo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRedo.Name = "tsbRedo";
            this.tsbRedo.Size = new System.Drawing.Size(24, 24);
            this.tsbRedo.Text = "";
            this.tsbRedo.ToolTipText = "Redo";
            this.tsbRedo.Click += new System.EventHandler(this.tsmiEditRedo_Click);
            // 
            // tssTool3
            // 
            this.tssTool3.Name = "tssTool3";
            this.tssTool3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbInsertDate
            // 
            this.tsbInsertDate.AutoSize = false;
            this.tsbInsertDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbInsertDate.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbInsertDate.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertDate.Image")));
            this.tsbInsertDate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbInsertDate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertDate.Name = "tsbInsertDate";
            this.tsbInsertDate.Size = new System.Drawing.Size(24, 24);
            this.tsbInsertDate.Text = "";
            this.tsbInsertDate.ToolTipText = "Insert Date";
            this.tsbInsertDate.Click += new System.EventHandler(this.tsmiEditInsertDate_Click);
            // 
            // tsbInsertTime
            // 
            this.tsbInsertTime.AutoSize = false;
            this.tsbInsertTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbInsertTime.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbInsertTime.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertTime.Image")));
            this.tsbInsertTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbInsertTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertTime.Margin = new System.Windows.Forms.Padding(0);
            this.tsbInsertTime.Name = "tsbInsertTime";
            this.tsbInsertTime.Size = new System.Drawing.Size(24, 24);
            this.tsbInsertTime.Text = "⏰";
            this.tsbInsertTime.ToolTipText = "Insert Time";
            this.tsbInsertTime.Click += new System.EventHandler(this.tsmiEditInsertTime_Click);
            // 
            // tsbInsertISO8601
            // 
            this.tsbInsertISO8601.AutoSize = false;
            this.tsbInsertISO8601.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbInsertISO8601.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbInsertISO8601.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertISO8601.Image")));
            this.tsbInsertISO8601.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbInsertISO8601.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertISO8601.Margin = new System.Windows.Forms.Padding(0);
            this.tsbInsertISO8601.Name = "tsbInsertISO8601";
            this.tsbInsertISO8601.Size = new System.Drawing.Size(24, 24);
            this.tsbInsertISO8601.Text = "";
            this.tsbInsertISO8601.ToolTipText = "Insert ISO 8601";
            this.tsbInsertISO8601.Click += new System.EventHandler(this.tsmiEditInsertISO8601_Click);
            // 
            // tssTool4
            // 
            this.tssTool4.Name = "tssTool4";
            this.tssTool4.Size = new System.Drawing.Size(6, 27);
            // 
            // pd
            // 
            this.pd.AllowSelection = true;
            this.pd.AllowSomePages = true;
            this.pd.Document = this.pdoc;
            this.pd.ShowHelp = true;
            this.pd.UseEXDialog = true;
            // 
            // pdoc
            // 
            this.pdoc.DocumentName = "OnlyTXT";
            this.pdoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdoc_PrintPage);
            // 
            // psd
            // 
            this.psd.Document = this.pdoc;
            // 
            // OnlyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.ms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms;
            this.Name = "OnlyForm";
            this.Text = "OnlyTXT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnlyForm_FormClosing);
            this.Load += new System.EventHandler(this.OnlyForm_Load);
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator tssFile1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilePageSetup;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilePrint;
        private System.Windows.Forms.ToolStripSeparator tssFile2;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditUndo;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditRedo;
        private System.Windows.Forms.ToolStripSeparator tssEdit1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditDelete;
        private System.Windows.Forms.ToolStripSeparator tssEdit2;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditInsert;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptionsWordWrap;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowEndOfLine;
        private System.Windows.Forms.ToolStripSeparator tssView1;
        private System.Windows.Forms.FontDialog fd;
        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptionsFont;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.PrintDialog pd;
        private System.Windows.Forms.ToolStripMenuItem tsmi;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptionsBackground;
        private System.Windows.Forms.ToolStripStatusLabel tsslLength;
        private System.Windows.Forms.ToolStripStatusLabel tsslLines;
        private System.Windows.Forms.ToolStripStatusLabel tsslEncoding;
        private System.Windows.Forms.ToolStripStatusLabel tsslMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditEOL;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditEOLWin;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditEOLUnix;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditEOLMac;
        private System.Windows.Forms.ToolStripStatusLabel tsslEOL;
        private System.Windows.Forms.ToolStripStatusLabel tsslEmpty;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditInsertDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditInsertTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditInsertISO8601;
        private System.Drawing.Printing.PrintDocument pdoc;
        private System.Windows.Forms.PageSetupDialog psd;
        private System.Windows.Forms.ToolStripButton tsbSaveAs;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator tssTool1;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbCut;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripButton tsbPaste;
        private System.Windows.Forms.ToolStripSeparator tssTool2;
        private System.Windows.Forms.ToolStripButton tsbUndo;
        private System.Windows.Forms.ToolStripButton tsbRedo;
        private System.Windows.Forms.ToolStripSeparator tssTool3;
        private System.Windows.Forms.ToolStripButton tsbInsertDate;
        private System.Windows.Forms.ToolStripButton tsbInsertTime;
        private System.Windows.Forms.ToolStripButton tsbInsertISO8601;
        private System.Windows.Forms.ToolStripSeparator tssTool4;
    }
}
