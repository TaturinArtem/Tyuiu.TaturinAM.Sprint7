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
    public partial class FormAddUser : Form
    {
        FormMain fmain;
        public FormAddUser(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void labelReturnDate_GKU_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddNewUser_TAM_Click(object sender, EventArgs e)
        {
            fmain.dataGridViewMain_TAM.Rows.Add(textBoxUserID_TAM.Text, textBoxUserName_TAM.Text, textBoxUserAddress_TAM.Text, textBoxUserPhone_TAM.Text, textBoxUserBookArticle_TAM.Text, textBoxUserGetBookDate_TAM.Text, textBoxBookUserReturnBookDate_TAM.Text);
            
            this.Close();
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
