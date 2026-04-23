using System;
using System.Windows.Forms;
using DTO_Framwork;
using BL_Framwork;
using ProjectDentiste.MainForm;
using System.Linq;



namespace ProjectDentiste
{
    public partial class frmAddUpdateDentist : Form
    {
       
        int DentistID = -1;
        string FullName = " ";
        DentistDTO dto;
        PersonDTO person;


        public frmAddUpdateDentist(int dentistID)
        {
            InitializeComponent();
            DentistID = dentistID;
           
           
        }
        public frmAddUpdateDentist(string fullName)
        {
            InitializeComponent();
            FullName = fullName;


        }



        public frmAddUpdateDentist()
        {
            InitializeComponent();
            txtDentistID.Enabled = false;
        }
        


        private void btnSave_Click(object sender, EventArgs e)
        {
            if(DentistID < 0)
            {
                lblTitre.Text = "Add Dentist";
                 person = new PersonDTO()
                {
                    NationalNumber= ctrlPersonInfo1.txtNationalNumber.Text,
                    FirstName = ctrlPersonInfo1.txtFirstName.Text,
                    LastName = ctrlPersonInfo1.txtLastName.Text,
                    DateOfBirth = ctrlPersonInfo1.dtDateOfBirth.Value,
                    Phone = ctrlPersonInfo1.txtPhone.Text,
                    Email = ctrlPersonInfo1.txtEmail.Text,
                    Adresse = ctrlPersonInfo1.txtAddress.Text,
                    Image = ctrlPersonInfo1.MypbImage.ImageLocation


                };
                

                DentistDTO dentist = new DentistDTO()
                {
                    Specialisation = txtSpecialization.Text,
                    CreatedAT= dtCreatedAT.Value,

                };

                EmployeDTO employe = new EmployeDTO()
                {
                   

                };


                DentistBL D = new DentistBL(person, dentist,employe);
               if (D.Save())
                {
                    MessageBox.Show("Dentist Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDashBoard1 frm = Application.OpenForms.OfType<frmDashBoard1>().First();
                    frm.dgvListDentists.DataSource = DentistBL.GetAllDentists();
                    frm.Show();

                }
               else
                {
                    MessageBox.Show("Dentist Not Added ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else if (DentistID >0)
            {
                lblTitre.Text = "Updated Dentist";

                
                PersonDTO person = new PersonDTO()
                {
                    PersonID= Convert.ToInt32(ctrlPersonInfo1.txtPersonID.Text),
                    NationalNumber = ctrlPersonInfo1.txtNationalNumber.Text,
                    FirstName = ctrlPersonInfo1.txtFirstName.Text,
                    LastName = ctrlPersonInfo1.txtLastName.Text,
                    DateOfBirth = ctrlPersonInfo1.dtDateOfBirth.Value,
                    Phone = ctrlPersonInfo1.txtPhone.Text,
                    Email = ctrlPersonInfo1.txtEmail.Text,
                    Adresse = ctrlPersonInfo1.txtAddress.Text,
                    Image = ctrlPersonInfo1.MypbImage.ImageLocation


                };


                DentistDTO dentist = new DentistDTO()
                {
                    Specialisation = txtSpecialization.Text,
                    CreatedAT = dtCreatedAT.Value,

                };
               

                DentistBL D = new DentistBL(person, dentist);
               
                if (D.Save())
                {
                    
                    MessageBox.Show("Dentist Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDashBoard1 frm = Application.OpenForms.OfType<frmDashBoard1>().First();
                    frm.dgvListDentists.DataSource = DentistBL.GetAllDentists();
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Dentist Not Updated ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }





        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void LoadDentistInfo()
        {
            if (DentistID < 0)
            {
                lblTitre.Text = "Add New Dentist";
                frmAddUpdateDentist frm = new frmAddUpdateDentist();
                frm.ShowDialog();
                
               

            }
            else
            {
                lblTitre.Text = "Update Dentist";
               var d= DentistBL.FindDentistProfile(DentistID);

                var f= PersonBL.FindPersonByID(d.person.PersonID);

                ctrlPersonInfo1.LoadPersonInfo(f);
                txtDentistID.Text = d.dentist.DentistID.ToString();
                txtSpecialization.Text = d.dentist.Specialisation.ToString();
                //dtCreatedAT.Text = d.dentist.CreatedAT;


            }


        }
        private void frmAddUpdateDentist_Load(object sender, EventArgs e)
        {
            
            //LoadDentistInfo();
        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
