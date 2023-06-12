namespace Блокнот
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            mFile = new ToolStripMenuItem();
            mFileNew = new ToolStripMenuItem();
            mFileOpen = new ToolStripMenuItem();
            mFileSave = new ToolStripMenuItem();
            mFileSaveAs = new ToolStripMenuItem();
            mFilePageParam = new ToolStripMenuItem();
            mFilePrint = new ToolStripMenuItem();
            mFileExit = new ToolStripMenuItem();
            mEdit = new ToolStripMenuItem();
            mEditCancel = new ToolStripMenuItem();
            mEditCut = new ToolStripMenuItem();
            mEditCopy = new ToolStripMenuItem();
            mEditPaste = new ToolStripMenuItem();
            mEditDel = new ToolStripMenuItem();
            mEditFind = new ToolStripMenuItem();
            mEditGo = new ToolStripMenuItem();
            mEditGiveAll = new ToolStripMenuItem();
            mEditTime = new ToolStripMenuItem();
            mFormat = new ToolStripMenuItem();
            mFormatTransfer = new ToolStripMenuItem();
            mFormatFont = new ToolStripMenuItem();
            mView = new ToolStripMenuItem();
            mViewStatusStrip = new ToolStripMenuItem();
            mHelp = new ToolStripMenuItem();
            mHelpAboutProgram = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLab1 = new ToolStripStatusLabel();
            statusLinesCount = new ToolStripStatusLabel();
            statusLab2 = new ToolStripStatusLabel();
            statusWordsCount = new ToolStripStatusLabel();
            statusLab3 = new ToolStripStatusLabel();
            statusCharSpaceCount = new ToolStripStatusLabel();
            statusLab4 = new ToolStripStatusLabel();
            statusCharCount = new ToolStripStatusLabel();
            notebox = new TextBox();
            printDocument = new System.Drawing.Printing.PrintDocument();
            printDialog = new PrintDialog();
            pageSetupDialog = new PageSetupDialog();
            FontDialog = new FontDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mFile, mEdit, mFormat, mView, mHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mFile
            // 
            mFile.DropDownItems.AddRange(new ToolStripItem[] { mFileNew, mFileOpen, mFileSave, mFileSaveAs, mFilePageParam, mFilePrint, mFileExit });
            mFile.Name = "mFile";
            mFile.Size = new Size(48, 20);
            mFile.Text = "Файл";
            // 
            // mFileNew
            // 
            mFileNew.Name = "mFileNew";
            mFileNew.ShortcutKeys = Keys.Control | Keys.N;
            mFileNew.Size = new Size(226, 22);
            mFileNew.Text = "Создать";
            mFileNew.Click += mFileNew_Click;
            // 
            // mFileOpen
            // 
            mFileOpen.Name = "mFileOpen";
            mFileOpen.ShortcutKeys = Keys.Control | Keys.O;
            mFileOpen.Size = new Size(226, 22);
            mFileOpen.Text = "Открыть...";
            mFileOpen.Click += mFileOpen_Click;
            // 
            // mFileSave
            // 
            mFileSave.Name = "mFileSave";
            mFileSave.ShortcutKeys = Keys.Control | Keys.S;
            mFileSave.Size = new Size(226, 22);
            mFileSave.Text = "Сохранить";
            mFileSave.Click += mFileSave_Click;
            // 
            // mFileSaveAs
            // 
            mFileSaveAs.Name = "mFileSaveAs";
            mFileSaveAs.ShortcutKeys = Keys.Control | Keys.Alt | Keys.S;
            mFileSaveAs.Size = new Size(226, 22);
            mFileSaveAs.Text = "Сохранить как...";
            mFileSaveAs.Click += mFileSaveAs_Click;
            // 
            // mFilePageParam
            // 
            mFilePageParam.Name = "mFilePageParam";
            mFilePageParam.Size = new Size(226, 22);
            mFilePageParam.Text = "Параметры страницы";
            mFilePageParam.Click += mFilePageParam_Click;
            // 
            // mFilePrint
            // 
            mFilePrint.Name = "mFilePrint";
            mFilePrint.ShortcutKeys = Keys.Control | Keys.P;
            mFilePrint.Size = new Size(226, 22);
            mFilePrint.Text = "Печать...";
            mFilePrint.Click += mFilePrint_Click;
            // 
            // mFileExit
            // 
            mFileExit.Name = "mFileExit";
            mFileExit.ShortcutKeys = Keys.Alt | Keys.F4;
            mFileExit.Size = new Size(226, 22);
            mFileExit.Text = "Выход";
            mFileExit.Click += mFileExit_Click;
            // 
            // mEdit
            // 
            mEdit.DropDownItems.AddRange(new ToolStripItem[] { mEditCancel, mEditCut, mEditCopy, mEditPaste, mEditDel, mEditFind, mEditGo, mEditGiveAll, mEditTime });
            mEdit.Name = "mEdit";
            mEdit.Size = new Size(59, 20);
            mEdit.Text = "Правка";
            // 
            // mEditCancel
            // 
            mEditCancel.Name = "mEditCancel";
            mEditCancel.ShortcutKeys = Keys.Control | Keys.Z;
            mEditCancel.Size = new Size(212, 22);
            mEditCancel.Text = "Отменить";
            mEditCancel.Click += mEditCancel_Click;
            // 
            // mEditCut
            // 
            mEditCut.Name = "mEditCut";
            mEditCut.ShortcutKeys = Keys.Control | Keys.X;
            mEditCut.Size = new Size(212, 22);
            mEditCut.Text = "Вырезать";
            mEditCut.Click += mEditCut_Click;
            // 
            // mEditCopy
            // 
            mEditCopy.Name = "mEditCopy";
            mEditCopy.ShortcutKeys = Keys.Control | Keys.C;
            mEditCopy.Size = new Size(212, 22);
            mEditCopy.Text = "Копировать ";
            mEditCopy.Click += mEditCopy_Click;
            // 
            // mEditPaste
            // 
            mEditPaste.Name = "mEditPaste";
            mEditPaste.ShortcutKeys = Keys.Control | Keys.V;
            mEditPaste.Size = new Size(212, 22);
            mEditPaste.Text = "Вставить";
            mEditPaste.Click += mEditPaste_Click;
            // 
            // mEditDel
            // 
            mEditDel.Name = "mEditDel";
            mEditDel.ShortcutKeys = Keys.Delete;
            mEditDel.Size = new Size(212, 22);
            mEditDel.Text = "Удалить";
            mEditDel.Click += mEditDel_Click;
            // 
            // mEditFind
            // 
            mEditFind.Name = "mEditFind";
            mEditFind.ShortcutKeys = Keys.Control | Keys.F;
            mEditFind.Size = new Size(212, 22);
            mEditFind.Text = "Найти и заменить";
            mEditFind.Click += mEditFind_Click;
            // 
            // mEditGo
            // 
            mEditGo.Name = "mEditGo";
            mEditGo.ShortcutKeys = Keys.Control | Keys.G;
            mEditGo.Size = new Size(212, 22);
            mEditGo.Text = "Перейти";
            mEditGo.Click += mEditGo_Click;
            // 
            // mEditGiveAll
            // 
            mEditGiveAll.Name = "mEditGiveAll";
            mEditGiveAll.ShortcutKeys = Keys.Control | Keys.A;
            mEditGiveAll.Size = new Size(212, 22);
            mEditGiveAll.Text = "Выделить всё";
            mEditGiveAll.Click += mEditGiveAll_Click;
            // 
            // mEditTime
            // 
            mEditTime.Name = "mEditTime";
            mEditTime.ShortcutKeys = Keys.F5;
            mEditTime.Size = new Size(212, 22);
            mEditTime.Text = "Время и дата";
            mEditTime.Click += mEditTime_Click;
            // 
            // mFormat
            // 
            mFormat.DropDownItems.AddRange(new ToolStripItem[] { mFormatTransfer, mFormatFont });
            mFormat.Name = "mFormat";
            mFormat.Size = new Size(62, 20);
            mFormat.Text = "Формат";
            // 
            // mFormatTransfer
            // 
            mFormatTransfer.CheckOnClick = true;
            mFormatTransfer.Name = "mFormatTransfer";
            mFormatTransfer.Size = new Size(186, 22);
            mFormatTransfer.Text = "Перенос по словам ";
            mFormatTransfer.Click += mFormatTransfer_Click;
            // 
            // mFormatFont
            // 
            mFormatFont.Name = "mFormatFont";
            mFormatFont.Size = new Size(186, 22);
            mFormatFont.Text = "Шрифт";
            mFormatFont.Click += mFormatFont_Click;
            // 
            // mView
            // 
            mView.DropDownItems.AddRange(new ToolStripItem[] { mViewStatusStrip });
            mView.Name = "mView";
            mView.Size = new Size(39, 20);
            mView.Text = "Вид";
            // 
            // mViewStatusStrip
            // 
            mViewStatusStrip.Checked = true;
            mViewStatusStrip.CheckOnClick = true;
            mViewStatusStrip.CheckState = CheckState.Checked;
            mViewStatusStrip.Name = "mViewStatusStrip";
            mViewStatusStrip.Size = new Size(180, 22);
            mViewStatusStrip.Text = "Строка состояния";
            mViewStatusStrip.Click += mViewStatusStrip_Click;
            // 
            // mHelp
            // 
            mHelp.DropDownItems.AddRange(new ToolStripItem[] { mHelpAboutProgram });
            mHelp.Name = "mHelp";
            mHelp.Size = new Size(65, 20);
            mHelp.Text = "Справка";
            // 
            // mHelpAboutProgram
            // 
            mHelpAboutProgram.Name = "mHelpAboutProgram";
            mHelpAboutProgram.Size = new Size(180, 22);
            mHelpAboutProgram.Text = "О программе";
            mHelpAboutProgram.Click += mHelpAboutProgram_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLab1, statusLinesCount, statusLab2, statusWordsCount, statusLab3, statusCharSpaceCount, statusLab4, statusCharCount });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLab1
            // 
            statusLab1.Name = "statusLab1";
            statusLab1.Size = new Size(109, 17);
            statusLab1.Text = "Количество строк:";
            // 
            // statusLinesCount
            // 
            statusLinesCount.Name = "statusLinesCount";
            statusLinesCount.Size = new Size(13, 17);
            statusLinesCount.Text = "0";
            // 
            // statusLab2
            // 
            statusLab2.Name = "statusLab2";
            statusLab2.Size = new Size(104, 17);
            statusLab2.Text = "Количество слов:";
            // 
            // statusWordsCount
            // 
            statusWordsCount.Name = "statusWordsCount";
            statusWordsCount.Size = new Size(13, 17);
            statusWordsCount.Text = "0";
            // 
            // statusLab3
            // 
            statusLab3.Name = "statusLab3";
            statusLab3.Size = new Size(142, 17);
            statusLab3.Text = "Символов с пробелами:";
            // 
            // statusCharSpaceCount
            // 
            statusCharSpaceCount.Name = "statusCharSpaceCount";
            statusCharSpaceCount.Size = new Size(13, 17);
            statusCharSpaceCount.Text = "0";
            // 
            // statusLab4
            // 
            statusLab4.Name = "statusLab4";
            statusLab4.Size = new Size(145, 17);
            statusLab4.Text = "Символов без пробелов:";
            // 
            // statusCharCount
            // 
            statusCharCount.Name = "statusCharCount";
            statusCharCount.Size = new Size(13, 17);
            statusCharCount.Text = "0";
            // 
            // notebox
            // 
            notebox.Dock = DockStyle.Fill;
            notebox.Location = new Point(0, 24);
            notebox.Multiline = true;
            notebox.Name = "notebox";
            notebox.ScrollBars = ScrollBars.Both;
            notebox.Size = new Size(800, 404);
            notebox.TabIndex = 2;
            notebox.TextChanged += notebox_TextChanged;
            // 
            // printDialog
            // 
            printDialog.Document = printDocument;
            printDialog.UseEXDialog = true;
            // 
            // pageSetupDialog
            // 
            pageSetupDialog.Document = printDocument;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(notebox);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mFile;
        private ToolStripMenuItem mFileNew;
        private ToolStripMenuItem mFileOpen;
        private ToolStripMenuItem mFileSave;
        private ToolStripMenuItem mFileSaveAs;
        private ToolStripMenuItem mFilePageParam;
        private ToolStripMenuItem mFilePrint;
        private ToolStripMenuItem mFileExit;
        private ToolStripMenuItem mEdit;
        private ToolStripMenuItem mEditCancel;
        private ToolStripMenuItem mEditCut;
        private ToolStripMenuItem mEditCopy;
        private ToolStripMenuItem mEditPaste;
        private ToolStripMenuItem mEditDel;
        private ToolStripMenuItem mEditFind;
        private ToolStripMenuItem mEditGo;
        private ToolStripMenuItem mEditGiveAll;
        private ToolStripMenuItem mEditTime;
        private ToolStripMenuItem mFormat;
        private ToolStripMenuItem mFormatTransfer;
        private ToolStripMenuItem mFormatFont;
        private ToolStripMenuItem mView;
        private ToolStripMenuItem mViewStatusStrip;
        private ToolStripMenuItem mHelp;
        private ToolStripMenuItem mHelpAboutProgram;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLab1;
        private ToolStripStatusLabel statusLinesCount;
        private ToolStripStatusLabel statusLab2;
        private ToolStripStatusLabel statusWordsCount;
        private ToolStripStatusLabel statusLab3;
        private ToolStripStatusLabel statusCharSpaceCount;
        private ToolStripStatusLabel statusLab4;
        private ToolStripStatusLabel statusCharCount;
        public TextBox notebox;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintDialog printDialog;
        private PageSetupDialog pageSetupDialog;
        private FontDialog FontDialog;
    }
}