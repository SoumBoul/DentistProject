
using System;
using System.Windows.Forms;
using BL_Framwork;
using DTO_Framwork;
using ProjectDentiste.Properties;

namespace ProjectDentiste.Personnes
{
    public partial class ctrlPersonInfo : UserControl
    {


        int PersonID=-1;
        
        PersonDTO _person;
        public ctrlPersonInfo(int personId)
        {
            InitializeComponent();
            PersonID = personId;
           
        }
        public ctrlPersonInfo()
        {
            InitializeComponent();
            
        }
        public int personID
        {
            get { return PersonID; }
           
        }

        public string FirstName
        {
            get { return txtFirstName.Text; }

        }
        public string LastName
        {
            get { return txtLastName.Text; }

        }

        public PersonDTO Person
        {
            get { return _person; }
            set
            {
                _person = value;
            }
        }

        public void LoadImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MypbImage.ImageLocation = ofd.FileName;
            }
            

        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            LoadImage();

        }

        public void LoadPersonInfo(PersonDTO person)
        {
            _person = person;
            if (person ==null || person.PersonID<=0)
            {
                return;
            }

           else if (person != null)
            {
                txtPersonID.Text = person.PersonID.ToString();
                txtNationalNumber.Text = person.NationalNumber.ToString();
                txtFirstName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                dtDateOfBirth.Text = person.DateOfBirth.ToString();
                txtPhone.Text = person.Phone;
                txtEmail.Text = person.Email;
                txtAddress.Text = person.Adresse;
                if (person.Image != " ")
                {
                    MypbImage.ImageLocation = person.Image;
                }
                else

                    MypbImage.Image = Resources.Aucune_image_disponible;

            }

        }

     

        private void linkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
                frmPersonInfo frm = new frmPersonInfo(_person.PersonID);
               
                frm.ShowDialog();
            
        }

        private void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProviderPerson.SetError(txtFirstName, "The first name have to be mentioned");
                txtFirstName.Focus();
            }
            else
                errorProviderPerson.SetError(txtFirstName,"");


        }
        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProviderPerson.SetError(txtLastName, "The Last name have to be mentioned");
                txtLastName.Focus();
            }
            else
                errorProviderPerson.SetError(txtLastName, "");

        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProviderPerson.SetError(txtEmail, "The Email have to be mentioned");
                txtEmail.Focus();
            }
            else
                errorProviderPerson.SetError(txtEmail, "");
        }

        private void txtAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProviderPerson.SetError(txtAddress, "The first name have to be mentioned");
                txtAddress.Focus();
            }
            else
                errorProviderPerson.SetError(txtAddress, "");
        }

        private void txtPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProviderPerson.SetError(txtPhone, "The Phone number have to be mentioned");
                txtPhone.Focus();
            }
            else
                errorProviderPerson.SetError(txtPhone, "");
        }

        private void txtNationalNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(PersonBL.IsNationalNumberExist(txtNationalNumber.Text))
            {
                MessageBox.Show("This Person is already exist", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNationalNumber.Focus();
               
            }
           

        }

        private void ctrlPersonInfo_Load(object sender, EventArgs e)
        {

        }
    }

}
