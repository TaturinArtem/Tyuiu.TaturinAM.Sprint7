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
    public partial class FormEditUser : Form
    {
        FormMain fmain;
        public FormEditUser(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonEditUser_TAM_Click(object sender, EventArgs e)
        {
            int a = fmain.dataGridViewMain_TAM.CurrentRow.Index;
            fmain.dataGridViewMain_TAM.Rows[a].Cells[0].Value = textBoxUserID_TAM.Text;
            fmain.dataGridViewMain_TAM.Rows[a].Cells[1].Value = textBoxUserName_TAM.Text;
            fmain.dataGridViewMain_TAM.Rows[a].Cells[2].Value = textBoxUserAddress_TAM.Text;
            fmain.dataGridViewMain_TAM.Rows[a].Cells[3].Value = textBoxUserPhone_TAM.Text;
            fmain.dataGridViewMain_TAM.Rows[a].Cells[4].Value = textBoxUserBookArticle_TAM.Text;
            fmain.dataGridViewMain_TAM.Rows[a].Cells[5].Value = textBoxUserGetBookDate_TAM.Text;
            fmain.dataGridViewMain_TAM.Rows[a].Cells[6].Value = textBoxBookUserReturnBookDate_TAM.Text;
            this.Close();

        }
    }
}
