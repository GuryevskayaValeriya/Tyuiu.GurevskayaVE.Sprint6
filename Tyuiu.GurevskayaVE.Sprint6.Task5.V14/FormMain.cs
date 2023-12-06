using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GurevskayaVE.Sprint6.Task5.V14.Lib;

namespace Tyuiu.GurevskayaVE.Sprint6.Task5.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutFileTask5V14.txt";

        private void buttonDone_GVE_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewInPut_GVE.ColumnCount = 2;
                dataGridViewInPut_GVE.Columns[0].Width = 20;
                dataGridViewInPut_GVE.Columns[1].Width = 50;

                this.chartInPut_GVE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartInPut_GVE.ChartAreas[0].AxisY.Title = "Ось Y";

                chartInPut_GVE.Series[0].Points.Clear();

                double[] numsMass = new double[ds.len];

                numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewInPut_GVE.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartInPut_GVE.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpen_GVE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_GVE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-2 Гурьевская Валерия Евгеньевна", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
