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
using Tyuiu.GurevskayaVE.Sprint6.Task7.V30.Lib;

namespace Tyuiu.GurevskayaVE.Sprint6.Task7.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialog_GVE.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_GVE.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static string openFilePath;
        static int rows;
        static int colums;
        DataService ds = new DataService();

        //метод чтения данных из файла
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            //разделение на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //колво строк и столбцов
            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            //выделение массива данных
            int[,] arrayValues = new int[rows, colums];

            //заполнение массива данными
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonInfo_GVE_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void buttonOpen_GVE_Click(object sender, EventArgs e)
        {
            openFileDialog_GVE.ShowDialog();
            openFilePath = openFileDialog_GVE.FileName;

            //выделение массива данных
            int[,] arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_GVE.ColumnCount = colums;
            dataGridViewIn_GVE.RowCount = rows;
            dataGridViewOut_GVE.ColumnCount = colums;
            dataGridViewOut_GVE.RowCount = rows;

            //ширина столбцов
            for (int i = 0; i < colums; i++)
            {
                dataGridViewIn_GVE.Columns[i].Width = 25;
                dataGridViewIn_GVE.Columns[i].Width = 25;
            }

            //добавление данных
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewIn_GVE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone_GVE.Enabled = true;
        }

        private void buttonDone_GVE_Click(object sender, EventArgs e)
        {
            //выделение массива данных
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            //добавление данных
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    
                    dataGridViewOut_GVE.Rows[r].Cells[c].Value = arrayValues[r, c];
                    
                }
            }
            buttonSave_GVE.Enabled = true;
        }

        private void buttonSave_GVE_Click(object sender, EventArgs e)
        {
            saveFileDialog_GVE.FileName = "OutPutFileTask7.csv";
            saveFileDialog_GVE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_GVE.ShowDialog();

            string path = saveFileDialog_GVE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_GVE.RowCount;
            int columns = dataGridViewOut_GVE.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_GVE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_GVE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";

            }
        }

        private void buttonOpen_GVE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_GVE.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_GVE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_GVE.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_GVE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_GVE.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonInfo_GVE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_GVE.ToolTipTitle = "Справка";
        }
    }
}
