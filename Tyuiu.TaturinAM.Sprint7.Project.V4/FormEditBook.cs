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
    public partial class FormEditBook : Form
    {
        FormMain fmain;
        public FormEditBook(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonEditNewBook_TAM_Click(object sender, EventArgs e)
        {
            int a = fmain.dataGridViewMain_TAM.CurrentRow.Index;
            fmain.dataGridViewMain_TAM.Rows[a].Cells[0].Value = textBoxBookArticle_TAM.Text;
            fmain.dataGridViewMain_TAM.Rows[a].Cells[1].Value = textBoxBookName_TAM.Text;
            fmain.dataGridViewMain_TAM.Rows[a].Cells[2].Value = textBoxBookAuthor_TAM.Text;
            fmain.dataGridViewMain_TAM.Rows[a].Cells[3].Value = textBoxBookYear_TAM.Text;
            fmain.dataGridViewMain_TAM.Rows[a].Cells[4].Value = textBoxBookGenre_TAM.Text;
            fmain.dataGridViewMain_TAM.Rows[a].Cells[5].Value = comboBoxIsBookNew_TAM.Text;
          
            this.Close();
        }
    }
}
