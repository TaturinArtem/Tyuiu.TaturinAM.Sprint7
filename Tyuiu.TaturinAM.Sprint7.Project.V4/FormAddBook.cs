using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.TaturinAM.Sprint7.Project.V4
{
    public partial class FormAddBook : Form
    {
        FormMain fmain;
        public FormAddBook(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonAddNewBook_TAM_Click(object sender, EventArgs e)
        {
            fmain.dataGridViewMain_TAM.Rows.Add(textBoxBookArticle_TAM.Text, textBoxBookName_TAM.Text, textBoxBookAuthor_TAM.Text, textBoxBookYear_TAM.Text, textBoxBookGenre_TAM.Text, comboBoxIsBookNew_TAM.Text );
            fmain.buttonDeleteBook_TAM.Enabled = true;
            this.Close();
        }
    }
}
