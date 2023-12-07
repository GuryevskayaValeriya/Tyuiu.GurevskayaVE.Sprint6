
namespace Tyuiu.GurevskayaVE.Sprint6.Task6.V21
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_GVE = new System.Windows.Forms.Panel();
            this.panelLeft_GVE = new System.Windows.Forms.Panel();
            this.panelFill_GVE = new System.Windows.Forms.Panel();
            this.openFileDialog_GVE = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_GVE = new System.Windows.Forms.ToolTip(this.components);
            this.buttonInfo_GVE = new System.Windows.Forms.Button();
            this.buttonDone_GVE = new System.Windows.Forms.Button();
            this.buttonOpenFile_GVE = new System.Windows.Forms.Button();
            this.groupBoxUsl_GVE = new System.Windows.Forms.GroupBox();
            this.labelUsl_GVE = new System.Windows.Forms.Label();
            this.groupBoxIn_GVE = new System.Windows.Forms.GroupBox();
            this.textBoxIn_GVE = new System.Windows.Forms.TextBox();
            this.groupBoxOut_GVE = new System.Windows.Forms.GroupBox();
            this.textBoxOut_GVE = new System.Windows.Forms.TextBox();
            this.panelTop_GVE.SuspendLayout();
            this.panelLeft_GVE.SuspendLayout();
            this.panelFill_GVE.SuspendLayout();
            this.groupBoxUsl_GVE.SuspendLayout();
            this.groupBoxIn_GVE.SuspendLayout();
            this.groupBoxOut_GVE.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_GVE
            // 
            this.panelTop_GVE.Controls.Add(this.groupBoxUsl_GVE);
            this.panelTop_GVE.Controls.Add(this.buttonInfo_GVE);
            this.panelTop_GVE.Controls.Add(this.buttonDone_GVE);
            this.panelTop_GVE.Controls.Add(this.buttonOpenFile_GVE);
            this.panelTop_GVE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_GVE.Location = new System.Drawing.Point(0, 0);
            this.panelTop_GVE.Name = "panelTop_GVE";
            this.panelTop_GVE.Size = new System.Drawing.Size(821, 186);
            this.panelTop_GVE.TabIndex = 0;
            // 
            // panelLeft_GVE
            // 
            this.panelLeft_GVE.Controls.Add(this.groupBoxIn_GVE);
            this.panelLeft_GVE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_GVE.Location = new System.Drawing.Point(0, 186);
            this.panelLeft_GVE.Name = "panelLeft_GVE";
            this.panelLeft_GVE.Size = new System.Drawing.Size(396, 407);
            this.panelLeft_GVE.TabIndex = 1;
            // 
            // panelFill_GVE
            // 
            this.panelFill_GVE.Controls.Add(this.groupBoxOut_GVE);
            this.panelFill_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_GVE.Location = new System.Drawing.Point(396, 186);
            this.panelFill_GVE.Name = "panelFill_GVE";
            this.panelFill_GVE.Size = new System.Drawing.Size(425, 407);
            this.panelFill_GVE.TabIndex = 2;
            // 
            // openFileDialog_GVE
            // 
            this.openFileDialog_GVE.FileName = "openFileDialog1";
            // 
            // toolTip_GVE
            // 
            this.toolTip_GVE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_GVE.ToolTipTitle = "Подсказка";
            // 
            // buttonInfo_GVE
            // 
            this.buttonInfo_GVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_GVE.Image = global::Tyuiu.GurevskayaVE.Sprint6.Task6.V21.Properties.Resources.information;
            this.buttonInfo_GVE.Location = new System.Drawing.Point(723, 12);
            this.buttonInfo_GVE.Name = "buttonInfo_GVE";
            this.buttonInfo_GVE.Size = new System.Drawing.Size(85, 69);
            this.buttonInfo_GVE.TabIndex = 1;
            this.toolTip_GVE.SetToolTip(this.buttonInfo_GVE, "Сведения о программе");
            this.buttonInfo_GVE.UseVisualStyleBackColor = true;
            this.buttonInfo_GVE.Click += new System.EventHandler(this.buttonInfo_GVE_Click);
            // 
            // buttonDone_GVE
            // 
            this.buttonDone_GVE.Image = global::Tyuiu.GurevskayaVE.Sprint6.Task6.V21.Properties.Resources.folder_page;
            this.buttonDone_GVE.Location = new System.Drawing.Point(103, 12);
            this.buttonDone_GVE.Name = "buttonDone_GVE";
            this.buttonDone_GVE.Size = new System.Drawing.Size(85, 69);
            this.buttonDone_GVE.TabIndex = 0;
            this.toolTip_GVE.SetToolTip(this.buttonDone_GVE, "Производит поиск в файле вхождений символов \"g\" \r\nи конкатенирует строки в которы" +
        "х находятся \r\nэти символы");
            this.buttonDone_GVE.UseVisualStyleBackColor = true;
            this.buttonDone_GVE.Click += new System.EventHandler(this.buttonDone_GVE_Click);
            // 
            // buttonOpenFile_GVE
            // 
            this.buttonOpenFile_GVE.Image = global::Tyuiu.GurevskayaVE.Sprint6.Task6.V21.Properties.Resources.page_go;
            this.buttonOpenFile_GVE.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_GVE.Name = "buttonOpenFile_GVE";
            this.buttonOpenFile_GVE.Size = new System.Drawing.Size(85, 69);
            this.buttonOpenFile_GVE.TabIndex = 0;
            this.toolTip_GVE.SetToolTip(this.buttonOpenFile_GVE, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_GVE.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GVE.Click += new System.EventHandler(this.buttonOpenFile_GVE_Click);
            // 
            // groupBoxUsl_GVE
            // 
            this.groupBoxUsl_GVE.Controls.Add(this.labelUsl_GVE);
            this.groupBoxUsl_GVE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxUsl_GVE.Location = new System.Drawing.Point(0, 95);
            this.groupBoxUsl_GVE.Name = "groupBoxUsl_GVE";
            this.groupBoxUsl_GVE.Size = new System.Drawing.Size(821, 91);
            this.groupBoxUsl_GVE.TabIndex = 2;
            this.groupBoxUsl_GVE.TabStop = false;
            this.groupBoxUsl_GVE.Text = "Условие";
            // 
            // labelUsl_GVE
            // 
            this.labelUsl_GVE.AutoSize = true;
            this.labelUsl_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsl_GVE.Location = new System.Drawing.Point(3, 18);
            this.labelUsl_GVE.Name = "labelUsl_GVE";
            this.labelUsl_GVE.Size = new System.Drawing.Size(624, 51);
            this.labelUsl_GVE.TabIndex = 0;
            this.labelUsl_GVE.Text = resources.GetString("labelUsl_GVE.Text");
            // 
            // groupBoxIn_GVE
            // 
            this.groupBoxIn_GVE.Controls.Add(this.textBoxIn_GVE);
            this.groupBoxIn_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_GVE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_GVE.Name = "groupBoxIn_GVE";
            this.groupBoxIn_GVE.Size = new System.Drawing.Size(396, 407);
            this.groupBoxIn_GVE.TabIndex = 0;
            this.groupBoxIn_GVE.TabStop = false;
            this.groupBoxIn_GVE.Text = "Ввод:";
            // 
            // textBoxIn_GVE
            // 
            this.textBoxIn_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn_GVE.Location = new System.Drawing.Point(3, 18);
            this.textBoxIn_GVE.Multiline = true;
            this.textBoxIn_GVE.Name = "textBoxIn_GVE";
            this.textBoxIn_GVE.ReadOnly = true;
            this.textBoxIn_GVE.Size = new System.Drawing.Size(390, 386);
            this.textBoxIn_GVE.TabIndex = 0;
            // 
            // groupBoxOut_GVE
            // 
            this.groupBoxOut_GVE.Controls.Add(this.textBoxOut_GVE);
            this.groupBoxOut_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_GVE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_GVE.Name = "groupBoxOut_GVE";
            this.groupBoxOut_GVE.Size = new System.Drawing.Size(425, 407);
            this.groupBoxOut_GVE.TabIndex = 0;
            this.groupBoxOut_GVE.TabStop = false;
            this.groupBoxOut_GVE.Text = "Вывод:";
            // 
            // textBoxOut_GVE
            // 
            this.textBoxOut_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_GVE.Location = new System.Drawing.Point(3, 18);
            this.textBoxOut_GVE.Multiline = true;
            this.textBoxOut_GVE.Name = "textBoxOut_GVE";
            this.textBoxOut_GVE.ReadOnly = true;
            this.textBoxOut_GVE.Size = new System.Drawing.Size(419, 386);
            this.textBoxOut_GVE.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 593);
            this.Controls.Add(this.panelFill_GVE);
            this.Controls.Add(this.panelLeft_GVE);
            this.Controls.Add(this.panelTop_GVE);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6  | Вариант 21 | Гурьевская В.Е.";
            this.panelTop_GVE.ResumeLayout(false);
            this.panelLeft_GVE.ResumeLayout(false);
            this.panelFill_GVE.ResumeLayout(false);
            this.groupBoxUsl_GVE.ResumeLayout(false);
            this.groupBoxUsl_GVE.PerformLayout();
            this.groupBoxIn_GVE.ResumeLayout(false);
            this.groupBoxIn_GVE.PerformLayout();
            this.groupBoxOut_GVE.ResumeLayout(false);
            this.groupBoxOut_GVE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_GVE;
        private System.Windows.Forms.Button buttonOpenFile_GVE;
        private System.Windows.Forms.Panel panelLeft_GVE;
        private System.Windows.Forms.Panel panelFill_GVE;
        private System.Windows.Forms.OpenFileDialog openFileDialog_GVE;
        private System.Windows.Forms.ToolTip toolTip_GVE;
        private System.Windows.Forms.Button buttonInfo_GVE;
        private System.Windows.Forms.Button buttonDone_GVE;
        private System.Windows.Forms.GroupBox groupBoxUsl_GVE;
        private System.Windows.Forms.Label labelUsl_GVE;
        private System.Windows.Forms.GroupBox groupBoxIn_GVE;
        private System.Windows.Forms.TextBox textBoxIn_GVE;
        private System.Windows.Forms.GroupBox groupBoxOut_GVE;
        private System.Windows.Forms.TextBox textBoxOut_GVE;
    }
}

