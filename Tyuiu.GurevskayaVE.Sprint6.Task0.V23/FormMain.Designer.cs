
namespace Tyuiu.GurevskayaVE.Sprint6.Task0.V23
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
            this.groupBoxUslovie_GVE = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_GVE = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxInput_GVE = new System.Windows.Forms.GroupBox();
            this.labelVarX_GVE = new System.Windows.Forms.Label();
            this.textBoxVarX_GVE = new System.Windows.Forms.TextBox();
            this.groupBoxOut_GVE = new System.Windows.Forms.GroupBox();
            this.labelRes_GVE = new System.Windows.Forms.Label();
            this.textBoxRes_GVE = new System.Windows.Forms.TextBox();
            this.buttonDone_GVE = new System.Windows.Forms.Button();
            this.buttonInfo_GVE = new System.Windows.Forms.Button();
            this.groupBoxUslovie_GVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_GVE)).BeginInit();
            this.groupBoxInput_GVE.SuspendLayout();
            this.groupBoxOut_GVE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_GVE
            // 
            this.groupBoxUslovie_GVE.Controls.Add(this.textBox1);
            this.groupBoxUslovie_GVE.Controls.Add(this.pictureBoxFormula_GVE);
            this.groupBoxUslovie_GVE.Location = new System.Drawing.Point(29, 43);
            this.groupBoxUslovie_GVE.Name = "groupBoxUslovie_GVE";
            this.groupBoxUslovie_GVE.Size = new System.Drawing.Size(628, 184);
            this.groupBoxUslovie_GVE.TabIndex = 0;
            this.groupBoxUslovie_GVE.TabStop = false;
            this.groupBoxUslovie_GVE.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(356, 131);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Вычислить выражение по формуле: ";
            // 
            // pictureBoxFormula_GVE
            // 
            this.pictureBoxFormula_GVE.ErrorImage = null;
            this.pictureBoxFormula_GVE.Image = global::Tyuiu.GurevskayaVE.Sprint6.Task0.V23.Properties.Resources.task0;
            this.pictureBoxFormula_GVE.InitialImage = null;
            this.pictureBoxFormula_GVE.Location = new System.Drawing.Point(408, 34);
            this.pictureBoxFormula_GVE.Name = "pictureBoxFormula_GVE";
            this.pictureBoxFormula_GVE.Size = new System.Drawing.Size(125, 57);
            this.pictureBoxFormula_GVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFormula_GVE.TabIndex = 1;
            this.pictureBoxFormula_GVE.TabStop = false;
            // 
            // groupBoxInput_GVE
            // 
            this.groupBoxInput_GVE.Controls.Add(this.labelVarX_GVE);
            this.groupBoxInput_GVE.Controls.Add(this.textBoxVarX_GVE);
            this.groupBoxInput_GVE.Location = new System.Drawing.Point(29, 262);
            this.groupBoxInput_GVE.Name = "groupBoxInput_GVE";
            this.groupBoxInput_GVE.Size = new System.Drawing.Size(290, 100);
            this.groupBoxInput_GVE.TabIndex = 1;
            this.groupBoxInput_GVE.TabStop = false;
            this.groupBoxInput_GVE.Text = "Ввод данных:";
            // 
            // labelVarX_GVE
            // 
            this.labelVarX_GVE.AutoSize = true;
            this.labelVarX_GVE.Location = new System.Drawing.Point(7, 22);
            this.labelVarX_GVE.Name = "labelVarX_GVE";
            this.labelVarX_GVE.Size = new System.Drawing.Size(108, 17);
            this.labelVarX_GVE.TabIndex = 1;
            this.labelVarX_GVE.Text = "Переменная X:";
            // 
            // textBoxVarX_GVE
            // 
            this.textBoxVarX_GVE.Location = new System.Drawing.Point(10, 51);
            this.textBoxVarX_GVE.Name = "textBoxVarX_GVE";
            this.textBoxVarX_GVE.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarX_GVE.TabIndex = 0;
            this.textBoxVarX_GVE.TextChanged += new System.EventHandler(this.textBoxVarX_GVE_TextChanged);
            // 
            // groupBoxOut_GVE
            // 
            this.groupBoxOut_GVE.Controls.Add(this.labelRes_GVE);
            this.groupBoxOut_GVE.Controls.Add(this.textBoxRes_GVE);
            this.groupBoxOut_GVE.Location = new System.Drawing.Point(367, 262);
            this.groupBoxOut_GVE.Name = "groupBoxOut_GVE";
            this.groupBoxOut_GVE.Size = new System.Drawing.Size(290, 100);
            this.groupBoxOut_GVE.TabIndex = 1;
            this.groupBoxOut_GVE.TabStop = false;
            this.groupBoxOut_GVE.Text = "Вывод данных:";
            // 
            // labelRes_GVE
            // 
            this.labelRes_GVE.AutoSize = true;
            this.labelRes_GVE.Location = new System.Drawing.Point(6, 22);
            this.labelRes_GVE.Name = "labelRes_GVE";
            this.labelRes_GVE.Size = new System.Drawing.Size(80, 17);
            this.labelRes_GVE.TabIndex = 1;
            this.labelRes_GVE.Text = "Результат:";
            // 
            // textBoxRes_GVE
            // 
            this.textBoxRes_GVE.Location = new System.Drawing.Point(9, 51);
            this.textBoxRes_GVE.Name = "textBoxRes_GVE";
            this.textBoxRes_GVE.ReadOnly = true;
            this.textBoxRes_GVE.Size = new System.Drawing.Size(100, 22);
            this.textBoxRes_GVE.TabIndex = 0;
            // 
            // buttonDone_GVE
            // 
            this.buttonDone_GVE.Location = new System.Drawing.Point(554, 384);
            this.buttonDone_GVE.Name = "buttonDone_GVE";
            this.buttonDone_GVE.Size = new System.Drawing.Size(118, 38);
            this.buttonDone_GVE.TabIndex = 2;
            this.buttonDone_GVE.Text = "Выполнить";
            this.buttonDone_GVE.UseVisualStyleBackColor = true;
            this.buttonDone_GVE.Click += new System.EventHandler(this.buttonDone_GVE_Click);
            // 
            // buttonInfo_GVE
            // 
            this.buttonInfo_GVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_GVE.Location = new System.Drawing.Point(495, 384);
            this.buttonInfo_GVE.Name = "buttonInfo_GVE";
            this.buttonInfo_GVE.Size = new System.Drawing.Size(42, 38);
            this.buttonInfo_GVE.TabIndex = 3;
            this.buttonInfo_GVE.Text = "?";
            this.buttonInfo_GVE.UseVisualStyleBackColor = true;
            this.buttonInfo_GVE.Click += new System.EventHandler(this.buttonInfo_GVE_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 434);
            this.Controls.Add(this.buttonInfo_GVE);
            this.Controls.Add(this.buttonDone_GVE);
            this.Controls.Add(this.groupBoxOut_GVE);
            this.Controls.Add(this.groupBoxInput_GVE);
            this.Controls.Add(this.groupBoxUslovie_GVE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск0 | Вариант 23 | Гурьевская В.Е.";
            this.groupBoxUslovie_GVE.ResumeLayout(false);
            this.groupBoxUslovie_GVE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_GVE)).EndInit();
            this.groupBoxInput_GVE.ResumeLayout(false);
            this.groupBoxInput_GVE.PerformLayout();
            this.groupBoxOut_GVE.ResumeLayout(false);
            this.groupBoxOut_GVE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_GVE;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxFormula_GVE;
        private System.Windows.Forms.GroupBox groupBoxInput_GVE;
        private System.Windows.Forms.GroupBox groupBoxOut_GVE;
        private System.Windows.Forms.Label labelVarX_GVE;
        private System.Windows.Forms.TextBox textBoxVarX_GVE;
        private System.Windows.Forms.Label labelRes_GVE;
        private System.Windows.Forms.TextBox textBoxRes_GVE;
        private System.Windows.Forms.Button buttonDone_GVE;
        private System.Windows.Forms.Button buttonInfo_GVE;
        private System.Windows.Forms.TextBox textBox1;
    }
}

