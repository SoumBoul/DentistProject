using BL_Framwork;
using DTO_Framwork;
using ProjectDentiste.Allergies;
using ProjectDentiste.MainForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectDentiste.MedicalRecord.Contols
{
    public partial class cntrMedicalRecord : UserControl
    {
        string FullName = "";
        public frmAllergies allergie = new frmAllergies();
        frmAllergies allergy = new frmAllergies();
        frmDashBoard1 patients = new frmDashBoard1();

        public List<MedicalRecordDTO> mr = new List<MedicalRecordDTO>();
        public cntrMedicalRecord()
        {
            InitializeComponent();
        }
        public cntrMedicalRecord(string fullname)
        {
            InitializeComponent();
            this.FullName = fullname;
        }

        private void btnAllergies_Click(object sender, EventArgs e)
        {
            if(allergie==null)
            {
                allergie = new frmAllergies();
                allergie.ShowDialog();
                return;
            }
            else
            {
                frmAllergies frm = new frmAllergies();
                frm.txtAllergyName.Text = mr[0].Allergies;
                frm.txtEmplyeID.Text = GlobalLogin.username;
                //frm.dgGetAllAlergies = AllergieBL.
                frm.ShowDialog();
            }

        }

        private void cntrMedicalRecord_Load(object sender, EventArgs e)
        {
            if(FullName == null)
            {
                return;
            }
            else
            {
               mr = MedicalRecordBL.GetMedicalRecordByFullName(patients.FullName);

                if(mr.Count>0)
                {


                    txtMedicalRecord.Text = mr[0].MedicalRecordNumber;
                    txtMedicalHistory.Text = mr[0].MedicalHistory;
                    txtCurrentMedications.Text = mr[0].CurrentMedicaments;
                    txtNotes.Text = mr[0].Notes;
                    allergy.txtAllergyName.Text = mr[0].Allergies;
                   

                   

                }
               

            }



        }
    }
}
