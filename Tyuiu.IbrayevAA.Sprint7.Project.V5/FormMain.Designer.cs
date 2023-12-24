
namespace Tyuiu.IbrayevAA.Sprint7.Project.V5
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolTipHelp_IAA = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogTask_IAA = new System.Windows.Forms.OpenFileDialog();
            this.panelToolBar_IAA = new System.Windows.Forms.Panel();
            this.buttonOpen_IAA = new System.Windows.Forms.Button();
            this.textBoxInput_IAA = new System.Windows.Forms.TextBox();
            this.buttonInfo_IAA = new System.Windows.Forms.Button();
            this.panelTabel_IAA = new System.Windows.Forms.Panel();
            this.dataGridViewTable_IAA = new System.Windows.Forms.DataGridView();
            this.splitterPanel_IAA = new System.Windows.Forms.Splitter();
            this.buttonSave_IAA = new System.Windows.Forms.Button();
            this.comboBoxFilter_IAA = new System.Windows.Forms.ComboBox();
            this.saveFileDialogCVS_IAA = new System.Windows.Forms.SaveFileDialog();
            this.labelSereach_IAA = new System.Windows.Forms.Label();
            this.labelFiltr_IAA = new System.Windows.Forms.Label();
            this.panelToolBar_IAA.SuspendLayout();
            this.panelTabel_IAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_IAA)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTipHelp_IAA
            // 
            this.toolTipHelp_IAA.IsBalloon = true;
            // 
            // openFileDialogTask_IAA
            // 
            this.openFileDialogTask_IAA.FileName = "openFileDialog1";
            this.openFileDialogTask_IAA.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogTask_IAA_FileOk);
            // 
            // panelToolBar_IAA
            // 
            this.panelToolBar_IAA.BackColor = System.Drawing.Color.White;
            this.panelToolBar_IAA.Controls.Add(this.labelFiltr_IAA);
            this.panelToolBar_IAA.Controls.Add(this.labelSereach_IAA);
            this.panelToolBar_IAA.Controls.Add(this.comboBoxFilter_IAA);
            this.panelToolBar_IAA.Controls.Add(this.buttonSave_IAA);
            this.panelToolBar_IAA.Controls.Add(this.buttonOpen_IAA);
            this.panelToolBar_IAA.Controls.Add(this.textBoxInput_IAA);
            this.panelToolBar_IAA.Controls.Add(this.buttonInfo_IAA);
            this.panelToolBar_IAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBar_IAA.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar_IAA.Name = "panelToolBar_IAA";
            this.panelToolBar_IAA.Size = new System.Drawing.Size(951, 76);
            this.panelToolBar_IAA.TabIndex = 0;
            // 
            // buttonOpen_IAA
            // 
            this.buttonOpen_IAA.Location = new System.Drawing.Point(453, 24);
            this.buttonOpen_IAA.Name = "buttonOpen_IAA";
            this.buttonOpen_IAA.Size = new System.Drawing.Size(134, 37);
            this.buttonOpen_IAA.TabIndex = 3;
            this.buttonOpen_IAA.Text = "открыть файл";
            this.toolTipHelp_IAA.SetToolTip(this.buttonOpen_IAA, "открывыет файл");
            this.buttonOpen_IAA.UseVisualStyleBackColor = true;
            this.buttonOpen_IAA.Click += new System.EventHandler(this.buttonOpen_IAA_Click);
            // 
            // textBoxInput_IAA
            // 
            this.textBoxInput_IAA.Location = new System.Drawing.Point(37, 39);
            this.textBoxInput_IAA.Name = "textBoxInput_IAA";
            this.textBoxInput_IAA.Size = new System.Drawing.Size(145, 22);
            this.textBoxInput_IAA.TabIndex = 1;
            this.toolTipHelp_IAA.SetToolTip(this.textBoxInput_IAA, "поиск");
            this.textBoxInput_IAA.TextChanged += new System.EventHandler(this.textBoxInput_IAA_TextChanged);
            // 
            // buttonInfo_IAA
            // 
            this.buttonInfo_IAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_IAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_IAA.Image")));
            this.buttonInfo_IAA.Location = new System.Drawing.Point(883, 12);
            this.buttonInfo_IAA.Name = "buttonInfo_IAA";
            this.buttonInfo_IAA.Size = new System.Drawing.Size(56, 58);
            this.buttonInfo_IAA.TabIndex = 0;
            this.toolTipHelp_IAA.SetToolTip(this.buttonInfo_IAA, "информация");
            this.buttonInfo_IAA.UseVisualStyleBackColor = true;
            this.buttonInfo_IAA.Click += new System.EventHandler(this.buttonInfo_IAA_Click);
            // 
            // panelTabel_IAA
            // 
            this.panelTabel_IAA.BackColor = System.Drawing.Color.White;
            this.panelTabel_IAA.Controls.Add(this.dataGridViewTable_IAA);
            this.panelTabel_IAA.Controls.Add(this.splitterPanel_IAA);
            this.panelTabel_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabel_IAA.Location = new System.Drawing.Point(0, 76);
            this.panelTabel_IAA.Name = "panelTabel_IAA";
            this.panelTabel_IAA.Size = new System.Drawing.Size(951, 432);
            this.panelTabel_IAA.TabIndex = 1;
            // 
            // dataGridViewTable_IAA
            // 
            this.dataGridViewTable_IAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable_IAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTable_IAA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTable_IAA.Name = "dataGridViewTable_IAA";
            this.dataGridViewTable_IAA.RowHeadersVisible = false;
            this.dataGridViewTable_IAA.RowHeadersWidth = 51;
            this.dataGridViewTable_IAA.RowTemplate.Height = 24;
            this.dataGridViewTable_IAA.Size = new System.Drawing.Size(948, 432);
            this.dataGridViewTable_IAA.TabIndex = 1;
            // 
            // splitterPanel_IAA
            // 
            this.splitterPanel_IAA.BackColor = System.Drawing.SystemColors.Control;
            this.splitterPanel_IAA.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterPanel_IAA.Location = new System.Drawing.Point(948, 0);
            this.splitterPanel_IAA.Name = "splitterPanel_IAA";
            this.splitterPanel_IAA.Size = new System.Drawing.Size(3, 432);
            this.splitterPanel_IAA.TabIndex = 0;
            this.splitterPanel_IAA.TabStop = false;
            // 
            // buttonSave_IAA
            // 
            this.buttonSave_IAA.Location = new System.Drawing.Point(613, 23);
            this.buttonSave_IAA.Name = "buttonSave_IAA";
            this.buttonSave_IAA.Size = new System.Drawing.Size(102, 37);
            this.buttonSave_IAA.TabIndex = 4;
            this.buttonSave_IAA.Text = "Сохранить";
            this.toolTipHelp_IAA.SetToolTip(this.buttonSave_IAA, "сохраняет файл");
            this.buttonSave_IAA.UseVisualStyleBackColor = true;
            this.buttonSave_IAA.Click += new System.EventHandler(this.buttonSave_IAA_Click);
            // 
            // comboBoxFilter_IAA
            // 
            this.comboBoxFilter_IAA.FormattingEnabled = true;
            this.comboBoxFilter_IAA.Items.AddRange(new object[] {
            "2%",
            "5%",
            "7%",
            "-"});
            this.comboBoxFilter_IAA.Location = new System.Drawing.Point(225, 37);
            this.comboBoxFilter_IAA.Name = "comboBoxFilter_IAA";
            this.comboBoxFilter_IAA.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFilter_IAA.TabIndex = 5;
            this.toolTipHelp_IAA.SetToolTip(this.comboBoxFilter_IAA, "фильтр");
            // 
            // labelSereach_IAA
            // 
            this.labelSereach_IAA.AutoSize = true;
            this.labelSereach_IAA.Location = new System.Drawing.Point(34, 12);
            this.labelSereach_IAA.Name = "labelSereach_IAA";
            this.labelSereach_IAA.Size = new System.Drawing.Size(48, 17);
            this.labelSereach_IAA.TabIndex = 6;
            this.labelSereach_IAA.Text = "Поиск";
            // 
            // labelFiltr_IAA
            // 
            this.labelFiltr_IAA.AutoSize = true;
            this.labelFiltr_IAA.Location = new System.Drawing.Point(222, 12);
            this.labelFiltr_IAA.Name = "labelFiltr_IAA";
            this.labelFiltr_IAA.Size = new System.Drawing.Size(197, 17);
            this.labelFiltr_IAA.TabIndex = 6;
            this.labelFiltr_IAA.Text = "Фильтр по характеристикам";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 508);
            this.Controls.Add(this.panelTabel_IAA);
            this.Controls.Add(this.panelToolBar_IAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оптовая база";
            this.panelToolBar_IAA.ResumeLayout(false);
            this.panelToolBar_IAA.PerformLayout();
            this.panelTabel_IAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_IAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipHelp_IAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_IAA;
        private System.Windows.Forms.Panel panelToolBar_IAA;
        private System.Windows.Forms.Panel panelTabel_IAA;
        private System.Windows.Forms.Splitter splitterPanel_IAA;
        private System.Windows.Forms.Button buttonInfo_IAA;
        private System.Windows.Forms.DataGridView dataGridViewTable_IAA;
        private System.Windows.Forms.TextBox textBoxInput_IAA;
        private System.Windows.Forms.Button buttonOpen_IAA;
        private System.Windows.Forms.Button buttonSave_IAA;
        private System.Windows.Forms.ComboBox comboBoxFilter_IAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCVS_IAA;
        private System.Windows.Forms.Label labelFiltr_IAA;
        private System.Windows.Forms.Label labelSereach_IAA;
    }
}

