using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GurevskayaVE.Sprint6.Task3.V4.Lib;

namespace Tyuiu.GurevskayaVE.Sprint6.Task3.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { {  -14,-7,18,12,-20 },
                                         { -2,-15,-19,-19,-3 },
                                         { -18,-5,-10,14,-17 },
                                         { -1,2,-10,0,11 },
                                         { 6,-18,0,19,16 } };
        private void buttonDone_GVE_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(matrix);
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewRes_GVE.ColumnCount = columns;
            dataGridViewRes_GVE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewRes_GVE.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRes_GVE.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
            
        }

        private void buttonInfo_GVE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студент группы ПКТб-23-2 Гурьевская В.Е.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewUsl_GVE.ColumnCount = columns;
            dataGridViewUsl_GVE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewUsl_GVE.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewUsl_GVE.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
