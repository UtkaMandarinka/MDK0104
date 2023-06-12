using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Диск
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] astrLogicalDrives = System.IO.Directory.GetLogicalDrives();
            foreach (string disk in astrLogicalDrives)
                listBox1.Items.Add(disk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.DriveInfo drv = new System.IO.DriveInfo(@"d:/");
            listBox1.Items.Clear();
            listBox1.Items.Add("Диск: " + drv.Name);
            if (drv.IsReady) 
            {
                listBox1.Items.Add("Тип диска: " + drv.DriveType.ToString());
                listBox1.Items.Add("Файловая система: " + drv.DriveFormat.ToString());
                listBox1.Items.Add("Свободно место на диске: " + drv.AvailableFreeSpace.ToString());

            }
        }
    }
}
