﻿
namespace Tyuiu.GurevskayaVE.Sprint6.Task7.V30
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_GVE = new System.Windows.Forms.Label();
            this.buttonClose_GVE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.GurevskayaVE.Sprint6.Task7.V30.Properties.Resources._222;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 177);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_GVE
            // 
            this.label_GVE.AutoSize = true;
            this.label_GVE.Location = new System.Drawing.Point(151, 13);
            this.label_GVE.Name = "label_GVE";
            this.label_GVE.Size = new System.Drawing.Size(363, 119);
            this.label_GVE.TabIndex = 1;
            this.label_GVE.Text = "Разработчик: Гурьевская В.Е.\r\nгруппа ПКТб-23-2\r\n\r\nПрограмма разработана в рамках " +
    "изучения языка C#\r\n\r\nТюменский индустриальный университет (с) 2023\r\nВысшая школа" +
    " цифровых технологий (с) 2023\r\n";
            // 
            // buttonClose_GVE
            // 
            this.buttonClose_GVE.Location = new System.Drawing.Point(371, 198);
            this.buttonClose_GVE.Name = "buttonClose_GVE";
            this.buttonClose_GVE.Size = new System.Drawing.Size(148, 42);
            this.buttonClose_GVE.TabIndex = 2;
            this.buttonClose_GVE.Text = "OK";
            this.buttonClose_GVE.UseVisualStyleBackColor = true;
            this.buttonClose_GVE.Click += new System.EventHandler(this.buttonClose_GVE_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 252);
            this.Controls.Add(this.buttonClose_GVE);
            this.Controls.Add(this.label_GVE);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_GVE;
        private System.Windows.Forms.Button buttonClose_GVE;
    }
}