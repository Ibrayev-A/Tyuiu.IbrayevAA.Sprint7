using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IbrayevAA.Sprint7.Project.V5.Lib;
using System.IO;


namespace Tyuiu.IbrayevAA.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private string fileName = string.Empty;

        private DataTableCollection tableCollection = null;

        private void buttonSearch_IAA_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpen_IAA_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileDialogTask_IAA_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                DialogResult res = openFileDialogTask_IAA.ShowDialog();

                if (res == DialogResult.OK)
                {
                    fileName = openFileDialogTask_IAA.FileName;
                    Text = fileName;
                }
                else
                {
                    throw new Exception("Файл не выбран!");
                }
            }
            catch
            {
                MessageBox.Show(ex.Message, )
            }
        }
    }
}
