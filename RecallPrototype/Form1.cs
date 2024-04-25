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
using JDP;
namespace RecallPrototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            //Get File
            OpenFileDialog fileDialog = new OpenFileDialog();
            //Setup File Filter
            //TODO: CHANGE FILE TYPE TO VIDEO ONLY
            fileDialog.Filter = "All Files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.Multiselect = false;

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = Path.GetFullPath(fileDialog.FileName);
                textBox2.Text = Path.GetFileName(fileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Please Select file want convert");
            }
            
       
        }


        private void selectFolderLocation(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            textBox3.Text = dialog.SelectedPath.ToString();
        }


        private void convertButton_Click(object sender, EventArgs e)
        {
            flvToMP3(textBox1.Text);
        }

        static void flvToMP3(string FLVfilePath)
        {
            FLVFile test = new FLVFile(FLVfilePath);
            test.ExtractStreams(true, false, false, null);
            MessageBox.Show("it shouldddddddddddd");
        }
    }
}
