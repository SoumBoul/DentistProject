using System;
using System.Windows.Forms;
using BL_Framwork;
using DTO_Framwork;
using ProjectDentiste.MainForm;

namespace ProjectDentiste.Payment
{
    public partial class frmPayment : Form
    {
        PatientPaymentInfoDTO _PatientPaymentDto;
        frmDashBoard1 frm = new frmDashBoard1();
        public frmPayment()
        {
            InitializeComponent();
        }

        public frmPayment(PatientPaymentInfoDTO patientPaymentDto)
        {
            InitializeComponent();
            _PatientPaymentDto = patientPaymentDto;
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lblAppointmentID.Text = _PatientPaymentDto.RdvID.ToString(); 
            lblPatientName.Text = _PatientPaymentDto.PatientFullName;
            lblDentistName.Text= _PatientPaymentDto.DentistName;
            lblAppointmentDate.Text = _PatientPaymentDto.AppointmentDate.ToString();
            lblDateInvoice.Text = DateTime.Now.ToString();
            cbPaymentMethode.SelectedItem = "Card";
            //cbPaymentStatus.SelectedItem = "Paid";
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InvoiceDTO invoiceDto = new InvoiceDTO
            {
                Montant = Convert.ToInt32(txtMontant.Text),
                Taxe = Convert.ToDecimal(txtTaxe.Text),
                MutuelleID =1 ,
                RdvID = _PatientPaymentDto.RdvID,
                InvoiceStatusID = int.Parse(cbPaymentMethode.SelectedIndex.ToString()),
               

            };

            var updateAppointmentStatus = AppointmentBL.UpdateStatusAppointment(invoiceDto.RdvID);
            InvoiceBL p = new InvoiceBL(invoiceDto);
            
            if(p.Save() && updateAppointmentStatus==true)
            {
                MessageBox.Show("The Invoice Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("The Invoice NOT Added ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);




        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            decimal reminder = decimal.Parse(txtMontant.Text) - decimal.Parse(txtAmount.Text);
            txtReminded.Text = reminder.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void llTotalAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
