using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("C:/Users/Eltaer/Desktop/web/index.html");
            Size = new Size(1920, 1080);
        }

        private void webстраница2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("C:/Users/Eltaer/Desktop/web/index2.html");
            Size = new Size(1920, 1080);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text_box1 = textBox1.Text;
                string text_box2 = textBox2.Text;

                int x = int.Parse(text_box1);
                int y = int.Parse(text_box2);

                if ((x * x + y * y <= 25) & (y <= x + 2) & (x <= 0))
                {
                    textBox3.Text = "Принадлежит";
                    toolStripStatusLabel1.Text = "Принадлежит";
                }
                else
                {
                    textBox3.Text = "Не принадлежит";
                    toolStripStatusLabel1.Text = " Не принадлежит";
                }

            }
            catch
            {
                MessageBox.Show("Некорректный ввод");
            }
        }
    }
}
