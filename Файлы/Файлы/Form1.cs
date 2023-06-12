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

namespace Файлы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static long GetDirectorySize(System.IO.DirectoryInfo directory, bool includeSubdir)
        {
            long totalSize = 0;
            System.IO.FileInfo[] files = directory.GetFiles();

            foreach (System.IO.FileInfo file in files)
            {
                totalSize += file.Length;
            }

            if (includeSubdir)
            {

                System.IO.DirectoryInfo[] dirs = directory.GetDirectories();
                foreach (System.IO.DirectoryInfo dir in dirs)
                {
                    totalSize += GetDirectorySize(dir, true);
                }
            }
            return totalSize;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            System.IO.DirectoryInfo dir = new
            System.IO.DirectoryInfo(@"D:\Steam");
            listBox1.Items.Add("Общий размер: " + GetDirectorySize(dir, true).ToString() + " байт.");
            this.Cursor = Cursors.Default;
        }

        private void FillNodes(TreeNode dirNode)
        {
            DirectoryInfo dir = new DirectoryInfo(dirNode.FullPath);
            foreach (DirectoryInfo dirItem in dir.GetDirectories())
            {
                TreeNode newNode = new TreeNode(dirItem.Name);
                dirNode.Nodes.Add(newNode);
                newNode.Nodes.Add("*");
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "*")
            {
                e.Node.Nodes.Clear();
                FillNodes(e.Node);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode rootNode = new TreeNode(@"D:\");
            treeView1.Nodes.Add(rootNode);
            FillNodes(rootNode);
            treeView1.Nodes[0].Expand();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] directoryEntries = System.IO.Directory.GetFileSystemEntries(@"D:\Steam");
            foreach (string str in directoryEntries)
            {
                listBox1.Items.Add(str);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] astrFiles = System.IO.Directory.GetFiles(@"D:\Steam");
            listBox1.Items.Add("Всего файлов: " + astrFiles.Length);
            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] astrFiles = System.IO.Directory.GetFiles(@"D:\Steam", "*.tx?*");
            listBox1.Items.Add("Всего фалов: " + astrFiles.Length);
            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\PC-VOL-64-85.txt"))
                listBox1.Items.Add("Файл PC-VOL-64-85.txt существует");
            else
                listBox1.Items.Add("Файл PC-VOL-64-85.txt не существует");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string fileNamePath = @"D:\Тест.txt";
            listBox1.Items.Add(System.IO.Path.GetFileName(fileNamePath));
            listBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileNamePath));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string fileNamePath = @"D:\Тест.txt";
            listBox1.Items.Add(System.IO.Path.GetExtension(fileNamePath));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string path = @"D:\Тест.txt";

            if ((System.IO.File.GetAttributes(path) & System.IO.FileAttributes.Hidden) == System.IO.FileAttributes.Hidden)
            {
                System.IO.File.SetAttributes(path, System.IO.FileAttributes.Normal);
                MessageBox.Show("Файл больше не является скрытым", path);
            }

            else
            {
                System.IO.File.SetAttributes(path, System.IO.File.GetAttributes(path) | System.IO.FileAttributes.Hidden);
                MessageBox.Show("Файл стал скрытым", path);

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(@"D:\Тест.txt");
            listBox1.Items.Clear();
            listBox1.Items.Add("Свойства для файла: " + file.Name);
            listBox1.Items.Add("Наличие файла: " + file.Exists.ToString());
            if (file.Exists)
            {
                listBox1.Items.Add("Время создания файла: ");
                listBox1.Items.Add(file.CreationTime.ToString());
                listBox1.Items.Add("Последнее изменение файла: ");
                listBox1.Items.Add(file.LastWriteTime.ToString());
                listBox1.Items.Add("Файл был открыт в последний раз: ");
                listBox1.Items.Add(file.LastAccessTime.ToString());
                listBox1.Items.Add("Размер файла (в байтах): ");
                listBox1.Items.Add(file.Length.ToString());
                listBox1.Items.Add("Атрибуты файла: ");
                listBox1.Items.Add(file.Attributes.ToString());

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo file = new
            System.IO.FileInfo(@"D:\text.txt");
            listBox1.Items.Clear();
            listBox1.Items.Add("Свойства для файла: " + file.Name);
            listBox1.Items.Add("Наличие файла: " + file.Exists.ToString());
            if (file.Exists)
            {
                listBox1.Items.Add("Время создания файла: ");
                listBox1.Items.Add(file.CreationTime.ToString());
                listBox1.Items.Add("Последнее изменение файла: ");
                listBox1.Items.Add(file.LastWriteTime.ToString());
                listBox1.Items.Add("Файл был открыт в последний раз: ");
                listBox1.Items.Add(file.LastAccessTime.ToString());
                listBox1.Items.Add("Размер файла (в байтах): ");
                listBox1.Items.Add(file.Length.ToString());
                listBox1.Items.Add("Атрибуты файла: ");
                listBox1.Items.Add(file.Attributes.ToString());
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(System.IO.Path.GetTempFileName());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string randomFile = System.IO.Path.GetRandomFileName();
            MessageBox.Show(randomFile);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string tempText = System.IO.Path.ChangeExtension(System.IO.Path.GetRandomFileName(), ".txt");
            MessageBox.Show(tempText);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\Тест.txt";
            FileStream stream = File.Open(fileName, FileMode.Open);
            stream.Lock(0, stream.Length);
            stream.Unlock(0, stream.Length);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\text.txt";
            if (System.IO.File.Exists(fileName))
            {
                MessageBox.Show("Указанный файл уже существует.", fileName);
                return;
            }
            System.IO.StreamWriter sr = System.IO.File.CreateText(fileName);
            sr.WriteLine("Раз, два, три, четыре, пять");
            sr.WriteLine("1, 2 , 3. 9 1/2 и так далее");
            sr.WriteLine("Я изучаю {0} и {1}.", "С#", "Visual Basic");
            sr.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\Тест.txt";
            using (System.IO.StreamWriter sw = System.IO.File.AppendText(fileName))
            {
                sw.WriteLine("Добавили ещё одну строчку");
            }


            using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(s);
                }

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(@"D:\Тест.txt"))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
                
            }
        }
    } 
}

        
    

