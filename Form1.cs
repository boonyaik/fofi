using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xtractor
{
    public partial class Form1 : Form
    {

        private bool startedBefore = false;
        public Form1()
        {
            InitializeComponent();
        }
               
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            try
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;

            }
            catch (System.ArgumentException err) {
                Console.WriteLine(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            try
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;

            }
            catch (System.ArgumentException err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                startedBefore = true;
                string[] allfiles = Directory.GetFiles(textBox1.Text, "*.*", SearchOption.AllDirectories);
                progressBar1.Minimum = 0;
                progressBar1.Value = 0;
                progressBar1.Maximum = allfiles.Length;
                Logger.reset_log("FoFi-Filenames.txt");

                foreach (var file in allfiles)
                {
                    progressBar1.Value++;
                    FileInfo info = new FileInfo(file);
                    Console.WriteLine(info.ToString());                                                   
                    string fname = FoFiWorker.perform_FoFicopy(textBox1.Text, info.ToString(), textBox2.Text, moveCheckBox.Checked, overwriteCheckBox.Checked, augmentCheckBox.Checked);
                    Logger.log("FoFi-Filenames.txt", fname);
                }

                MessageBox.Show("Process Completed, " + progressBar1.Maximum + " files found", "FiFo-Status", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (showReportCheckBox.Checked) {
                    try
                    {
                        Process.Start("notepad.exe", "FoFi-Filenames.txt");
                    }
                    catch (System.Exception eer) {
                        MessageBox.Show("Unable to show report, open FoFi-Filenames.txt manually", "FiFo-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }


            }
            catch (System.IO.DirectoryNotFoundException ) {

                MessageBox.Show("Path not found, please set the source and destination", "FiFo-Status",MessageBoxButtons.OK,MessageBoxIcon.Error);
                progressBar1.Minimum = 0;
                progressBar1.Value = 0;
            }

        }

        private void augmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (augmentCheckBox.Checked == false)
            {
                overwriteCheckBox.Enabled = true;
                overwriteCheckBox.Checked = true;
            }
            else {
                overwriteCheckBox.Enabled = false;
                overwriteCheckBox.Checked = false;
            }           
        }

        private void overwriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (overwriteCheckBox.Checked == false) {
                MessageBox.Show("Subsequence files with same name will be ignored", "FiFo Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showReportCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showReportCheckBox.Checked == true && startedBefore == true)
            {
                try
                {
                    if (File.Exists("FoFi-Filenames.txt"))
                        Process.Start("notepad.exe", "FoFi-Filenames.txt");
                }
                catch (System.Exception eer)
                {
                    MessageBox.Show("Unable to show report, open FoFi-Filenames.txt manually", "FiFo-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
