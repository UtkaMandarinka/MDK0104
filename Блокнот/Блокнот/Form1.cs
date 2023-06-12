using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using static Блокнот.NewNoteBlock;

namespace Блокнот
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            this.Text = Properties.Settings.Default.newDocName + " - " + Properties.Settings.Default.programmName;

        }
        public MainForm(string fileName) // Открытие программы документом
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
            {
                try
                {
                    string programmName = Properties.Settings.Default.programmName;
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file, Encoding.Default);
                    notebox.Text = reader.ReadToEnd();
                    reader.Close();
                    docPath = fileName;
                    tbChange = false;
                    this.Text = Path.GetFileName(fileName) + " — " + programmName;
                    notebox.Select(0, 0);
                    TextWork.StatusAnalize(ref notebox, ref statusLinesCount, ref statusWordsCount, ref statusCharSpaceCount, ref statusCharCount);
                    TextWork.mEditEnableds(ref notebox, ref mEditCopy, ref mEditCut, ref mEditDel, ref mEditFind, ref mEditGo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        bool tbChange = false;
        string docPath = "";

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Width = Properties.Settings.Default.formWidth;
            this.Height = Properties.Settings.Default.formHeight;
            notebox.Font = Properties.Settings.Default.textFont;
            if (Properties.Settings.Default.statusStripVisible == true)
            { mViewStatusStrip.CheckState = CheckState.Checked; }
            else
            { mViewStatusStrip.CheckState = CheckState.Unchecked; }
            if (Properties.Settings.Default.textTransfer == true)
            { mFormatTransfer.CheckState = CheckState.Checked; }
            else
            { mFormatTransfer.CheckState = CheckState.Unchecked; }
        }

        private void notebox_TextChanged(object sender, EventArgs e)
        {
            tbChange = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.formWidth = this.Width;
            Properties.Settings.Default.formHeight = this.Height;
            Properties.Settings.Default.textTransfer = notebox.WordWrap;
            Properties.Settings.Default.textFont = notebox.Font;
            Properties.Settings.Default.statusStripVisible = statusStrip1.Visible;
            Properties.Settings.Default.Save();
        }


        internal class FileWork
        {
            public static void CreateFile(ref TextBox notebox, ref bool tbChange, ref string docPath) // Метод "Создать новый документ"
            {
                string newDocName = Properties.Settings.Default.newDocName;
                string programmName = Properties.Settings.Default.programmName;
                notebox.Clear();
                docPath = "";
                tbChange = false;
                MainForm.ActiveForm.Text = newDocName + " — " + programmName;
            }

            public static void OpenFile(ref TextBox notebox, ref bool tbChange, ref string docPath) // Метод "Открыть документ"
            {
                string programmName = Properties.Settings.Default.programmName;
                OpenFileDialog openDocument = new OpenFileDialog();
                openDocument.Title = "Открыть текстовый документ";
                openDocument.Filter = "Текстовые файлы (*.txt) |*.txt| Все файлы (*.*)|*.*";
                if (openDocument.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(openDocument.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file, Encoding.Default);
                    notebox.Text = reader.ReadToEnd();
                    reader.Close();
                    docPath = openDocument.FileName;
                    tbChange = false;
                    MainForm.ActiveForm.Text = openDocument.SafeFileName + " — " + programmName;
                }
            }

            public static void SaveFile(ref TextBox notebox, ref bool tbChange, ref string docPath) // Метод "Сохранить документ"
            {
                FileStream file = new FileStream(docPath, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file, Encoding.Default);
                writer.Write(notebox.Text);
                writer.Close();
                tbChange = false;
            }

            public static void SaveAsFile(ref TextBox notebox, ref bool tbChange, ref string docPath) // Метод "Сохранить документ как..."
            {
                string programmName = Properties.Settings.Default.programmName;
                SaveFileDialog saveAsDocument = new SaveFileDialog();
                saveAsDocument.Title = "Сохранить документ как...";
                saveAsDocument.FileName = "Текстовый документ";
                saveAsDocument.Filter = "Текстовые файлы (*.txt) |*.txt| Все файлы (*.*)|*.*";

                if (saveAsDocument.ShowDialog() == DialogResult.OK) //Если пользователь подтвердил сохранение
                {
                    //Создаем файл по пути, выбранному в окне сохранения
                    FileStream file = new FileStream(saveAsDocument.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(file, Encoding.Default);
                    writer.Write(notebox.Text); //записываем содержимое в файл
                    writer.Close(); //закрываем поток
                    tbChange = false;
                    docPath = saveAsDocument.FileName;
                    MainForm.ActiveForm.Text = Path.GetFileName(saveAsDocument.FileName) + " — " + programmName;
                }
                else
                {
                    tbChange = true;
                    return;
                }



            }










        }

        private void mFileNew_Click(object sender, EventArgs e)
        {

            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед созданием нового?", "Создание документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
                }
            }
            else
            {
                FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
            }



        }

        private void mFileOpen_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед открытием нового?", "Открытие документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                }
                else
                {
                    return;
                }
            }
            else
            {
                FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
            }









        }

        private void mFileSave_Click(object sender, EventArgs e)
        {
            if (docPath != "")
            {
                FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
            }
            else
            {
                FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
            }
        }

        private void mFileSaveAs_Click(object sender, EventArgs e)
        {
            FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
        }

        private void mFilePageParam_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
            }
        }

        private void mFilePrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument.Print();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка параметров печати.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void mFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед выходом?", "Выход из программы", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                    else if (docPath == "")
                    {
                        FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                }

            }


        }

        private void mEditCancel_Click(object sender, EventArgs e)
        {
            notebox.Undo();
        }

        private void mEditCut_Click(object sender, EventArgs e)
        {
            if (notebox.SelectionLength > 0)
            {
                notebox.Cut();
            }
        }

        private void mEditCopy_Click(object sender, EventArgs e)
        {
            if (notebox.SelectionLength > 0)
            {
                notebox.Copy();
            }
        }

        private void mEditPaste_Click(object sender, EventArgs e)
        {
            notebox.Paste();
        }

        private void mEditDel_Click(object sender, EventArgs e)
        {
            if (notebox.SelectionLength > 0)
            {
                notebox.SelectedText = "";
            }
        }

        private void mEditGiveAll_Click(object sender, EventArgs e)
        {
            notebox.SelectAll();
        }

        private void mEditTime_Click(object sender, EventArgs e)
        {
            notebox.AppendText(Environment.NewLine + Convert.ToString(System.DateTime.Now));
        }

        private void mEditFind_Click(object sender, EventArgs e)
        {
            SearchForm findText = new SearchForm();
            findText.Owner = this;
            findText.Show();
        }

        private void mEditGo_Click(object sender, EventArgs e)
        {
            GoToForm gotoform = new GoToForm();
            gotoform.Owner = this;
            gotoform.tbLineNum.Minimum = 0;
            gotoform.tbLineNum.Maximum = notebox.Lines.Count();
            gotoform.ShowDialog();
        }

        private void mFormatFont_Click(object sender, EventArgs e)
        {
            FontDialog.Font = notebox.Font;
            DialogResult = FontDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                notebox.Font = FontDialog.Font;
            }
        }

        private void mFormatTransfer_Click(object sender, EventArgs e)
        {
            if (mFormatTransfer.CheckState == CheckState.Checked)
            {
                notebox.WordWrap = true;
                notebox.ScrollBars = ScrollBars.Vertical;
                mEditGo.Enabled = false;
                statusLab1.Visible = false;
                statusLinesCount.Visible = false;
            }
            else
            {
                notebox.WordWrap = false;
                notebox.ScrollBars = ScrollBars.Both;
                mEditGo.Enabled = true;
                statusLab1.Visible = true;
                statusLinesCount.Visible = true;
            }
        }

        private void mViewStatusStrip_Click(object sender, EventArgs e)
        {
            if (mViewStatusStrip.CheckState == CheckState.Checked)
            {
                statusStrip1.Visible = true;
            }
            else
            {
                statusStrip1.Visible = false;
            }
        }

        private void mHelpAboutProgram_Click(object sender, EventArgs e)
        {

        }


    }


}

