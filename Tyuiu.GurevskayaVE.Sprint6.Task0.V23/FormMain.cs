using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GurevskayaVE.Sprint6.Task0.V23.Lib;

namespace Tyuiu.GurevskayaVE.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_GVE_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRes_GVE.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_GVE.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void textBoxVarX_GVE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }


        private void buttonInfo_GVE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студент группы ПКТб-23-2 Гурьевская В.Е.", "Сообщение");
        }

        private void textBoxVarX_GVE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
