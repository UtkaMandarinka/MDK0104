using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа_с_строками
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partBookTitle = first.Text;
            string insertText = second.Text + "";

            string bookTitle = partBookTitle.Substring(5, 3);
            MessageBox.Show(bookTitle);

        }

        private void second_TextChanged(object sender, EventArgs e)
        {

        }

        private void first_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string partBookTitle = first.Text;
            string partBookTitle2 = second.Text;

            int i = partBookTitle.IndexOf(partBookTitle2);
            {
                if (i >= 0) MessageBox.Show(partBookTitle2 + " входит в строку " + partBookTitle);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string partBookTitle = first.Text;
            string partBookTitle2 = second.Text;

            textBox1.Text = partBookTitle + partBookTitle2;

            int all = int.Parse(first.Text) + int.Parse(second.Text);
            textBox1.Text += Environment.NewLine + all.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string partBookTitle = first.Text;
            string partBookTitle2 = second.Text;

            int all = int.Parse(partBookTitle);

            int charCode = all;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text = specialChar.ToString();

        }
    }
}
