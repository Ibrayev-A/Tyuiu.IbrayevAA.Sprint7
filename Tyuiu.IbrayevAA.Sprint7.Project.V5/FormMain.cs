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
using System.Text.RegularExpressions;

namespace Tyuiu.IbrayevAA.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }



        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath, Encoding.Default);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }

            return arrayValues;
        }

        private void LoadDataIntoDataGridView(string filePath)
        {

            string[,] dataArray = LoadFromFileData(filePath);


            dataGridViewTable_IAA.Rows.Clear();
            dataGridViewTable_IAA.Columns.Clear();


            for (int i = 0; i < dataArray.GetLength(1); i++)
            {
                dataGridViewTable_IAA.Columns.Add("", dataArray[0, i]);
            }


            for (int i = 1; i < dataArray.GetLength(0); i++)
            {
                List<string> rowData = new List<string>();
                for (int j = 0; j < dataArray.GetLength(1); j++)
                {
                    rowData.Add(dataArray[i, j]);
                }
                dataGridViewTable_IAA.Rows.Add(rowData.ToArray());
            }
        }


        private void buttonSearch_IAA_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpen_IAA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogTask_IAA = new OpenFileDialog();
            openFileDialogTask_IAA.Filter = "csv Files|*.csv";
            if (openFileDialogTask_IAA.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogTask_IAA.FileName;


                LoadDataIntoDataGridView(filePath);
            }

        }
        private void openFileDialogTask_IAA_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonSave_IAA_Click(object sender, EventArgs e)
        {
            saveFileDialogCVS_IAA.FileName = "NewDataGrid.csv";
            saveFileDialogCVS_IAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogCVS_IAA.ShowDialog();

            string path = saveFileDialogCVS_IAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewTable_IAA.RowCount;
            int columns = dataGridViewTable_IAA.ColumnCount;

            string str = "Код, Название, Кол-во, Цена, Характеристика\n";
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTable_IAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewTable_IAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine, Encoding.Default);
                str = "";
            }

            DialogResult dialogres = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogres == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }

        private void textBoxInput_IAA_TextChanged(object sender, EventArgs e)
        {


            string searchValue = textBoxInput_IAA.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewTable_IAA.Rows)
            {
                if (row.IsNewRow) continue;

                bool found = false;

                for (int j = 0; j < dataGridViewTable_IAA.Columns.Count; j++)
                {
                    if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().ToLower().Contains(searchValue))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found;
            }
        }
    
            
    

            private void buttonAdd_IAA_Click(object sender, EventArgs e)
            {

            }

        private void comboBoxFilter_IAA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonInfo_IAA_Click(object sender, EventArgs e)
        {
            FormInfo fromAbout = new FormInfo();
            fromAbout.ShowDialog();
        }
    }
}