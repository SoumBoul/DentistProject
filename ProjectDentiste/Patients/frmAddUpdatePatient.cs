
using System;
using System.Windows.Forms;
using System.Data;
using DTO_Framwork;
using BL_Framwork;
using ProjectDentiste.MainForm;
using System.Linq;
using ProjectDentiste.Appointments;
using ProjectDentiste.Allergies;
using System.Collections.Generic;

namespace ProjectDentiste.Patients
{
    public partial class frmAddUpdatePatient : Form
    {
        private List<AllergyDto> _Allergy = new List<AllergyDto>() ;
        private PatientRegistrationDto dto = new PatientRegistrationDto();
        PersonDTO person;


        MutuellDTO mutuelle;
        private PersonBL _person;
        private PatientBL _patient;
        private int _personId;
        private string FullName;

        public AllergyDto all = new AllergyDto();
        public string _FirstName { get; set; }
        public string FirstName
        {
            get { return ctrlPersonInfo1.txtFirstName.Text; }
        }
       
        public frmAddUpdatePatient(int personId)
        {
            InitializeComponent();
            _personId = personId;
            //LoadMedicalRecords();
        }
        public frmAddUpdatePatient()
        {
            InitializeComponent();

        }
        public frmAddUpdatePatient(string fullName)
        {
            InitializeComponent();
            FullName = fullName;

        }
       
