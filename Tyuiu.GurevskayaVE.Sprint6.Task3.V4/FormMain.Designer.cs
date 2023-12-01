
namespace Tyuiu.GurevskayaVE.Sprint6.Task3.V4
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
            this.groupBoxUsl_GVE = new System.Windows.Forms.GroupBox();
            this.dataGridViewUsl_GVE = new System.Windows.Forms.DataGridView();
            this.labelUsl_GVE = new System.Windows.Forms.Label();
            this.buttonInfo_GVE = new System.Windows.Forms.Button();
            this.buttonDone_GVE = new System.Windows.Forms.Button();
            this.groupBoxRes_GVE = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_GVE = new System.Windows.Forms.DataGridView();
            this.groupBoxUsl_GVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsl_GVE)).BeginInit();
            this.groupBoxRes_GVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_GVE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUsl_GVE
            // 
            this.groupBoxUsl_GVE.Controls.Add(this.dataGridViewUsl_GVE);
            this.groupBoxUsl_GVE.Controls.Add(this.labelUsl_GVE);
            this.groupBoxUsl_GVE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUsl_GVE.Name = "groupBoxUsl_GVE";
            this.groupBoxUsl_GVE.Size = new System.Drawing.Size(622, 426);
            this.groupBoxUsl_GVE.TabIndex = 0;
            this.groupBoxUsl_GVE.TabStop = false;
            this.groupBoxUsl_GVE.Text = "Условие";
            // 
            // dataGridViewUsl_GVE
            // 
            this.dataGridViewUsl_GVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsl_GVE.Location = new System.Drawing.Point(359, 21);
            this.dataGridViewUsl_GVE.Name = "dataGridViewUsl_GVE";
            this.dataGridViewUsl_GVE.ReadOnly = true;
            this.dataGridViewUsl_GVE.RowHeadersWidth = 51;
            this.dataGridViewUsl_GVE.RowTemplate.Height = 24;
            this.dataGridViewUsl_GVE.Size = new System.Drawing.Size(257, 399);
            this.dataGridViewUsl_GVE.TabIndex = 1;
            // 
            // labelUsl_GVE
            // 
            this.labelUsl_GVE.AutoSize = true;
            this.labelUsl_GVE.Location = new System.Drawing.Point(7, 38);
            this.labelUsl_GVE.Name = "labelUsl_GVE";
            this.labelUsl_GVE.Size = new System.Drawing.Size(346, 119);
            this.labelUsl_GVE.TabIndex = 0;
            this.labelUsl_GVE.Text = "Дана матрица 5 на 5\r\n-14  -7  18  12 -20\r\n  -2 -15 -19 -19  -3\r\n -18  -5 -10  14 " +
    "-17\r\n  -1   2 -10   0  11\r\n   6 -18   0  19  16\r\nЗаменить четные значения во вто" +
    "рой строке на 0.";
            // 
            // buttonInfo_GVE
            // 
            this.buttonInfo_GVE.Location = new System.Drawing.Point(640, 397);
            this.buttonInfo_GVE.Name = "buttonInfo_GVE";
            this.buttonInfo_GVE.Size = new System.Drawing.Size(46, 41);
            this.buttonInfo_GVE.TabIndex = 1;
            this.buttonInfo_GVE.Text = "?";
            this.buttonInfo_GVE.UseVisualStyleBackColor = true;
            this.buttonInfo_GVE.Click += new System.EventHandler(this.buttonInfo_GVE_Click);
            // 
            // buttonDone_GVE
            // 
            this.buttonDone_GVE.Location = new System.Drawing.Point(693, 397);
            this.buttonDone_GVE.Name = "buttonDone_GVE";
            this.buttonDone_GVE.Size = new System.Drawing.Size(223, 40);
            this.buttonDone_GVE.TabIndex = 2;
            this.buttonDone_GVE.Text = "Выполнить";
            this.buttonDone_GVE.UseVisualStyleBackColor = true;
            this.buttonDone_GVE.Click += new System.EventHandler(this.buttonDone_GVE_Click);
            // 
            // groupBoxRes_GVE
            // 
            this.groupBoxRes_GVE.Controls.Add(this.dataGridViewRes_GVE);
            this.groupBoxRes_GVE.Location = new System.Drawing.Point(640, 13);
            this.groupBoxRes_GVE.Name = "groupBoxRes_GVE";
            this.groupBoxRes_GVE.Size = new System.Drawing.Size(276, 378);
            this.groupBoxRes_GVE.TabIndex = 3;
            this.groupBoxRes_GVE.TabStop = false;
            this.groupBoxRes_GVE.Text = "Вывод данных";
            // 
            // dataGridViewRes_GVE
            // 
            this.dataGridViewRes_GVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_GVE.Location = new System.Drawing.Point(7, 37);
            this.dataGridViewRes_GVE.Name = "dataGridViewRes_GVE";
            this.dataGridViewRes_GVE.RowHeadersWidth = 51;
            this.dataGridViewRes_GVE.RowTemplate.Height = 24;
            this.dataGridViewRes_GVE.Size = new System.Drawing.Size(263, 335);
            this.dataGridViewRes_GVE.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.groupBoxRes_GVE);
            this.Controls.Add(this.buttonDone_GVE);
            this.Controls.Add(this.buttonInfo_GVE);
            this.Controls.Add(this.groupBoxUsl_GVE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 4  | Гурьевская В.Е.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUsl_GVE.ResumeLayout(false);
            this.groupBoxUsl_GVE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsl_GVE)).EndInit();
            this.groupBoxRes_GVE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_GVE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUsl_GVE;
        private System.Windows.Forms.DataGridView dataGridViewUsl_GVE;
        private System.Windows.Forms.Label labelUsl_GVE;
        private System.Windows.Forms.Button buttonInfo_GVE;
        private System.Windows.Forms.Button buttonDone_GVE;
        private System.Windows.Forms.GroupBox groupBoxRes_GVE;
        private System.Windows.Forms.DataGridView dataGridViewRes_GVE;
    }
}

