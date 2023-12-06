
namespace Tyuiu.GurevskayaVE.Sprint6.Task5.V14
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_GVE = new System.Windows.Forms.Panel();
            this.panelLeft_GVE = new System.Windows.Forms.Panel();
            this.panelFill_GVE = new System.Windows.Forms.Panel();
            this.groupBoxUsl_GVE = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOpen_GVE = new System.Windows.Forms.Button();
            this.buttonInfo_GVE = new System.Windows.Forms.Button();
            this.buttonDone_GVE = new System.Windows.Forms.Button();
            this.groupBoxInPut_GVE = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_GVE = new System.Windows.Forms.DataGridView();
            this.chartInPut_GVE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_GVE.SuspendLayout();
            this.panelLeft_GVE.SuspendLayout();
            this.panelFill_GVE.SuspendLayout();
            this.groupBoxUsl_GVE.SuspendLayout();
            this.groupBoxInPut_GVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_GVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInPut_GVE)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_GVE
            // 
            this.panelTop_GVE.Controls.Add(this.buttonInfo_GVE);
            this.panelTop_GVE.Controls.Add(this.buttonDone_GVE);
            this.panelTop_GVE.Controls.Add(this.buttonOpen_GVE);
            this.panelTop_GVE.Controls.Add(this.groupBoxUsl_GVE);
            this.panelTop_GVE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_GVE.Location = new System.Drawing.Point(0, 0);
            this.panelTop_GVE.Name = "panelTop_GVE";
            this.panelTop_GVE.Size = new System.Drawing.Size(872, 116);
            this.panelTop_GVE.TabIndex = 0;
            // 
            // panelLeft_GVE
            // 
            this.panelLeft_GVE.Controls.Add(this.groupBoxInPut_GVE);
            this.panelLeft_GVE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_GVE.Location = new System.Drawing.Point(0, 116);
            this.panelLeft_GVE.Name = "panelLeft_GVE";
            this.panelLeft_GVE.Size = new System.Drawing.Size(201, 412);
            this.panelLeft_GVE.TabIndex = 1;
            // 
            // panelFill_GVE
            // 
            this.panelFill_GVE.Controls.Add(this.chartInPut_GVE);
            this.panelFill_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_GVE.Location = new System.Drawing.Point(201, 116);
            this.panelFill_GVE.Name = "panelFill_GVE";
            this.panelFill_GVE.Size = new System.Drawing.Size(671, 412);
            this.panelFill_GVE.TabIndex = 2;
            // 
            // groupBoxUsl_GVE
            // 
            this.groupBoxUsl_GVE.Controls.Add(this.textBox1);
            this.groupBoxUsl_GVE.Location = new System.Drawing.Point(4, 4);
            this.groupBoxUsl_GVE.Name = "groupBoxUsl_GVE";
            this.groupBoxUsl_GVE.Size = new System.Drawing.Size(473, 101);
            this.groupBoxUsl_GVE.TabIndex = 0;
            this.groupBoxUsl_GVE.TabStop = false;
            this.groupBoxUsl_GVE.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(458, 73);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5V14.txt. Вывести в datagridView числа, бо" +
    "льше или равные 10. Построить диаграмму по этим значениям.";
            // 
            // buttonOpen_GVE
            // 
            this.buttonOpen_GVE.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonOpen_GVE.Location = new System.Drawing.Point(615, 12);
            this.buttonOpen_GVE.Name = "buttonOpen_GVE";
            this.buttonOpen_GVE.Size = new System.Drawing.Size(113, 92);
            this.buttonOpen_GVE.TabIndex = 2;
            this.buttonOpen_GVE.Text = "Открыть файл";
            this.buttonOpen_GVE.UseVisualStyleBackColor = false;
            this.buttonOpen_GVE.Click += new System.EventHandler(this.buttonOpen_GVE_Click);
            // 
            // buttonInfo_GVE
            // 
            this.buttonInfo_GVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_GVE.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonInfo_GVE.Location = new System.Drawing.Point(747, 12);
            this.buttonInfo_GVE.Name = "buttonInfo_GVE";
            this.buttonInfo_GVE.Size = new System.Drawing.Size(113, 92);
            this.buttonInfo_GVE.TabIndex = 2;
            this.buttonInfo_GVE.Text = "Справка";
            this.buttonInfo_GVE.UseVisualStyleBackColor = false;
            this.buttonInfo_GVE.Click += new System.EventHandler(this.buttonInfo_GVE_Click);
            // 
            // buttonDone_GVE
            // 
            this.buttonDone_GVE.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonDone_GVE.Location = new System.Drawing.Point(496, 12);
            this.buttonDone_GVE.Name = "buttonDone_GVE";
            this.buttonDone_GVE.Size = new System.Drawing.Size(113, 92);
            this.buttonDone_GVE.TabIndex = 2;
            this.buttonDone_GVE.Text = "Выполнить";
            this.buttonDone_GVE.UseVisualStyleBackColor = false;
            this.buttonDone_GVE.Click += new System.EventHandler(this.buttonDone_GVE_Click);
            // 
            // groupBoxInPut_GVE
            // 
            this.groupBoxInPut_GVE.Controls.Add(this.dataGridViewInPut_GVE);
            this.groupBoxInPut_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_GVE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_GVE.Name = "groupBoxInPut_GVE";
            this.groupBoxInPut_GVE.Size = new System.Drawing.Size(201, 412);
            this.groupBoxInPut_GVE.TabIndex = 0;
            this.groupBoxInPut_GVE.TabStop = false;
            this.groupBoxInPut_GVE.Text = "Вывод данных";
            // 
            // dataGridViewInPut_GVE
            // 
            this.dataGridViewInPut_GVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_GVE.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInPut_GVE.Name = "dataGridViewInPut_GVE";
            this.dataGridViewInPut_GVE.RowHeadersWidth = 51;
            this.dataGridViewInPut_GVE.RowTemplate.Height = 24;
            this.dataGridViewInPut_GVE.Size = new System.Drawing.Size(195, 391);
            this.dataGridViewInPut_GVE.TabIndex = 0;
            // 
            // chartInPut_GVE
            // 
            chartArea2.Name = "ChartArea1";
            this.chartInPut_GVE.ChartAreas.Add(chartArea2);
            this.chartInPut_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartInPut_GVE.Legends.Add(legend2);
            this.chartInPut_GVE.Location = new System.Drawing.Point(0, 0);
            this.chartInPut_GVE.Name = "chartInPut_GVE";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartInPut_GVE.Series.Add(series2);
            this.chartInPut_GVE.Size = new System.Drawing.Size(671, 412);
            this.chartInPut_GVE.TabIndex = 0;
            this.chartInPut_GVE.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 528);
            this.Controls.Add(this.panelFill_GVE);
            this.Controls.Add(this.panelLeft_GVE);
            this.Controls.Add(this.panelTop_GVE);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Таск 5  | Вариант 14  | Гурьевская В.Е.";
            this.panelTop_GVE.ResumeLayout(false);
            this.panelLeft_GVE.ResumeLayout(false);
            this.panelFill_GVE.ResumeLayout(false);
            this.groupBoxUsl_GVE.ResumeLayout(false);
            this.groupBoxUsl_GVE.PerformLayout();
            this.groupBoxInPut_GVE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_GVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInPut_GVE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_GVE;
        private System.Windows.Forms.Button buttonInfo_GVE;
        private System.Windows.Forms.Button buttonDone_GVE;
        private System.Windows.Forms.Button buttonOpen_GVE;
        private System.Windows.Forms.GroupBox groupBoxUsl_GVE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelLeft_GVE;
        private System.Windows.Forms.GroupBox groupBoxInPut_GVE;
        private System.Windows.Forms.DataGridView dataGridViewInPut_GVE;
        private System.Windows.Forms.Panel panelFill_GVE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInPut_GVE;
    }
}

