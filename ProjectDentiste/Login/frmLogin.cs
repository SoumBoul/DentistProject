using BL_Framwork;
using ProjectDentiste.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDentiste.Login
{
    public partial class frmLogin : Form
    {
        string name = " ";
        public frmLogin()
        {
            InitializeComponent();
        }

        public string UserName
        {
            get { return txtUserName.Text; }
        }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           // cbEmployes.SelectedItem ="Employee" ;
            //cbEmployes.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GlobalLogin.username  = txtUserName.Text;
            

                    if (LoginBL.LoginWithUserNameAndPassWord(txtUserName.Text, txtPassWord.Text))
                    {
                        frmDashBoard1 frm = new frmDashBoard1();
                       

                        frm.ShowDialog();
                    }
                   

                else
                    MessageBox.Show("You have choise one speciality in the list Above");
                   
             
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
