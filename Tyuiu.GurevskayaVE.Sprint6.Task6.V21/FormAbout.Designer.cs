
namespace Tyuiu.GurevskayaVE.Sprint6.Task6.V21
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_GVE = new System.Windows.Forms.PictureBox();
            this.textBox_GVE = new System.Windows.Forms.TextBox();
            this.buttonOk_GVE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GVE)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_GVE
            // 
            this.pictureBox_GVE.Image = global::Tyuiu.GurevskayaVE.Sprint6.Task6.V21.Properties.Resources._2222;
            this.pictureBox_GVE.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_GVE.Name = "pictureBox_GVE";
            this.pictureBox_GVE.Size = new System.Drawing.Size(130, 175);
            this.pictureBox_GVE.TabIndex = 0;
            this.pictureBox_GVE.TabStop = false;
            // 
            // textBox_GVE
            // 
            this.textBox_GVE.Location = new System.Drawing.Point(150, 13);
            this.textBox_GVE.Multiline = true;
            this.textBox_GVE.Name = "textBox_GVE";
            this.textBox_GVE.ReadOnly = true;
            this.textBox_GVE.Size = new System.Drawing.Size(347, 175);
            this.textBox_GVE.TabIndex = 1;
            this.textBox_GVE.Text = "Разработчик: Гурьевская В.Е.\r\nгруппа ПКТб-23-2\r\n\r\nПрограмма разработана в рамках " +
    "изучения языка C#\r\n\r\nТюменский индустриальный университет (с) 2023\r\nВысшая школа" +
    " цифровых технологий (с) 2023\r\n";
            // 
            // buttonOk_GVE
            // 
            this.buttonOk_GVE.Location = new System.Drawing.Point(257, 195);
            this.buttonOk_GVE.Name = "buttonOk_GVE";
            this.buttonOk_GVE.Size = new System.Drawing.Size(240, 48);
            this.buttonOk_GVE.TabIndex = 2;
            this.buttonOk_GVE.Text = "ОК";
            this.buttonOk_GVE.UseVisualStyleBackColor = true;
            this.buttonOk_GVE.Click += new System.EventHandler(this.buttonOk_GVE_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 255);
            this.Controls.Add(this.buttonOk_GVE);
            this.Controls.Add(this.textBox_GVE);
            this.Controls.Add(this.pictureBox_GVE);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GVE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_GVE;
        private System.Windows.Forms.TextBox textBox_GVE;
        private System.Windows.Forms.Button buttonOk_GVE;
    }
}