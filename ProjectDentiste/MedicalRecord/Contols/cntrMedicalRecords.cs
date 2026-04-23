using BL_Framwork;
using DTO_Framwork;
using ProjectDentiste.Allergies;
using ProjectDentiste.MainForm;
using ProjectDentiste.Personnes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectDentiste.MedicalRecord.Contols
{
    public partial class cntrMedicalRecords : UserControl
    {
        public List<AllergyDto> Allergies { get; private set; } = new List<AllergyDto>();
        
        public MedicalRecordDTO medical { get; set; }
        PatientRegistrationDto dto= new PatientRegistrationDto();
        AllergyDto allergy { get; set; }

        public int _RecordID = -1;
        public cntrMedicalRecords()
        {
            InitializeComponent();
        }
        string FullName = "";

        

        public cntrMedicalRecords(string fullname)
        {
            InitializeComponent();
            this.FullName = fullname;
        }
        
        
        private void btnAllergies_Click(object sender, EventArgs e)
        {
            

        }
       
        public void LoadMedicalRecords(MedicalRecordDTO medicalRecordDto)
        {

            if (medicalRecordDto.MedicalRecordNumber == null)
                return;
            else
            {
                {
                    //medicalRecordDto = MedicalRecordBL.GetMedicalRecordByFullName(medicalRecordDto.FullName);

                    if (medicalRecordDto != null )
                    {
                        txtMedicalRecord.Text = medicalRecordDto.MedicalRecordNumber;
                        txtMedicalHistory.Text = medicalRecordDto.MedicalHistory;
                        txtCurrentMedications.Text = medicalRecordDto.CurrentMedicaments;
                        txtNotes.Text = medicalRecordDto.Notes;
                        txtRecordID.Text = medicalRecordDto.RecordID.ToString();

                    }
                }
            }
            _RecordID= Convert.ToInt32(txtRecordID.Text = medicalRecordDto.RecordID.ToString());
            

        }
        private void cntrMedicalRecord_Load(object sender, EventArgs e)
        {
            LoadMedicalRecords(medical);

        }
        private void btnAllergies_Click_2(object sender, EventArgs e)
        {
            if(txtRecordID.Text == "")
            {
                frmAllergies _allergy = new frmAllergies();
                List<MedicalRecordDTO> mr = new List<MedicalRecordDTO>();
                if (allergy == null)
                {
                    _allergy = new frmAllergies();
                    _allergy.ShowDialog();
                    return;
                }
                else
                {

                    _allergy.txtAllergyName.Text = mr[0].Allergies;
                    _allergy.txtEmplyeID.Text = GlobalLogin.username;

                    _allergy.ShowDialog();
                }

            }
           
             else
            {
                int id = Convert.ToInt32(txtRecordID.Text);
                var aller = AllergieBL.FindAllergieByRecordID(id);
                frmAllergies frm = new frmAllergies(aller);

                foreach (var item in aller)
                {
                    frm.txtAllergyName.Text = item.AllergieName;
                    frm.txtEmplyeID.Text = item.EmployeID.ToString();
                    frm.dgGetAllAlergies.DataSource = AllergieBL.FindAllergieByRecordID(item.RecordID);
                }

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Allergies = frm.GetAllergies;
                }


            }
           


        }

        private void cntrMedicalRecords_Load(object sender, EventArgs e)
        {
            
        }
    }
}
