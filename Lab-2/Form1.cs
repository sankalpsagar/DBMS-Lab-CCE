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


namespace San_Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open";
            dlg.ShowDialog();
            if (dlg.FileName == "")
            {
                MessageBox.Show("No file selected.");
                richTextBox1.Text = "No file imported.";
            }
            else
            {
                string fName = dlg.FileName;
                StreamReader sr = new StreamReader(fName);
                richTextBox1.Text = sr.ReadToEnd();
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
                sw.Write(richTextBox1.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
           cd.Color = richTextBox1.SelectionColor;
           if (cd.ShowDialog() == DialogResult.OK)
           {
               richTextBox1.SelectionColor = cd.Color;
           }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = richTextBox1.SelectionColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = cd.Color;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fName = saveFileDialog1.FileName;
            if (fName == "")
            {
                MessageBox.Show("File not saved!");
                richTextBox1.Text = "";
            }
            else
            {
                StreamWriter sw = new StreamWriter(fName);
                sw.Write(richTextBox1.Text);
                sw.Flush();
                sw.Close();
                richTextBox1.Text = "";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting");
            this.Close();
        }
    }
}
