using System.Windows.Forms;
using BL_Framwork;
using DTO_Framwork;

namespace ProjectDentiste.Mutuelle
{
    public partial class cntrMutuelleInfo : UserControl
    {
        private int PatientID=-1;
        public cntrMutuelleInfo()
        {
            InitializeComponent();
        }

        public cntrMutuelleInfo(int patientID)
        {
            InitializeComponent();
            PatientID = patientID;
        }

        public void LoadMutuelleInfo(MutuellDTO mutuelle)
        {

            if(mutuelle.PatientID== -1)
            {
                return;
            }
            mutuelle = MutuelleBL.FindMutuelleByPatientID(mutuelle.PatientID);
            if(mutuelle!=null)
            {
                txtMutuelleID.Text = mutuelle.MutuelleID.ToString();
                txtNumeroAdherent.Text = mutuelle.NumeroAdherent;
                DateDebut.Text = mutuelle.DateDebut.ToString();
                DateFin.Text = mutuelle.DateFin.ToString();
                txtNiveauCouverture.Text = mutuelle.NiveauCouverture;
                txtPatientID.Text = mutuelle.PatientID.ToString();
                txtMutuelleCompagnieID.Text = mutuelle.MutuelleCompagnieID.ToString();
                



            }




        }

        private void cntrMutuelleInfo_Load(object sender, System.EventArgs e)
        {

        }

        private void txtNumeroAdherent_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroAdherent.Text))
            {
                errorProviderMutuelle.SetError(txtNumeroAdherent, "you should fill this blank");
                txtNumeroAdherent.Focus();
            }
            else
                errorProviderMutuelle.SetError(txtNumeroAdherent, "");
        }

        private void txtMutuelleCompagnieID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMutuelleCompagnieID.Text))
            {
                errorProviderMutuelle.SetError(txtMutuelleCompagnieID, "you should fill this blank");
                txtMutuelleCompagnieID.Focus();

            }
            else
                errorProviderMutuelle.SetError(txtMutuelleCompagnieID, "");
        }

        private void DateDebut_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DateDebut.Text))
            {
                errorProviderMutuelle.SetError(DateDebut, "you should to fill this date, is mondetory");
                DateDebut.Focus();
            }
            else
                errorProviderMutuelle.SetError(DateDebut, "");
        }

        private void DateFin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DateFin.Text))
            {
                errorProviderMutuelle.SetError(DateFin, "you should fill this date");
                DateFin.Focus();

            }
            else
                errorProviderMutuelle.SetError(DateFin, "");

        }

        private void txtMutuelleCompagnieID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // autorise seulement chiffres + backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // bloque le caractère
            }
        }
    }
}
