
namespace Tyuiu.GurevskayaVE.Sprint6.Task1.V6
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
            this.buttonInfo_GVE = new System.Windows.Forms.Button();
            this.buttonDone_GVE = new System.Windows.Forms.Button();
            this.groupBoxUsl_GVE = new System.Windows.Forms.GroupBox();
            this.labelUsl_GVE = new System.Windows.Forms.Label();
            this.groupBoxInPut_GVE = new System.Windows.Forms.GroupBox();
            this.textBoxStart_GVE = new System.Windows.Forms.TextBox();
            this.textBoxFinish_GVE = new System.Windows.Forms.TextBox();
            this.labelFinish_GVE = new System.Windows.Forms.Label();
            this.labelStart_GVE = new System.Windows.Forms.Label();
            this.groupBoxRes_GVE = new System.Windows.Forms.GroupBox();
            this.labelRes_GVE = new System.Windows.Forms.Label();
            this.textBoxRes_GVE = new System.Windows.Forms.TextBox();
            this.groupBoxUsl_GVE.SuspendLayout();
            this.groupBoxInPut_GVE.SuspendLayout();
            this.groupBoxRes_GVE.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInfo_GVE
            // 
            this.buttonInfo_GVE.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_GVE.Location = new System.Drawing.Point(293, 370);
            this.buttonInfo_GVE.Name = "buttonInfo_GVE";
            this.buttonInfo_GVE.Size = new System.Drawing.Size(77, 68);
            this.buttonInfo_GVE.TabIndex = 0;
            this.buttonInfo_GVE.Text = "Справка";
            this.buttonInfo_GVE.UseVisualStyleBackColor = false;
            this.buttonInfo_GVE.Click += new System.EventHandler(this.buttonInfo_GVE_Click);
            // 
            // buttonDone_GVE
            // 
            this.buttonDone_GVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_GVE.Location = new System.Drawing.Point(376, 370);
            this.buttonDone_GVE.Name = "buttonDone_GVE";
            this.buttonDone_GVE.Size = new System.Drawing.Size(148, 68);
            this.buttonDone_GVE.TabIndex = 1;
            this.buttonDone_GVE.Text = "Выполнить";
            this.buttonDone_GVE.UseVisualStyleBackColor = false;
            this.buttonDone_GVE.Click += new System.EventHandler(this.buttonDone_GVE_Click);
            // 
            // groupBoxUsl_GVE
            // 
            this.groupBoxUsl_GVE.Controls.Add(this.labelUsl_GVE);
            this.groupBoxUsl_GVE.Location = new System.Drawing.Point(26, 28);
            this.groupBoxUsl_GVE.Name = "groupBoxUsl_GVE";
            this.groupBoxUsl_GVE.Size = new System.Drawing.Size(498, 324);
            this.groupBoxUsl_GVE.TabIndex = 2;
            this.groupBoxUsl_GVE.TabStop = false;
            this.groupBoxUsl_GVE.Text = "Условие";
            // 
            // labelUsl_GVE
            // 
            this.labelUsl_GVE.AutoSize = true;
            this.labelUsl_GVE.Location = new System.Drawing.Point(22, 31);
            this.labelUsl_GVE.Name = "labelUsl_GVE";
            this.labelUsl_GVE.Size = new System.Drawing.Size(393, 34);
            this.labelUsl_GVE.TabIndex = 0;
            this.labelUsl_GVE.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в таблиц" +
    "е.\r\n";
            // 
            // groupBoxInPut_GVE
            // 
            this.groupBoxInPut_GVE.Controls.Add(this.textBoxStart_GVE);
            this.groupBoxInPut_GVE.Controls.Add(this.textBoxFinish_GVE);
            this.groupBoxInPut_GVE.Controls.Add(this.labelFinish_GVE);
            this.groupBoxInPut_GVE.Controls.Add(this.labelStart_GVE);
            this.groupBoxInPut_GVE.Location = new System.Drawing.Point(26, 358);
            this.groupBoxInPut_GVE.Name = "groupBoxInPut_GVE";
            this.groupBoxInPut_GVE.Size = new System.Drawing.Size(261, 80);
            this.groupBoxInPut_GVE.TabIndex = 3;
            this.groupBoxInPut_GVE.TabStop = false;
            this.groupBoxInPut_GVE.Text = "Ввод данных";
            // 
            // textBoxStart_GVE
            // 
            this.textBoxStart_GVE.Location = new System.Drawing.Point(10, 42);
            this.textBoxStart_GVE.Name = "textBoxStart_GVE";
            this.textBoxStart_GVE.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_GVE.TabIndex = 2;
            this.textBoxStart_GVE.Text = "-5";
            // 
            // textBoxFinish_GVE
            // 
            this.textBoxFinish_GVE.Location = new System.Drawing.Point(139, 42);
            this.textBoxFinish_GVE.Name = "textBoxFinish_GVE";
            this.textBoxFinish_GVE.Size = new System.Drawing.Size(100, 22);
            this.textBoxFinish_GVE.TabIndex = 2;
            this.textBoxFinish_GVE.Text = "5";
            // 
            // labelFinish_GVE
            // 
            this.labelFinish_GVE.AutoSize = true;
            this.labelFinish_GVE.Location = new System.Drawing.Point(136, 22);
            this.labelFinish_GVE.Name = "labelFinish_GVE";
            this.labelFinish_GVE.Size = new System.Drawing.Size(89, 17);
            this.labelFinish_GVE.TabIndex = 1;
            this.labelFinish_GVE.Text = "Конец шага:";
            // 
            // labelStart_GVE
            // 
            this.labelStart_GVE.AutoSize = true;
            this.labelStart_GVE.Location = new System.Drawing.Point(7, 22);
            this.labelStart_GVE.Name = "labelStart_GVE";
            this.labelStart_GVE.Size = new System.Drawing.Size(87, 17);
            this.labelStart_GVE.TabIndex = 0;
            this.labelStart_GVE.Text = "Старт шага:";
            // 
            // groupBoxRes_GVE
            // 
            this.groupBoxRes_GVE.Controls.Add(this.labelRes_GVE);
            this.groupBoxRes_GVE.Controls.Add(this.textBoxRes_GVE);
            this.groupBoxRes_GVE.Location = new System.Drawing.Point(550, 29);
            this.groupBoxRes_GVE.Name = "groupBoxRes_GVE";
            this.groupBoxRes_GVE.Size = new System.Drawing.Size(217, 410);
            this.groupBoxRes_GVE.TabIndex = 4;
            this.groupBoxRes_GVE.TabStop = false;
            this.groupBoxRes_GVE.Text = "Вывод данных";
            // 
            // labelRes_GVE
            // 
            this.labelRes_GVE.AutoSize = true;
            this.labelRes_GVE.Location = new System.Drawing.Point(7, 22);
            this.labelRes_GVE.Name = "labelRes_GVE";
            this.labelRes_GVE.Size = new System.Drawing.Size(80, 17);
            this.labelRes_GVE.TabIndex = 1;
            this.labelRes_GVE.Text = "Результат:";
            // 
            // textBoxRes_GVE
            // 
            this.textBoxRes_GVE.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRes_GVE.Location = new System.Drawing.Point(6, 45);
            this.textBoxRes_GVE.Multiline = true;
            this.textBoxRes_GVE.Name = "textBoxRes_GVE";
            this.textBoxRes_GVE.ReadOnly = true;
            this.textBoxRes_GVE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_GVE.Size = new System.Drawing.Size(205, 359);
            this.textBoxRes_GVE.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxRes_GVE);
            this.Controls.Add(this.groupBoxInPut_GVE);
            this.Controls.Add(this.groupBoxUsl_GVE);
            this.Controls.Add(this.buttonDone_GVE);
            this.Controls.Add(this.buttonInfo_GVE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 6 | Гурьевская В.Е.";
            this.groupBoxUsl_GVE.ResumeLayout(false);
            this.groupBoxUsl_GVE.PerformLayout();
            this.groupBoxInPut_GVE.ResumeLayout(false);
            this.groupBoxInPut_GVE.PerformLayout();
            this.groupBoxRes_GVE.ResumeLayout(false);
            this.groupBoxRes_GVE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInfo_GVE;
        private System.Windows.Forms.Button buttonDone_GVE;
        private System.Windows.Forms.GroupBox groupBoxUsl_GVE;
        private System.Windows.Forms.Label labelUsl_GVE;
        private System.Windows.Forms.GroupBox groupBoxInPut_GVE;
        private System.Windows.Forms.TextBox textBoxStart_GVE;
        private System.Windows.Forms.TextBox textBoxFinish_GVE;
        private System.Windows.Forms.Label labelFinish_GVE;
        private System.Windows.Forms.Label labelStart_GVE;
        private System.Windows.Forms.GroupBox groupBoxRes_GVE;
        private System.Windows.Forms.Label labelRes_GVE;
        private System.Windows.Forms.TextBox textBoxRes_GVE;
    }
}

