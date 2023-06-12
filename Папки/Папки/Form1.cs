using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Папки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] astrFolders = System.IO.Directory.GetDirectories(@"D:\");
            foreach (string folder  in astrFolders) 
                listBox1.Items.Add(folder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"D:\");
            System.IO.DirectoryInfo[] folder = di.GetDirectories("*pro*");
            foreach (System.IO.DirectoryInfo maskdirs in folder)
                listBox1.Items.Add(maskdirs);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(@"D:\windows"))
                listBox1.Items.Add("Папка" + @"D:\Windows" + " существует");
            else
                listBox1.Items.Add("Папка не сущечтвует");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string oldPathString = @"D:\MyFolder";
            string newPathString = @"D:\NewFolder";
            Directory.Move(oldPathString, newPathString);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.Directory.Delete(@"D:\mutemp");
                MessageBox.Show("Папка удалена.");
            }

            catch (Exception) 
            {
                MessageBox.Show("Нельзя удалить непустую папку.");
           
            }
            finally { }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.Description = "Выберите папку";
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
                this.Text = fbd.SelectedPath;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"D:\lazarus");
            listBox1.Items.Clear();
            listBox1.Items.Add("Проверка папки: " + dir.Name);
            listBox1.Items.Add("Родительская папка: " + dir.Parent.Name);
            listBox1.Items.Add("Папка существует: ");
            listBox1.Items.Add(dir.Exists.ToString());
            if (dir.Exists)
            {
                listBox1.Items.Add("Папка создана: ");
                listBox1.Items.Add(dir.CreationTime.ToString());
                listBox1.Items.Add("Папка изменена: ");
                listBox1.Items.Add(dir.LastWriteTime.ToString());
                listBox1.Items.Add("Время последнего доступа: ");
                listBox1.Items.Add(dir.LastAccessTime.ToString());
                listBox1.Items.Add("Атрибуты папки: ");
                listBox1.Items.Add(dir.Attributes.ToString());
                listBox1.Items.Add("Папка сожержит: " + 
                dir.GetFiles().Length.ToString() + " файла");
            }
        }

    }
}
