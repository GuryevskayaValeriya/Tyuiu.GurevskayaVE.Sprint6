
namespace Tyuiu.GurevskayaVE.Sprint6.Task4.V20
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxRes_GVE = new System.Windows.Forms.GroupBox();
            this.textBoxRes_GVE = new System.Windows.Forms.TextBox();
            this.groupBoxUsl_GVE = new System.Windows.Forms.GroupBox();
            this.textBoxUsl_GVE = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_GVE = new System.Windows.Forms.GroupBox();
            this.textBoxVarB_GVE = new System.Windows.Forms.TextBox();
            this.textBoxVarA_GVE = new System.Windows.Forms.TextBox();
            this.labelVarB_GVE = new System.Windows.Forms.Label();
            this.labelVarA_GVE = new System.Windows.Forms.Label();
            this.buttonDone_GVE = new System.Windows.Forms.Button();
            this.buttonSave_GVE = new System.Windows.Forms.Button();
            this.buttonInfo_GVE = new System.Windows.Forms.Button();
            this.chartRes_GVE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelVerh_GVE = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelCentr_GVE = new System.Windows.Forms.Panel();
            this.groupBoxRes_GVE.SuspendLayout();
            this.groupBoxUsl_GVE.SuspendLayout();
            this.groupBoxInPut_GVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_GVE)).BeginInit();
            this.panelVerh_GVE.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelCentr_GVE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRes_GVE
            // 
            this.groupBoxRes_GVE.Controls.Add(this.textBoxRes_GVE);
            this.groupBoxRes_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRes_GVE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRes_GVE.Name = "groupBoxRes_GVE";
            this.groupBoxRes_GVE.Size = new System.Drawing.Size(365, 484);
            this.groupBoxRes_GVE.TabIndex = 0;
            this.groupBoxRes_GVE.TabStop = false;
            this.groupBoxRes_GVE.Text = "Вывод: ";
            // 
            // textBoxRes_GVE
            // 
            this.textBoxRes_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRes_GVE.Location = new System.Drawing.Point(3, 18);
            this.textBoxRes_GVE.Multiline = true;
            this.textBoxRes_GVE.Name = "textBoxRes_GVE";
            this.textBoxRes_GVE.ReadOnly = true;
            this.textBoxRes_GVE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_GVE.Size = new System.Drawing.Size(359, 463);
            this.textBoxRes_GVE.TabIndex = 0;
            // 
            // groupBoxUsl_GVE
            // 
            this.groupBoxUsl_GVE.Controls.Add(this.textBoxUsl_GVE);
            this.groupBoxUsl_GVE.Location = new System.Drawing.Point(6, 3);
            this.groupBoxUsl_GVE.Name = "groupBoxUsl_GVE";
            this.groupBoxUsl_GVE.Size = new System.Drawing.Size(498, 100);
            this.groupBoxUsl_GVE.TabIndex = 1;
            this.groupBoxUsl_GVE.TabStop = false;
            this.groupBoxUsl_GVE.Text = "Условие:";
            // 
            // textBoxUsl_GVE
            // 
            this.textBoxUsl_GVE.Location = new System.Drawing.Point(7, 22);
            this.textBoxUsl_GVE.Multiline = true;
            this.textBoxUsl_GVE.Name = "textBoxUsl_GVE";
            this.textBoxUsl_GVE.ReadOnly = true;
            this.textBoxUsl_GVE.Size = new System.Drawing.Size(485, 72);
            this.textBoxUsl_GVE.TabIndex = 0;
            this.textBoxUsl_GVE.Text = "Протабулировать функцию sin(x) на заданном диапазоне от -5 до 5.\r\nРезультат вывес" +
    "ти в textBox. Построить график функции и сохранить в файл OutPutFileTask4V20.txt" +
    " по нажатию кнопки сохранить.";
            // 
            // groupBoxInPut_GVE
            // 
            this.groupBoxInPut_GVE.Controls.Add(this.textBoxVarB_GVE);
            this.groupBoxInPut_GVE.Controls.Add(this.textBoxVarA_GVE);
            this.groupBoxInPut_GVE.Controls.Add(this.labelVarB_GVE);
            this.groupBoxInPut_GVE.Controls.Add(this.labelVarA_GVE);
            this.groupBoxInPut_GVE.Location = new System.Drawing.Point(510, 3);
            this.groupBoxInPut_GVE.Name = "groupBoxInPut_GVE";
            this.groupBoxInPut_GVE.Size = new System.Drawing.Size(283, 100);
            this.groupBoxInPut_GVE.TabIndex = 2;
            this.groupBoxInPut_GVE.TabStop = false;
            this.groupBoxInPut_GVE.Text = "Ввод данных:";
            // 
            // textBoxVarB_GVE
            // 
            this.textBoxVarB_GVE.Location = new System.Drawing.Point(167, 61);
            this.textBoxVarB_GVE.Name = "textBoxVarB_GVE";
            this.textBoxVarB_GVE.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarB_GVE.TabIndex = 2;
            this.textBoxVarB_GVE.Text = "5";
            // 
            // textBoxVarA_GVE
            // 
            this.textBoxVarA_GVE.Location = new System.Drawing.Point(10, 61);
            this.textBoxVarA_GVE.Name = "textBoxVarA_GVE";
            this.textBoxVarA_GVE.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarA_GVE.TabIndex = 1;
            this.textBoxVarA_GVE.Text = "-5";
            // 
            // labelVarB_GVE
            // 
            this.labelVarB_GVE.AutoSize = true;
            this.labelVarB_GVE.Location = new System.Drawing.Point(164, 41);
            this.labelVarB_GVE.Name = "labelVarB_GVE";
            this.labelVarB_GVE.Size = new System.Drawing.Size(89, 17);
            this.labelVarB_GVE.TabIndex = 0;
            this.labelVarB_GVE.Text = "Конец шага:";
            // 
            // labelVarA_GVE
            // 
            this.labelVarA_GVE.AutoSize = true;
            this.labelVarA_GVE.Location = new System.Drawing.Point(7, 41);
            this.labelVarA_GVE.Name = "labelVarA_GVE";
            this.labelVarA_GVE.Size = new System.Drawing.Size(87, 17);
            this.labelVarA_GVE.TabIndex = 0;
            this.labelVarA_GVE.Text = "Старт шага:";
            // 
            // buttonDone_GVE
            // 
            this.buttonDone_GVE.BackColor = System.Drawing.Color.Plum;
            this.buttonDone_GVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_GVE.Location = new System.Drawing.Point(799, 13);
            this.buttonDone_GVE.Name = "buttonDone_GVE";
            this.buttonDone_GVE.Size = new System.Drawing.Size(108, 79);
            this.buttonDone_GVE.TabIndex = 3;
            this.buttonDone_GVE.Text = "Выполнить";
            this.buttonDone_GVE.UseVisualStyleBackColor = false;
            this.buttonDone_GVE.Click += new System.EventHandler(this.buttonDone_GVE_Click);
            // 
            // buttonSave_GVE
            // 
            this.buttonSave_GVE.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSave_GVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_GVE.Location = new System.Drawing.Point(913, 13);
            this.buttonSave_GVE.Name = "buttonSave_GVE";
            this.buttonSave_GVE.Size = new System.Drawing.Size(108, 79);
            this.buttonSave_GVE.TabIndex = 4;
            this.buttonSave_GVE.Text = "Сохранить";
            this.buttonSave_GVE.UseVisualStyleBackColor = false;
            this.buttonSave_GVE.Click += new System.EventHandler(this.buttonSave_GVE_Click);
            // 
            // buttonInfo_GVE
            // 
            this.buttonInfo_GVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_GVE.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonInfo_GVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_GVE.Location = new System.Drawing.Point(1028, 12);
            this.buttonInfo_GVE.Name = "buttonInfo_GVE";
            this.buttonInfo_GVE.Size = new System.Drawing.Size(97, 79);
            this.buttonInfo_GVE.TabIndex = 5;
            this.buttonInfo_GVE.Text = "Справка";
            this.buttonInfo_GVE.UseVisualStyleBackColor = false;
            this.buttonInfo_GVE.Click += new System.EventHandler(this.buttonInfo_GVE_Click);
            // 
            // chartRes_GVE
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRes_GVE.ChartAreas.Add(chartArea1);
            this.chartRes_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartRes_GVE.Legends.Add(legend1);
            this.chartRes_GVE.Location = new System.Drawing.Point(0, 0);
            this.chartRes_GVE.Name = "chartRes_GVE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRes_GVE.Series.Add(series1);
            this.chartRes_GVE.Size = new System.Drawing.Size(762, 484);
            this.chartRes_GVE.TabIndex = 6;
            this.chartRes_GVE.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции sin(x)";
            this.chartRes_GVE.Titles.Add(title1);
            // 
            // panelVerh_GVE
            // 
            this.panelVerh_GVE.Controls.Add(this.groupBoxUsl_GVE);
            this.panelVerh_GVE.Controls.Add(this.groupBoxInPut_GVE);
            this.panelVerh_GVE.Controls.Add(this.buttonInfo_GVE);
            this.panelVerh_GVE.Controls.Add(this.buttonDone_GVE);
            this.panelVerh_GVE.Controls.Add(this.buttonSave_GVE);
            this.panelVerh_GVE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVerh_GVE.Location = new System.Drawing.Point(0, 0);
            this.panelVerh_GVE.Name = "panelVerh_GVE";
            this.panelVerh_GVE.Size = new System.Drawing.Size(1137, 118);
            this.panelVerh_GVE.TabIndex = 7;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxRes_GVE);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 118);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(365, 484);
            this.panelLeft.TabIndex = 8;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(365, 118);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 484);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // panelCentr_GVE
            // 
            this.panelCentr_GVE.BackColor = System.Drawing.Color.Transparent;
            this.panelCentr_GVE.Controls.Add(this.chartRes_GVE);
            this.panelCentr_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentr_GVE.Location = new System.Drawing.Point(375, 118);
            this.panelCentr_GVE.Name = "panelCentr_GVE";
            this.panelCentr_GVE.Size = new System.Drawing.Size(762, 484);
            this.panelCentr_GVE.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 602);
            this.Controls.Add(this.panelCentr_GVE);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelVerh_GVE);
            this.MinimumSize = new System.Drawing.Size(1155, 649);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4  | Вариант  20 | Гурьевская В.Е.";
            this.groupBoxRes_GVE.ResumeLayout(false);
            this.groupBoxRes_GVE.PerformLayout();
            this.groupBoxUsl_GVE.ResumeLayout(false);
            this.groupBoxUsl_GVE.PerformLayout();
            this.groupBoxInPut_GVE.ResumeLayout(false);
            this.groupBoxInPut_GVE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_GVE)).EndInit();
            this.panelVerh_GVE.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelCentr_GVE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRes_GVE;
        private System.Windows.Forms.TextBox textBoxRes_GVE;
        private System.Windows.Forms.GroupBox groupBoxUsl_GVE;
        private System.Windows.Forms.TextBox textBoxUsl_GVE;
        private System.Windows.Forms.GroupBox groupBoxInPut_GVE;
        private System.Windows.Forms.TextBox textBoxVarB_GVE;
        private System.Windows.Forms.TextBox textBoxVarA_GVE;
        private System.Windows.Forms.Label labelVarB_GVE;
        private System.Windows.Forms.Label labelVarA_GVE;
        private System.Windows.Forms.Button buttonDone_GVE;
        private System.Windows.Forms.Button buttonSave_GVE;
        private System.Windows.Forms.Button buttonInfo_GVE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_GVE;
        private System.Windows.Forms.Panel panelVerh_GVE;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelCentr_GVE;
    }
}

