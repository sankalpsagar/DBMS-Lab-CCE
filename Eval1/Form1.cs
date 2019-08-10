using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Question
{
    public partial class Form1 : Form
    {
        public int totalT = 0;
        public int totalA = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open";
            dlg.ShowDialog();
            if (dlg.FileName == "")
            {
                MessageBox.Show("No file selected.");
                t1.Text = "No file imported.";
            }
            else
            {
                string fName = dlg.FileName;
                StreamReader sr = new StreamReader(fName);
                t1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fName = saveFileDialog1.FileName;
            if (fName == "")
            {
                MessageBox.Show("File not saved!");
            }
            else
            {
                StreamWriter sw = new StreamWriter(fName);
                sw.Write(t1.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            int price = 0;
            String item = "None";
            if (index == 0)
            {
                price = 10;
                item = "Pen";
            }
            else if (index == 1)
            {
                price = 20;
                item = "Book";
            }
            else if (index == 2)
            {
                price = 30;
                item = "Pencil";
            }
            int total = price * Int32.Parse(textBox1.Text);
            totalT += Int32.Parse(textBox1.Text);
            totalA += total;
            textBox2.Text = total.ToString();
            t1.AppendText("\n\t" + item + "\t" + textBox1.Text + "\t" + total.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total items: " + totalT + "\nTotal amount: " + totalA);
        }
    }
}