        public int PatientID
        {
            get { return _personId; }

        }
        public int PersonID
        {
            get { return Convert.ToInt32(ctrlPersonInfo1.txtPersonID.Text); }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        string ListOfAllergyInString = " ";

        public void  LoadMedicalRecords()
        {
          
           
        }
        void AddPatient()
        {
             person = new PersonDTO
            {
                NationalNumber = ctrlPersonInfo1.txtNationalNumber.Text,
                FirstName = ctrlPersonInfo1.txtFirstName.Text,
                LastName = ctrlPersonInfo1.txtLastName.Text,
                DateOfBirth = ctrlPersonInfo1.dtDateOfBirth.Value,
                Phone = ctrlPersonInfo1.txtPhone.Text,
                Email = ctrlPersonInfo1.txtEmail.Text,
                Adresse = ctrlPersonInfo1.txtAddress.Text,
                Image = ctrlPersonInfo1.MypbImage.ImageLocation
            };

            PatientDTO patient = new PatientDTO
            {

                NumeroDeDossier = cntrPatient1.txtNumeroDeDossier.Text,
                DateDeCreation = DateTime.Now,
                NoteGenerale = cntrPatient1.txtNoteGenerale.Text,
                DentistID = Convert.ToInt32(cntrPatient1.txtDentistID.Text),

            };

            if (cntrMutuelleInfo1.txtNumeroAdherent.Text == "")
            {

            }
            else
            {
                mutuelle = new MutuellDTO
                {
                    //PatientID= Convert.ToInt32(cntrMutuelleInfo1.txtPatientID.Text),
                    NumeroAdherent = cntrMutuelleInfo1.txtNumeroAdherent.Text,
                    DateDebut = cntrMutuelleInfo1.DateDebut.Value,
                    DateFin = cntrMutuelleInfo1.DateFin.Value,
                    NiveauCouverture = cntrMutuelleInfo1.txtNiveauCouverture.Text,
                    MutuelleCompagnieID = Convert.ToInt32(cntrMutuelleInfo1.txtMutuelleCompagnieID.Text),


                };


            }
            _Allergy = cntrMedicalRecords1.Allergies;

            ListOfAllergyInString = string.Join(",", _Allergy.Select(x => x.AllergieName));
            MedicalRecordDTO medicalRecord = new MedicalRecordDTO
            {

                MedicalRecordNumber = cntrMedicalRecords1.txtMedicalRecord.Text,
                MedicalHistory = cntrMedicalRecords1.txtMedicalHistory.Text,
                CurrentMedicaments = cntrMedicalRecords1.txtCurrentMedications.Text,
                Notes = cntrMedicalRecords1.txtNotes.Text,
                Allergies = ListOfAllergyInString,



            };


            PatientBL p = new PatientBL(person, patient, mutuelle, medicalRecord, _Allergy);
            if (p.Save())
            {
                ctrlPersonInfo1.txtPersonID.Text = patient.PersonID.ToString();
                DialogResult result = MessageBox.Show("the Patient Saved Successfully, Do you want Take An Appointment?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              
                if (result == DialogResult.Yes)
                {
                    if (!string.IsNullOrWhiteSpace(ctrlPersonInfo1.txtFirstName.Text) && !string.IsNullOrWhiteSpace(ctrlPersonInfo1.txtLastName.Text))
                    {
                        frmTakeAppointments take = new frmTakeAppointments(FullName);
                        take.ShowDialog();
                    }

                }

                frmDashBoard1 frm = Application.OpenForms.OfType<frmDashBoard1>().First();
                frm.dgvListPatients.DataSource = PatientBL.GetListPatients();

            }

        
        }
        void UpdatePatient()
        {

            PersonDTO person = new PersonDTO
            {
                PersonID = Convert.ToInt32(ctrlPersonInfo1.txtPersonID.Text),
                NationalNumber = ctrlPersonInfo1.txtNationalNumber.Text,
                FirstName = ctrlPersonInfo1.txtFirstName.Text,
                LastName = ctrlPersonInfo1.txtLastName.Text,
                DateOfBirth = ctrlPersonInfo1.dtDateOfBirth.Value,
                Phone = ctrlPersonInfo1.txtPhone.Text,
                Email = ctrlPersonInfo1.txtEmail.Text,
                Adresse = ctrlPersonInfo1.txtAddress.Text,
                Image = ctrlPersonInfo1.MypbImage.ImageLocation
            };

          
            PatientDTO patient = new PatientDTO
            {
                PatientID = PatientID,
                NumeroDeDossier = cntrPatient1.txtNumeroDeDossier.Text,
                DateDeCreation = cntrPatient1.DateDeCreation.Value,
                NoteGenerale = cntrPatient1.txtNoteGenerale.Text,
                DentistID = Convert.ToInt32(cntrPatient1.txtDentistID.Text),

            };


            MutuellDTO mutuelle = new MutuellDTO
            {
                PatientID = Convert.ToInt32(cntrMutuelleInfo1.txtPatientID.Text),

                MutuelleID = Convert.ToInt32(cntrMutuelleInfo1.txtMutuelleID.Text),
                NumeroAdherent = cntrMutuelleInfo1.txtNumeroAdherent.Text,
                DateDebut = cntrMutuelleInfo1.DateDebut.Value,
                DateFin = cntrMutuelleInfo1.DateFin.Value,
                NiveauCouverture = cntrMutuelleInfo1.txtNiveauCouverture.Text,
                MutuelleCompagnieID = Convert.ToInt32(cntrMutuelleInfo1.txtMutuelleCompagnieID.Text),

            }; 
            MedicalRecordDTO medicalRecord = new MedicalRecordDTO
            {

                MedicalRecordNumber = cntrMedicalRecords1.txtMedicalRecord.Text,
                MedicalHistory = cntrMedicalRecords1.txtMedicalHistory.Text,
                CurrentMedicaments = cntrMedicalRecords1.txtCurrentMedications.Text,
                Notes = cntrMedicalRecords1.txtNotes.Text,
                Allergies = ListOfAllergyInString,
                RecordID = Convert.ToInt32(cntrMedicalRecords1.txtRecordID.Text),
            };

            _Allergy = cntrMedicalRecords1.Allergies;
            ListOfAllergyInString = string.Join(",", _Allergy.Select(x => x.AllergieName));

            foreach (var item in _Allergy)
            {
                AllergyDto allergy = new AllergyDto()
                {
                    AllergieName= item.AllergieName,
                    EmployeID= item.EmployeID,
                    DateAdded=item.DateAdded,

                };

            }
           




            var p = PatientBL.UpdatePatientWithTransaction(person, patient, mutuelle, medicalRecord, _Allergy);

            if (p == true)
            {
                MessageBox.Show("the Patient Updated Successfully");
                frmDashBoard1 frm = Application.OpenForms.OfType<frmDashBoard1>().First();
                frm.dgvListPatients.DataSource = PatientBL.GetListPatients();
            }
            else

                MessageBox.Show("the Patient Not Updated ");
           
        }
       
        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {
            LoadPatientInfo();
        }
        public void LoadPatientInfo()
        {
            if (_personId <= 0)
            {
                frmAddUpdatePatient frm = new frmAddUpdatePatient();
                frm.lbtTitre.Text = "Add Patient";
                return;
            }
            else
            {
                dto = PatientBL.GetFullPatientProfile(PatientID);
                lbtTitre.Text = "Update Patient";

                ctrlPersonInfo1.LoadPersonInfo(dto.person);
                cntrPatient1.LoadPatientInfo(dto.patient);
                cntrMutuelleInfo1.LoadMutuelleInfo(dto.mutuelle);
                cntrMedicalRecords1.LoadMedicalRecords(dto.medicalRecordDto);

            }

        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {


            if (ctrlPersonInfo1.txtFirstName.Text != null && ctrlPersonInfo1.txtLastName.Text != null)
            {
                frmTakeAppointments frm = new frmTakeAppointments(FullName);
                frm.ShowDialog();
            }


        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbHasMutuelle.Checked)
            {
                tabcontro1.SelectedTab = tabcontro1.TabPages["Mutuelle"];

            }
            else if (rbHasMutuelle.Checked == false)
                btnNext.Enabled = false;
        }
        private void rbHasMutuelle_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
        }
        private void rbDontHaveMutuelle_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_personId <= 0)
                AddPatient();
            else
                UpdatePatient();

        }
    }
}
