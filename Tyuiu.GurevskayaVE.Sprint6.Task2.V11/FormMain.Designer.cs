
namespace Tyuiu.GurevskayaVE.Sprint6.Task2.V11
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
            this.groupBoxUsl_GVE = new System.Windows.Forms.GroupBox();
            this.labelUsl_GVE = new System.Windows.Forms.Label();
            this.groupBoxInPut_GVE = new System.Windows.Forms.GroupBox();
            this.textBoxVarA_GVE = new System.Windows.Forms.TextBox();
            this.textBoxVarB_GVE = new System.Windows.Forms.TextBox();
            this.labelVarB_GVE = new System.Windows.Forms.Label();
            this.labelVarA_GVE = new System.Windows.Forms.Label();
            this.buttonInfo_GVE = new System.Windows.Forms.Button();
            this.buttonDone_GVE = new System.Windows.Forms.Button();
            this.groupBoxOutPut_GVE = new System.Windows.Forms.GroupBox();
            this.chartRes_GVE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataGridViewRes_GVE = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRes_GVE = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxUsl_GVE.SuspendLayout();
            this.groupBoxInPut_GVE.SuspendLayout();
            this.groupBoxOutPut_GVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_GVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRes_GVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUsl_GVE
            // 
            this.groupBoxUsl_GVE.Controls.Add(this.pictureBox1);
            this.groupBoxUsl_GVE.Controls.Add(this.labelUsl_GVE);
            this.groupBoxUsl_GVE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUsl_GVE.Name = "groupBoxUsl_GVE";
            this.groupBoxUsl_GVE.Size = new System.Drawing.Size(473, 268);
            this.groupBoxUsl_GVE.TabIndex = 0;
            this.groupBoxUsl_GVE.TabStop = false;
            this.groupBoxUsl_GVE.Text = "Условие";
            // 
            // labelUsl_GVE
            // 
            this.labelUsl_GVE.AutoSize = true;
            this.labelUsl_GVE.Location = new System.Drawing.Point(7, 31);
            this.labelUsl_GVE.Name = "labelUsl_GVE";
            this.labelUsl_GVE.Size = new System.Drawing.Size(435, 34);
            this.labelUsl_GVE.TabIndex = 0;
            this.labelUsl_GVE.Text = "Протабулировать функцию cos(x) на заданном диапазоне.\r\nРезультат вывести в DataGr" +
    "idView и построить график функции.";
            // 
            // groupBoxInPut_GVE
            // 
            this.groupBoxInPut_GVE.Controls.Add(this.textBoxVarA_GVE);
            this.groupBoxInPut_GVE.Controls.Add(this.textBoxVarB_GVE);
            this.groupBoxInPut_GVE.Controls.Add(this.labelVarB_GVE);
            this.groupBoxInPut_GVE.Controls.Add(this.labelVarA_GVE);
            this.groupBoxInPut_GVE.Location = new System.Drawing.Point(12, 298);
            this.groupBoxInPut_GVE.Name = "groupBoxInPut_GVE";
            this.groupBoxInPut_GVE.Size = new System.Drawing.Size(256, 97);
            this.groupBoxInPut_GVE.TabIndex = 1;
            this.groupBoxInPut_GVE.TabStop = false;
            this.groupBoxInPut_GVE.Text = "Ввод данных";
            // 
            // textBoxVarA_GVE
            // 
            this.textBoxVarA_GVE.Location = new System.Drawing.Point(13, 52);
            this.textBoxVarA_GVE.Name = "textBoxVarA_GVE";
            this.textBoxVarA_GVE.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarA_GVE.TabIndex = 2;
            this.textBoxVarA_GVE.Text = "-5";
            // 
            // textBoxVarB_GVE
            // 
            this.textBoxVarB_GVE.Location = new System.Drawing.Point(139, 52);
            this.textBoxVarB_GVE.Name = "textBoxVarB_GVE";
            this.textBoxVarB_GVE.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarB_GVE.TabIndex = 2;
            this.textBoxVarB_GVE.Text = "5";
            // 
            // labelVarB_GVE
            // 
            this.labelVarB_GVE.AutoSize = true;
            this.labelVarB_GVE.Location = new System.Drawing.Point(136, 22);
            this.labelVarB_GVE.Name = "labelVarB_GVE";
            this.labelVarB_GVE.Size = new System.Drawing.Size(89, 17);
            this.labelVarB_GVE.TabIndex = 1;
            this.labelVarB_GVE.Text = "Конец шага:";
            // 
            // labelVarA_GVE
            // 
            this.labelVarA_GVE.AutoSize = true;
            this.labelVarA_GVE.Location = new System.Drawing.Point(10, 22);
            this.labelVarA_GVE.Name = "labelVarA_GVE";
            this.labelVarA_GVE.Size = new System.Drawing.Size(91, 17);
            this.labelVarA_GVE.TabIndex = 0;
            this.labelVarA_GVE.Text = "Старт шага: ";
            // 
            // buttonInfo_GVE
            // 
            this.buttonInfo_GVE.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonInfo_GVE.Location = new System.Drawing.Point(274, 312);
            this.buttonInfo_GVE.Name = "buttonInfo_GVE";
            this.buttonInfo_GVE.Size = new System.Drawing.Size(87, 82);
            this.buttonInfo_GVE.TabIndex = 2;
            this.buttonInfo_GVE.Text = "Справка";
            this.buttonInfo_GVE.UseVisualStyleBackColor = false;
            this.buttonInfo_GVE.Click += new System.EventHandler(this.buttonInfo_GVE_Click);
            // 
            // buttonDone_GVE
            // 
            this.buttonDone_GVE.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonDone_GVE.Location = new System.Drawing.Point(367, 312);
            this.buttonDone_GVE.Name = "buttonDone_GVE";
            this.buttonDone_GVE.Size = new System.Drawing.Size(118, 81);
            this.buttonDone_GVE.TabIndex = 3;
            this.buttonDone_GVE.Text = "Выполнить";
            this.buttonDone_GVE.UseVisualStyleBackColor = false;
            this.buttonDone_GVE.Click += new System.EventHandler(this.buttonDone_GVE_Click);
            this.buttonDone_GVE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_GVE_MouseDown);
            this.buttonDone_GVE.MouseEnter += new System.EventHandler(this.buttonDone_GVE_MouseEnter);
            this.buttonDone_GVE.MouseLeave += new System.EventHandler(this.buttonDone_GVE_MouseLeave);
            // 
            // groupBoxOutPut_GVE
            // 
            this.groupBoxOutPut_GVE.Controls.Add(this.chartRes_GVE);
            this.groupBoxOutPut_GVE.Controls.Add(this.DataGridViewRes_GVE);
            this.groupBoxOutPut_GVE.Controls.Add(this.labelRes_GVE);
            this.groupBoxOutPut_GVE.Location = new System.Drawing.Point(502, 12);
            this.groupBoxOutPut_GVE.Name = "groupBoxOutPut_GVE";
            this.groupBoxOutPut_GVE.Size = new System.Drawing.Size(711, 381);
            this.groupBoxOutPut_GVE.TabIndex = 4;
            this.groupBoxOutPut_GVE.TabStop = false;
            this.groupBoxOutPut_GVE.Text = "Вывод данных";
            // 
            // chartRes_GVE
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRes_GVE.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRes_GVE.Legends.Add(legend2);
            this.chartRes_GVE.Location = new System.Drawing.Point(181, 57);
            this.chartRes_GVE.Name = "chartRes_GVE";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartRes_GVE.Series.Add(series2);
            this.chartRes_GVE.Size = new System.Drawing.Size(524, 303);
            this.chartRes_GVE.TabIndex = 2;
            this.chartRes_GVE.Text = "chart1";
            // 
            // DataGridViewRes_GVE
            // 
            this.DataGridViewRes_GVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRes_GVE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.f});
            this.DataGridViewRes_GVE.Location = new System.Drawing.Point(31, 57);
            this.DataGridViewRes_GVE.Name = "DataGridViewRes_GVE";
            this.DataGridViewRes_GVE.RowHeadersVisible = false;
            this.DataGridViewRes_GVE.RowHeadersWidth = 51;
            this.DataGridViewRes_GVE.RowTemplate.Height = 24;
            this.DataGridViewRes_GVE.Size = new System.Drawing.Size(144, 303);
            this.DataGridViewRes_GVE.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 35;
            // 
            // f
            // 
            this.f.HeaderText = "F(X)";
            this.f.MinimumWidth = 6;
            this.f.Name = "f";
            this.f.Width = 50;
            // 
            // labelRes_GVE
            // 
            this.labelRes_GVE.AutoSize = true;
            this.labelRes_GVE.Location = new System.Drawing.Point(19, 22);
            this.labelRes_GVE.Name = "labelRes_GVE";
            this.labelRes_GVE.Size = new System.Drawing.Size(80, 17);
            this.labelRes_GVE.TabIndex = 0;
            this.labelRes_GVE.Text = "Результат:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.GurevskayaVE.Sprint6.Task2.V11.Properties.Resources.mVFvdzCOhMA;
            this.pictureBox1.Location = new System.Drawing.Point(13, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 58);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 410);
            this.Controls.Add(this.groupBoxOutPut_GVE);
            this.Controls.Add(this.buttonDone_GVE);
            this.Controls.Add(this.buttonInfo_GVE);
            this.Controls.Add(this.groupBoxInPut_GVE);
            this.Controls.Add(this.groupBoxUsl_GVE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 11 | Гурьевская В.Е.";
            this.groupBoxUsl_GVE.ResumeLayout(false);
            this.groupBoxUsl_GVE.PerformLayout();
            this.groupBoxInPut_GVE.ResumeLayout(false);
            this.groupBoxInPut_GVE.PerformLayout();
            this.groupBoxOutPut_GVE.ResumeLayout(false);
            this.groupBoxOutPut_GVE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_GVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRes_GVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUsl_GVE;
        private System.Windows.Forms.Label labelUsl_GVE;
        private System.Windows.Forms.GroupBox groupBoxInPut_GVE;
        private System.Windows.Forms.TextBox textBoxVarB_GVE;
        private System.Windows.Forms.Label labelVarB_GVE;
        private System.Windows.Forms.Label labelVarA_GVE;
        private System.Windows.Forms.TextBox textBoxVarA_GVE;
        private System.Windows.Forms.Button buttonInfo_GVE;
        private System.Windows.Forms.Button buttonDone_GVE;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GVE;
        private System.Windows.Forms.Label labelRes_GVE;
        private System.Windows.Forms.DataGridView DataGridViewRes_GVE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_GVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn f;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

