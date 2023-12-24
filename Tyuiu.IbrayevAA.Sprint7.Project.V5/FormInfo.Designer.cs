
namespace Tyuiu.IbrayevAA.Sprint7.Project.V5
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxMe_IAA = new System.Windows.Forms.PictureBox();
            this.buttonOk_IAA = new System.Windows.Forms.Button();
            this.labelInfo_IAA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_IAA)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(509, 242);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBoxMe_IAA
            // 
            this.pictureBoxMe_IAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMe_IAA.Image")));
            this.pictureBoxMe_IAA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxMe_IAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMe_IAA.Name = "pictureBoxMe_IAA";
            this.pictureBoxMe_IAA.Size = new System.Drawing.Size(160, 242);
            this.pictureBoxMe_IAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMe_IAA.TabIndex = 3;
            this.pictureBoxMe_IAA.TabStop = false;
            // 
            // buttonOk_IAA
            // 
            this.buttonOk_IAA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOk_IAA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOk_IAA.Location = new System.Drawing.Point(698, 414);
            this.buttonOk_IAA.Name = "buttonOk_IAA";
            this.buttonOk_IAA.Size = new System.Drawing.Size(90, 24);
            this.buttonOk_IAA.TabIndex = 4;
            this.buttonOk_IAA.Text = "Ок";
            this.buttonOk_IAA.UseVisualStyleBackColor = true;
            this.buttonOk_IAA.Click += new System.EventHandler(this.buttonOk_IAA_Click);
            // 
            // labelInfo_IAA
            // 
            this.labelInfo_IAA.AutoSize = true;
            this.labelInfo_IAA.Location = new System.Drawing.Point(12, 267);
            this.labelInfo_IAA.Name = "labelInfo_IAA";
            this.labelInfo_IAA.Size = new System.Drawing.Size(319, 17);
            this.labelInfo_IAA.TabIndex = 5;
            this.labelInfo_IAA.Text = "Данная программа нужна для оптового склада";
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInfo_IAA);
            this.Controls.Add(this.buttonOk_IAA);
            this.Controls.Add(this.pictureBoxMe_IAA);
            this.Controls.Add(this.textBox1);
            this.Name = "FormInfo";
            this.Text = "Информация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_IAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBoxMe_IAA;
        private System.Windows.Forms.Button buttonOk_IAA;
        private System.Windows.Forms.Label labelInfo_IAA;
    }
}