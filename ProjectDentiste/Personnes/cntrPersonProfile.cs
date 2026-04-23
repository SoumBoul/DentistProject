using DTO_Framwork;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BL_Framwork;
using ProjectDentiste.Properties;
using ProjectDentiste.MainForm;
using System.Linq;
using System.Data;
using ProjectDentiste.MedicalRecord;

namespace ProjectDentiste.Personnes
{
   
    public partial class cntrPersonProfile : UserControl
    {
        
        
      

        int personID =-1;
        PersonDTO _person;
       
        public cntrPersonProfile()
        {
            InitializeComponent();
        }
        

      


        public void FindNow()
        {
            

            switch (cbFilterBy.Text.Trim())
            {
                
                case "FullName":

                   
                    _person = PersonBL.FindPersonByFullName(txtSearsh.Text.Trim());
                    LoadPersonInfo(_person);
                  
                    var dt = MedicalRecordBL.GetMedicalRecordByFullName(txtSearsh.Text.Trim());
                  
                   
                    
               
                    break;

                case "Phone":

                    _person = PersonBL.FindPatientWithPhone(txtSearsh.Text.Trim());
                    LoadPersonInfo(_person);
                    break;

                default:

                   //// frm.dgMedicalRecords.DataSource = MedicalRecordBL.GetAllMedicalRecords();
                    break;

                    

            }
        }
        public void LoadPersonInfo(PersonDTO person)
        {
            _person = person;
            if (person == null || person.PersonID <= 0)
            {
                return;
            }

            else if (person != null)
            {
               
                lblFullName.Text = person.FirstName + " " + person.LastName;
                
                lblDateOfBirth.Text = person.DateOfBirth.ToString();
                lblPhone.Text = person.Phone;
                lblEmail.Text = person.Email;

                if (person.Image != "")
                {
                    MypbImage.ImageLocation = person.Image;
                }
                else

                    MypbImage.Image = Resources.Aucune_image_disponible; 

            }

        }   
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FindNow();
            

        }

        private void cntrPersonProfile_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
        }
    }
}
