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
using Tyuiu.GurevskayaVE.Sprint6.Task6.V21.Lib;

namespace Tyuiu.GurevskayaVE.Sprint6.Task6.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService(); 
        string openFilePath_GVE;
        private void buttonOpenFile_GVE_Click(object sender, EventArgs e)
        {
            openFileDialog_GVE.ShowDialog();
            openFilePath_GVE = openFileDialog_GVE.FileName;
            textBoxIn_GVE.Text = File.ReadAllText(openFilePath_GVE);
            groupBoxIn_GVE.Text = groupBoxIn_GVE.Text + " " + openFileDialog_GVE.FileName;
            buttonDone_GVE.Enabled = true;
        }

        private void buttonDone_GVE_Click(object sender, EventArgs e)
        {
            string str = "g";
            textBoxOut_GVE.Text = ds.CollectTextFromFile(str, openFilePath_GVE);

        }

        private void buttonInfo_GVE_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
    }
}
