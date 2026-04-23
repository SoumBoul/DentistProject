
using System;
using System.Windows.Forms;
using DTO_Framwork;
using BL_Framwork;


namespace ProjectDentiste.Patients.Controles
{
    public partial class cntrPatient : UserControl
    {
        public int _patientId = -1;

        public PatientDTO pationDTO = new PatientDTO();
        public cntrPatient()
        {
            InitializeComponent();
            DateDeCreation.Text = DateTime.Now.ToString();
        }

        public cntrPatient(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
            
        }

      
        public void LoadPatientInfo(PatientDTO patient)
        {
            if(patient==null)
            {
                return;
            }
            
            patient = PatientBL.GetPatientProfile(patient.PatientID);
            if (patient != null)
            {
                txtNumeroDeDossier.Text = patient.NumeroDeDossier;
                txtNoteGenerale.Text = patient.NoteGenerale;
                txtDentistID.Text = patient.DentistID.ToString();
                DateDeCreation.Text = DateTime.Now.ToString();
            }

        }
        private void txtNumeroDeDossier_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroDeDossier.Text))
            {
                errorProviderPatient.SetError(txtNumeroDeDossier,"you should fill this blank");
                txtNumeroDeDossier.Focus();
            }
            else
                errorProviderPatient.SetError(txtNumeroDeDossier, "");
        }
        
        private void txtDentistID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDentistID.Text))
            {
                errorProviderPatient.SetError(txtDentistID, "you should fill this blank");
                txtDentistID.Focus();
            }
            else
                errorProviderPatient.SetError(txtDentistID, "");

        }

      
        private void txtDentistID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // autorise seulement chiffres + backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // bloque le caractère
            }
        }

     
    }
}
