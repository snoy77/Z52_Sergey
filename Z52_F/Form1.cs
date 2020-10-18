using MyTools.Office;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Z52_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetDirectoryPath()
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                return FBD.SelectedPath;
            }
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Leader a = new Leader("workers\\Worker.dll");
            string[] docFiles = new string[checkedListBox1.CheckedItems.Count];
            for (int i = 0; i < docFiles.Length; i++)
            {
                docFiles[i] = textBox_StartPath.Text + "\\" + checkedListBox1.CheckedItems[i].ToString();
            }

            a.StartWorker(new object[] { docFiles });
        }
        private void textBox_StartPath_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_StartPath.Text = this.GetDirectoryPath();
        }
        private void textBox_EndPath_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_EndPath.Text = this.GetDirectoryPath();
        }

        private void textBox_StartPath_TextChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            try
            {
                checkedListBox1.Items.AddRange(Directory.GetFiles(textBox_StartPath.Text)
                    .Where(x => x.EndsWith(".DOCX") || x.EndsWith(".docx"))
                    .Select(x => x.Replace(textBox_StartPath.Text+"\\", ""))
                    .ToArray());
                for(int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
            catch { }
        }
    }
}
