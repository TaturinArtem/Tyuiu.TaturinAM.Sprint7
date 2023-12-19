using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TaturinAM.Sprint7.Project.V4.Lib;
using System.IO;
namespace Tyuiu.TaturinAM.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void groupBoxInfo_TAM_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxBookButtons_TAM_Enter(object sender, EventArgs e)
        {

        }
        public static string[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);

            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

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

        private void buttonOpenBookBase_TAM_Click(object sender, EventArgs e)
        {
            openFileDialogTask_TAM.ShowDialog();
            openFilePath = openFileDialogTask_TAM.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            arrayValues = ds.GetBase(openFilePath);
            buttonBooks_TAM.Enabled = true;
            buttonDeleteBook_TAM.Enabled = true;
            buttonChangeBook_TAM.Enabled = true;
        }

        private void buttonBooks_TAM_Click(object sender, EventArgs e)
        {
            dataGridViewMain_TAM.ColumnCount = columns;
            dataGridViewMain_TAM.RowCount = rows;

            dataGridViewMain_TAM.Columns[0].HeaderText = "Артикул";
            dataGridViewMain_TAM.Columns[1].HeaderText = "Название";
            dataGridViewMain_TAM.Columns[2].HeaderText = "Автор";
            dataGridViewMain_TAM.Columns[3].HeaderText = "Год издания";
            dataGridViewMain_TAM.Columns[4].HeaderText = "Жанр";
            dataGridViewMain_TAM.Columns[5].HeaderText = "Новое издание";
            dataGridViewMain_TAM.Columns[6].HeaderText = "Аннотация";

            dataGridViewMain_TAM.Columns[0].Width = 50;
            dataGridViewMain_TAM.Columns[1].Width = 200;
            dataGridViewMain_TAM.Columns[2].Width = 100;
            dataGridViewMain_TAM.Columns[3].Width = 50;
            dataGridViewMain_TAM.Columns[4].Width = 60;
            dataGridViewMain_TAM.Columns[5].Width = 50;
            dataGridViewMain_TAM.Columns[6].Width = 300;


            dataGridViewMain_TAM.Rows[0].ReadOnly = true;
            dataGridViewMain_TAM.Columns[0].ReadOnly = true;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMain_TAM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetBase(openFilePath);
            buttonDeleteBook_TAM.Visible = true;
            buttonChangeBook_TAM.Visible = true;
            buttonFindBook_TAM.Visible = true;
            buttonAddBook_TAM.Visible = true;
        }

        private void buttonDeleteBook_TAM_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain_TAM.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewMain_TAM.CurrentRow.Index;
                    dataGridViewMain_TAM.Rows.Remove(dataGridViewMain_TAM.Rows[a]);
                    if (dataGridViewMain_TAM.Rows.Count == 1)
                    {
                        dataGridViewMain_TAM.Rows.Clear();
                    }
                }
                if (dataGridViewMain_TAM.Rows.Count <= 1)
                {
                    buttonDeleteBook_TAM.Enabled = false;
                    buttonChangeBook_TAM.Enabled = false;
                }
                if (dataGridViewMain_TAM.Rows.Count > 1)
                {
                    buttonDeleteBook_TAM.Enabled = true;
                }
                buttonBooks_TAM.Enabled = false;

            }
            catch
            {
                MessageBox.Show("Ошибка при удалении книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddBook_TAM_Click(object sender, EventArgs e)
        {
            FormAddBook formAddBook = new FormAddBook(this);
            formAddBook.ShowDialog();
            buttonBooks_TAM.Enabled = false;
        }

        private void buttonChangeBook_TAM_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridViewMain_TAM.CurrentRow.Index;
                FormEditBook fed = new FormEditBook(this);
                fed.textBoxBookArticle_TAM.Text = dataGridViewMain_TAM.Rows[a].Cells[0].Value.ToString();
                fed.textBoxBookName_TAM.Text = dataGridViewMain_TAM.Rows[a].Cells[1].Value.ToString();
                fed.textBoxBookAuthor_TAM.Text = dataGridViewMain_TAM.Rows[a].Cells[2].Value.ToString();
                fed.textBoxBookYear_TAM.Text = dataGridViewMain_TAM.Rows[a].Cells[3].Value.ToString();
                fed.textBoxBookGenre_TAM.Text = dataGridViewMain_TAM.Rows[a].Cells[4].Value.ToString();
                fed.comboBoxIsBookNew_TAM.Text = dataGridViewMain_TAM.Rows[a].Cells[5].Value.ToString();
               
                fed.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFindBook_TAM_Click(object sender, EventArgs e)
        {
            FormSearchBook formSearchBook = new FormSearchBook(this);
            formSearchBook.ShowDialog();
        }
    }
}
