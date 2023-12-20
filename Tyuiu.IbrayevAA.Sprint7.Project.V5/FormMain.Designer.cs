
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
            this.toolTipHelp_IAA = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogWindows_IAA = new System.Windows.Forms.OpenFileDialog();
            this.panelToolBar_IAA = new System.Windows.Forms.Panel();
            this.panelView_IAA = new System.Windows.Forms.Panel();
            this.panelTabel_IAA = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelTabel_IAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogWindows_IAA
            // 
            this.openFileDialogWindows_IAA.FileName = "openFileDialog1";
            // 
            // panelToolBar_IAA
            // 
            this.panelToolBar_IAA.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelToolBar_IAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolBar_IAA.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar_IAA.Name = "panelToolBar_IAA";
            this.panelToolBar_IAA.Size = new System.Drawing.Size(800, 76);
            this.panelToolBar_IAA.TabIndex = 0;
            // 
            // panelView_IAA
            // 
            this.panelView_IAA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelView_IAA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelView_IAA.Location = new System.Drawing.Point(408, 76);
            this.panelView_IAA.Name = "panelView_IAA";
            this.panelView_IAA.Size = new System.Drawing.Size(392, 374);
            this.panelView_IAA.TabIndex = 3;
            // 
            // panelTabel_IAA
            // 
            this.panelTabel_IAA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelTabel_IAA.Controls.Add(this.splitter1);
            this.panelTabel_IAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTabel_IAA.Location = new System.Drawing.Point(0, 76);
            this.panelTabel_IAA.Name = "panelTabel_IAA";
            this.panelTabel_IAA.Size = new System.Drawing.Size(357, 374);
            this.panelTabel_IAA.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Control;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(354, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 374);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelView_IAA);
            this.Controls.Add(this.panelTabel_IAA);
            this.Controls.Add(this.panelToolBar_IAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оптовая база";
            this.panelTabel_IAA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipHelp_IAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogWindows_IAA;
        private System.Windows.Forms.Panel panelToolBar_IAA;
        private System.Windows.Forms.Panel panelTabel_IAA;
        private System.Windows.Forms.Panel panelView_IAA;
        private System.Windows.Forms.Splitter splitter1;
    }
}

