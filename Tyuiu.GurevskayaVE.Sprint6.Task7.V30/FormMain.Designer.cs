
namespace Tyuiu.GurevskayaVE.Sprint6.Task7.V30
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelFill = new System.Windows.Forms.Panel();
            this.groupBoxUsl_GVE = new System.Windows.Forms.GroupBox();
            this.textBoxUsl_GVE = new System.Windows.Forms.TextBox();
            this.groupBoxIn_GVE = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_GVE = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_GVE = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_GVE = new System.Windows.Forms.DataGridView();
            this.openFileDialog_GVE = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_GVE = new System.Windows.Forms.ToolTip(this.components);
            this.buttonInfo_GVE = new System.Windows.Forms.Button();
            this.buttonSave_GVE = new System.Windows.Forms.Button();
            this.buttonDone_GVE = new System.Windows.Forms.Button();
            this.buttonOpen_GVE = new System.Windows.Forms.Button();
            this.saveFileDialog_GVE = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_GVE.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.groupBoxUsl_GVE.SuspendLayout();
            this.groupBoxIn_GVE.SuspendLayout();
            this.groupBoxOut_GVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_GVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GVE)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_GVE
            // 
            this.panelTop_GVE.Controls.Add(this.buttonInfo_GVE);
            this.panelTop_GVE.Controls.Add(this.buttonSave_GVE);
            this.panelTop_GVE.Controls.Add(this.buttonDone_GVE);
            this.panelTop_GVE.Controls.Add(this.buttonOpen_GVE);
            this.panelTop_GVE.Controls.Add(this.groupBoxUsl_GVE);
            this.panelTop_GVE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_GVE.Location = new System.Drawing.Point(0, 0);
            this.panelTop_GVE.Name = "panelTop_GVE";
            this.panelTop_GVE.Size = new System.Drawing.Size(1094, 222);
            this.panelTop_GVE.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxIn_GVE);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 222);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(531, 464);
            this.panelLeft.TabIndex = 1;
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.groupBoxOut_GVE);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(531, 222);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(563, 464);
            this.panelFill.TabIndex = 2;
            // 
            // groupBoxUsl_GVE
            // 
            this.groupBoxUsl_GVE.Controls.Add(this.textBoxUsl_GVE);
            this.groupBoxUsl_GVE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxUsl_GVE.Location = new System.Drawing.Point(0, 120);
            this.groupBoxUsl_GVE.Name = "groupBoxUsl_GVE";
            this.groupBoxUsl_GVE.Size = new System.Drawing.Size(1094, 102);
            this.groupBoxUsl_GVE.TabIndex = 0;
            this.groupBoxUsl_GVE.TabStop = false;
            this.groupBoxUsl_GVE.Text = "Условие";
            // 
            // textBoxUsl_GVE
            // 
            this.textBoxUsl_GVE.Location = new System.Drawing.Point(12, 22);
            this.textBoxUsl_GVE.Multiline = true;
            this.textBoxUsl_GVE.Name = "textBoxUsl_GVE";
            this.textBoxUsl_GVE.ReadOnly = true;
            this.textBoxUsl_GVE.Size = new System.Drawing.Size(1062, 74);
            this.textBoxUsl_GVE.TabIndex = 0;
            this.textBoxUsl_GVE.Text = resources.GetString("textBoxUsl_GVE.Text");
            // 
            // groupBoxIn_GVE
            // 
            this.groupBoxIn_GVE.Controls.Add(this.dataGridViewIn_GVE);
            this.groupBoxIn_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_GVE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_GVE.Name = "groupBoxIn_GVE";
            this.groupBoxIn_GVE.Size = new System.Drawing.Size(531, 464);
            this.groupBoxIn_GVE.TabIndex = 0;
            this.groupBoxIn_GVE.TabStop = false;
            this.groupBoxIn_GVE.Text = "Ввод";
            // 
            // groupBoxOut_GVE
            // 
            this.groupBoxOut_GVE.Controls.Add(this.dataGridViewOut_GVE);
            this.groupBoxOut_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_GVE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_GVE.Name = "groupBoxOut_GVE";
            this.groupBoxOut_GVE.Size = new System.Drawing.Size(563, 464);
            this.groupBoxOut_GVE.TabIndex = 0;
            this.groupBoxOut_GVE.TabStop = false;
            this.groupBoxOut_GVE.Text = "Вывод";
            // 
            // dataGridViewIn_GVE
            // 
            this.dataGridViewIn_GVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_GVE.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewIn_GVE.Name = "dataGridViewIn_GVE";
            this.dataGridViewIn_GVE.RowHeadersWidth = 51;
            this.dataGridViewIn_GVE.RowTemplate.Height = 24;
            this.dataGridViewIn_GVE.Size = new System.Drawing.Size(525, 443);
            this.dataGridViewIn_GVE.TabIndex = 0;
            // 
            // dataGridViewOut_GVE
            // 
            this.dataGridViewOut_GVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_GVE.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOut_GVE.Name = "dataGridViewOut_GVE";
            this.dataGridViewOut_GVE.RowHeadersWidth = 51;
            this.dataGridViewOut_GVE.RowTemplate.Height = 24;
            this.dataGridViewOut_GVE.Size = new System.Drawing.Size(557, 443);
            this.dataGridViewOut_GVE.TabIndex = 0;
            // 
            // openFileDialog_GVE
            // 
            this.openFileDialog_GVE.FileName = "openFileDialog1";
            // 
            // buttonInfo_GVE
            // 
            this.buttonInfo_GVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_GVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_GVE.Image = global::Tyuiu.GurevskayaVE.Sprint6.Task7.V30.Properties.Resources.information;
            this.buttonInfo_GVE.Location = new System.Drawing.Point(984, 12);
            this.buttonInfo_GVE.Name = "buttonInfo_GVE";
            this.buttonInfo_GVE.Size = new System.Drawing.Size(90, 90);
            this.buttonInfo_GVE.TabIndex = 4;
            this.toolTip_GVE.SetToolTip(this.buttonInfo_GVE, "Сведения о программе");
            this.buttonInfo_GVE.UseVisualStyleBackColor = true;
            this.buttonInfo_GVE.Click += new System.EventHandler(this.buttonInfo_GVE_Click);
            this.buttonInfo_GVE.Enter += new System.EventHandler(this.buttonInfo_GVE_MouseEnter);
            this.buttonInfo_GVE.MouseEnter += new System.EventHandler(this.buttonInfo_GVE_MouseEnter);
            // 
            // buttonSave_GVE
            // 
            this.buttonSave_GVE.Enabled = false;
            this.buttonSave_GVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_GVE.Image = global::Tyuiu.GurevskayaVE.Sprint6.Task7.V30.Properties.Resources.page_save;
            this.buttonSave_GVE.Location = new System.Drawing.Point(232, 12);
            this.buttonSave_GVE.Name = "buttonSave_GVE";
            this.buttonSave_GVE.Size = new System.Drawing.Size(90, 90);
            this.buttonSave_GVE.TabIndex = 3;
            this.toolTip_GVE.SetToolTip(this.buttonSave_GVE, "Сохранить обработанные данные в файл CSV");
            this.buttonSave_GVE.UseVisualStyleBackColor = true;
            this.buttonSave_GVE.Click += new System.EventHandler(this.buttonSave_GVE_Click);
            this.buttonSave_GVE.Enter += new System.EventHandler(this.buttonSave_GVE_MouseEnter);
            this.buttonSave_GVE.MouseEnter += new System.EventHandler(this.buttonSave_GVE_MouseEnter);
            // 
            // buttonDone_GVE
            // 
            this.buttonDone_GVE.Enabled = false;
            this.buttonDone_GVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_GVE.Image = global::Tyuiu.GurevskayaVE.Sprint6.Task7.V30.Properties.Resources.page_go;
            this.buttonDone_GVE.Location = new System.Drawing.Point(121, 12);
            this.buttonDone_GVE.Name = "buttonDone_GVE";
            this.buttonDone_GVE.Size = new System.Drawing.Size(90, 90);
            this.buttonDone_GVE.TabIndex = 2;
            this.toolTip_GVE.SetToolTip(this.buttonDone_GVE, "Выполнить обработку данных\r\n");
            this.buttonDone_GVE.UseVisualStyleBackColor = true;
            this.buttonDone_GVE.Click += new System.EventHandler(this.buttonDone_GVE_Click);
            this.buttonDone_GVE.Enter += new System.EventHandler(this.buttonDone_GVE_MouseEnter);
            this.buttonDone_GVE.MouseEnter += new System.EventHandler(this.buttonDone_GVE_MouseEnter);
            // 
            // buttonOpen_GVE
            // 
            this.buttonOpen_GVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen_GVE.Image = global::Tyuiu.GurevskayaVE.Sprint6.Task7.V30.Properties.Resources.folder_page;
            this.buttonOpen_GVE.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen_GVE.Name = "buttonOpen_GVE";
            this.buttonOpen_GVE.Size = new System.Drawing.Size(90, 90);
            this.buttonOpen_GVE.TabIndex = 1;
            this.toolTip_GVE.SetToolTip(this.buttonOpen_GVE, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpen_GVE.UseVisualStyleBackColor = true;
            this.buttonOpen_GVE.Click += new System.EventHandler(this.buttonOpen_GVE_Click);
            this.buttonOpen_GVE.MouseEnter += new System.EventHandler(this.buttonOpen_GVE_MouseEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 686);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop_GVE);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 30 | Гурьевская В.Е.";
            this.panelTop_GVE.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelFill.ResumeLayout(false);
            this.groupBoxUsl_GVE.ResumeLayout(false);
            this.groupBoxUsl_GVE.PerformLayout();
            this.groupBoxIn_GVE.ResumeLayout(false);
            this.groupBoxOut_GVE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_GVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GVE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_GVE;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Button buttonInfo_GVE;
        private System.Windows.Forms.Button buttonSave_GVE;
        private System.Windows.Forms.Button buttonDone_GVE;
        private System.Windows.Forms.Button buttonOpen_GVE;
        private System.Windows.Forms.GroupBox groupBoxUsl_GVE;
        private System.Windows.Forms.TextBox textBoxUsl_GVE;
        private System.Windows.Forms.GroupBox groupBoxIn_GVE;
        private System.Windows.Forms.DataGridView dataGridViewIn_GVE;
        private System.Windows.Forms.GroupBox groupBoxOut_GVE;
        private System.Windows.Forms.DataGridView dataGridViewOut_GVE;
        private System.Windows.Forms.ToolTip toolTip_GVE;
        private System.Windows.Forms.OpenFileDialog openFileDialog_GVE;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_GVE;
    }
}

