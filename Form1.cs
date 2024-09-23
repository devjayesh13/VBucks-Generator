using System;
using System.IO;
using System.Windows.Forms;

namespace VBucks_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int i;
        public string path;

        private void remove_fortnite(object sender, EventArgs e)
        {
            if (boxif.Text == " " || vbucksinfo.Text == " " ||
                boxif.Text == "Enter Username" || vbucksinfo.Text == "Enter VBucks")
            {
                MessageBox.Show("Enter your info", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Provide path to the game folder", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (!int.TryParse(vbucksinfo.Text, out i))
                {
                    IntProblem();
                }
                else
                {
                    MainFortniteSubRemove();
                    boxif.Text = "";
                    vbucksinfo.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
        }

        private void remove_text(object sender, EventArgs e)
        {
            boxif.Text = " ";
            boxif.ForeColor = System.Drawing.Color.Black;
        }

        private void removevbucks_text(object sender, EventArgs e)
        {
            vbucksinfo.Text = " ";
            vbucksinfo.ForeColor = System.Drawing.Color.Black;
        }

        static void IntProblem()
        {
            MessageBox.Show("Enter the VBucks info in number format",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MainFortniteSubRemove()
        {
            string name = "fortnite";
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(path);
            FileInfo[] filesindir = hdDirectoryInWhichToSearch.GetFiles(name + "*.*");

            foreach (FileInfo foundFile in filesindir)
            {
                string fullName = foundFile.DirectoryName;
                if (Directory.Exists(fullName))
                {
                    Directory.Delete(fullName, true);
                }

            }
            //deletes the file given by the person            
        }
    }
}