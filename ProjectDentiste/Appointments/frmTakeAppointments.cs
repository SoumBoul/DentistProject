using ProjectDentiste.Properties;
using System;
using System.Collections.Generic;

using System.IO;
using System.Drawing;

using System.Windows.Forms;
using BL_Framwork;
using DTO_Framwork;

using ProjectDentiste.MainForm;
using System.Linq;
using ProjectDentiste.Patients;
using ProjectDentiste.Personnes;
using ProjectDentiste.Patients.Controles;
using System.Diagnostics.Eventing.Reader;


namespace ProjectDentiste.Appointments
{
    public partial class frmTakeAppointments : Form
    {
        
        DateTime dateSelected;
        string FullName = " ";
        DateTime Date;
        int ID = -1;
        PatientAppointmentInfoDto _PatientInfoDto;
        PersonDTO _person { get; set; }

        frmDashBoard1 frm = Application.OpenForms.OfType<frmDashBoard1>().FirstOrDefault();
        frmListPatients patients = Application.OpenForms.OfType<frmListPatients>().FirstOrDefault();
        frmAddUpdatePatient newPatient = Application.OpenForms.OfType<frmAddUpdatePatient>().FirstOrDefault();
        frmTakeAppointments takeDentist = Application.OpenForms.OfType<frmTakeAppointments>().FirstOrDefault();

        public frmTakeAppointments()
        {
            InitializeComponent();
            generateTime();
           
            lblPatientName.Text = patients.dgListPatientsForAppointment.CurrentRow.Cells["FullName"].Value.ToString();
            lblPatientPhone.Text= patients.dgListPatientsForAppointment.CurrentRow.Cells["Telephone"].Value.ToString();
        }
        public frmTakeAppointments(string fullname)
        {
            InitializeComponent();
           
            FullName = fullname;
            lblPatientName.Text = newPatient.ctrlPersonInfo1.txtFirstName.Text + " " + newPatient.ctrlPersonInfo1.txtLastName.Text;
            lblPatientPhone.Text = newPatient.ctrlPersonInfo1.txtPhone.Text;
          
            generateTime();
        }
        public frmTakeAppointments(DateTime AppointmentDate)
        {
            InitializeComponent();
            generateTime();
            Date = AppointmentDate;

            lblPatientName.Text = frm.dgShowAllApointments.CurrentRow.Cells["FullName"].Value.ToString();
            var patient = PersonBL.FindPersonByFullName(lblPatientName.Text);
            lblPatientPhone.Text = patient.Phone;

            //lblPatientPhone.Text = frm.dgShowAllApointments.CurrentRow.Cells["Telephone"].Value.ToString() != null ?
            //   frm.dgShowAllApointments.CurrentRow.Cells["Telephone"].Value.ToString() : " ";


        }

        public frmTakeAppointments(int id)
        {
            InitializeComponent();
            generateTime();
            ID = id;
            if (patients != null && patients.dgListPatientsForAppointment.Rows.Count > 0)
            {
                lblPatientName.Text = patients.dgListPatientsForAppointment.CurrentRow.Cells["FullName"].Value.ToString() != null ?
               patients.dgListPatientsForAppointment.CurrentRow.Cells["FullName"].Value.ToString() : " ";
                lblPatientPhone.Text = patients.dgListPatientsForAppointment.CurrentRow.Cells["Telephone"].Value.ToString() != null ?
                   patients.dgListPatientsForAppointment.CurrentRow.Cells["Telephone"].Value.ToString() : " ";
            }
            if (ID > 0 && frm.dgvListPatients.Rows.Count > 0)
            {
                lblPatientName.Text = frm.dgvListPatients.CurrentRow.Cells["FullName"].Value.ToString() != null ?
              frm.dgvListPatients.CurrentRow.Cells["FullName"].Value.ToString() : " ";
                lblPatientPhone.Text = frm.dgvListPatients.CurrentRow.Cells["Telephone"].Value.ToString() != null ?
                   frm.dgvListPatients.CurrentRow.Cells["Telephone"].Value.ToString() : " ";
            }


        }

        public frmTakeAppointments(PatientAppointmentInfoDto patientInfoDto)
        {
            InitializeComponent();
            generateTime();
            _PatientInfoDto = patientInfoDto;
            if (_PatientInfoDto!=null)
            {
                lblPatientName.Text = patientInfoDto.FullName;
                lblPatientPhone.Text = patientInfoDto.Phone;
            }
           
        }
        public void RefreshAppointmentsTable()
        {
            frm.dgShowAllApointments.DataSource = AppointmentBL.GetAllApointments();

        }
        private void generateTime()
        {
            for (int i = 8; i <= 19; i++)
            {
                cbStartTime.Items.Add(i + ":00");
            }
            cbStartTime.SelectedIndex = 0;
           
            
        }
        private void frmTakeAppointments_Load(object sender, EventArgs e)
        {
           
            dgAppointmentsListDentists.DataSource = BL_Framwork.DentistBL.GetInfoDentistsForAppointments();
            if (dgAppointmentsListDentists.Columns.Count > 0)
            {

                dgAppointmentsListDentists.Columns["FullName"].HeaderText = " FullName";
                dgAppointmentsListDentists.Columns["Email"].Visible = false;
                dgAppointmentsListDentists.Columns["DentistID"].Visible = false;
                dgAppointmentsListDentists.Columns["PersonID"].Visible = false;
                dgAppointmentsListDentists.Columns["CreatedAT"].Visible = false;
                dgAppointmentsListDentists.Columns["Phone"].Visible = false;
                dgAppointmentsListDentists.Columns["Image"].Visible = false;

                if (!dgAppointmentsListDentists.Columns.Contains("Photo"))
                {
                    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                    imageColumn.Name = "Photo";
                    imageColumn.HeaderText = "Photo";
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imageColumn.Width = 70;

                    dgAppointmentsListDentists.Columns.Insert(0, imageColumn);
                }

            }
          


        }
        private void dgAppointmentsListDentists_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgAppointmentsListDentists.Columns[e.ColumnIndex].Name == "Photo")
            {
                var path = dgAppointmentsListDentists.Rows[e.RowIndex].Cells["Image"].Value?.ToString();

                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    using (var image = Image.FromFile(path))
                    {
                        e.Value = new Bitmap(image);
                    }
                }
            }

        }      
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ID>0)
            {
                if (frm == null || frm.dgvListPatients.CurrentRow == null)
                    return;

                DateTime rdvDate = dateSelected.Date;

                TimeSpan startTime = TimeSpan.Parse(cbStartTime.Text);
                TimeSpan endTime = TimeSpan.Parse(txtEndTime.Text);

                AppointmentDTO dto = new AppointmentDTO()
                {
                    RdvDate = rdvDate,
                    NewStart = startTime,
                    NewEnd = endTime,
                    Status = cbStatus.Text,
                    PatientID = Convert.ToInt32(patients.dgListPatientsForAppointment.CurrentRow.Cells["PatientID"].Value),
                    DentistID = DentistBL.FindDentistWithName(dgAppointmentsListDentists.CurrentRow.Cells["FullName"].Value.ToString())
                };


                AppointmentBL bl = new AppointmentBL(dto);
                if (bl.Save())
                {
                    MessageBox.Show("The Appointment Saved Saccessfully");
                   
                }
                else
                {
                    MessageBox.Show("The Appointment NOT Saved");
                }



            }
            else if(_PatientInfoDto !=null)
            {
                if (_PatientInfoDto.FullName == null && _PatientInfoDto.Phone == null)
                    return;

                DateTime rdvDate = dateSelected.Date;

                TimeSpan startTime = TimeSpan.Parse(cbStartTime.Text);
                TimeSpan endTime = TimeSpan.Parse(txtEndTime.Text);
                int patientID = _PatientInfoDto.PatientID;
                int DentistId = DentistBL.FindDentistWithName(lblDentistFullName.Text);

                AppointmentDTO dto = new AppointmentDTO()
                {
                    RdvDate = rdvDate,
                    NewStart = startTime,
                    NewEnd = endTime,
                    Status = cbStatus.Text,
                    PatientID = patientID,
                    DentistID = DentistId,
                };
              

                


                AppointmentBL bl = new AppointmentBL(dto);
                if (bl.Save())
                {
                    MessageBox.Show("The Appointment Saved Saccessfully");
                    
                }
                else
                {
                    MessageBox.Show("The Appointment NOT Saved");
                }

            }

            else
            {
                DateTime rdvDate = dateSelected.Date;

                TimeSpan startTime = TimeSpan.Parse(cbStartTime.Text);
                TimeSpan endTime = TimeSpan.Parse(txtEndTime.Text);
                int patientID = PatientBL.FindPatientIDbyPersonID(newPatient.PersonID);
                int DentistId = DentistBL.FindDentistWithName(lblDentistFullName.Text);

                AppointmentDTO dto = new AppointmentDTO()
                {
                    RdvDate = rdvDate,
                    NewStart = startTime,
                    NewEnd = endTime,
                    Status = cbStatus.Text,
                    PatientID = patientID,
                    DentistID = DentistId,
                };





                AppointmentBL bl = new AppointmentBL(dto);
                if (bl.Save())
                {
                    MessageBox.Show("The Appointment Saved Saccessfully");

                }
                else
                {
                    MessageBox.Show("The Appointment NOT Saved");
                }



            }

        }

        private void Calender_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateSelected = e.Start;
        }

        private void dgAppointmentsListDentists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDentistFullName.Text = dgAppointmentsListDentists.CurrentRow.Cells["FullName"].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            RefreshAppointmentsTable();
        }

        private void txtSearchDentist_TextChanged(object sender, EventArgs e)
        {
            switch (cbSearchDentist.Text)
            {

                case "DentistID":


                    dgAppointmentsListDentists.DataSource = string.IsNullOrWhiteSpace(txtSearchDentist.Text) ?
                    dgAppointmentsListDentists.DataSource = DentistBL.GetAllDentists() :
                    dgAppointmentsListDentists.DataSource = DentistBL.FilterDentistWithID(Convert.ToInt32(txtSearchDentist.Text));


                    dgAppointmentsListDentists.Show();
                    break;

                case "FullName":
                    List<DentistDTO> d = DentistBL.FilterDentistWithFullName(txtSearchDentist.Text);
                    dgAppointmentsListDentists.DataSource = d;
                    dgAppointmentsListDentists.Show();
                    break;

                case "Specialization":
                    List<DentistDTO> specialization = DentistBL.FilterDentistWithSpecialization(txtSearchDentist.Text);

                    dgAppointmentsListDentists.DataSource = specialization;
                    dgAppointmentsListDentists.Show();
                    break;
                case "Email":
                    List<DentistDTO> email = DentistBL.FilterDentistWithEmail(txtSearchDentist.Text);

                    dgAppointmentsListDentists.DataSource = email;
                    dgAppointmentsListDentists.Show();
                    break;

            }
        }

        private int GetCurrentPatientId()
        {
            // Cas 1 : PatientID déjà passé au formulaire
            if (ID > 0)
                return ID;

            // Cas 2 : Patient choisi depuis la grille
            if (patients != null &&
                patients.dgListPatientsForAppointment != null &&
                patients.dgListPatientsForAppointment.CurrentRow != null &&
                patients.dgListPatientsForAppointment.CurrentRow.Cells["PatientID"].Value != null &&
                patients.dgListPatientsForAppointment.CurrentRow.Cells["PatientID"].Value != DBNull.Value)
            {
                return Convert.ToInt32(
                    patients.dgListPatientsForAppointment.CurrentRow.Cells["PatientID"].Value);
            }

            // Cas 3 : Nouveau patient → on récupère via PersonID
            if (newPatient != null && newPatient.PersonID > 0)
            {
                return PatientBL.FindPatientIDbyPersonID(newPatient.PersonID);
            }
            if (frm != null &&(int) frm.dgShowAllApointments.CurrentRow.Cells[0].Value>0)
            {
                var p = PersonBL.FindPersonByFullName(frm.dgShowAllApointments.CurrentRow.Cells["FullName"].Value.ToString());
                 
                return PatientBL.FindPatientIDbyPersonID(p.PersonID);
            }

            return 0;
        }
        private int GetCurrentDentistId()
        {
            if (dgAppointmentsListDentists.CurrentRow == null)
                return 0;

            object value = dgAppointmentsListDentists.CurrentRow.Cells["FullName"].Value;

            if (value == null || value == DBNull.Value)
                return 0;

            return DentistBL.FindDentistWithName(value.ToString());
        }
        private void txtEndTime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEndTime.Text))
            {
                errorProviderAppointment.SetError(txtEndTime, "You should fill in the end time.");
                txtEndTime.Focus();
                return;
            }
            else
            {
                errorProviderAppointment.SetError(txtEndTime, "");
            }

            if (string.IsNullOrWhiteSpace(cbStartTime.Text))
            {
                MessageBox.Show("Please select a start time.");
                return;
            }

            if (dgAppointmentsListDentists.CurrentRow == null)
            {
                MessageBox.Show("Please select a dentist.");
                return;
            }

            int patientId = GetCurrentPatientId();
            if (patientId <= 0)
            {
                MessageBox.Show("No patient was found.");
                return;
            }

            int dentistId = GetCurrentDentistId();
            if (dentistId <= 0)
            {
                MessageBox.Show("No dentist was found.");
                return;
            }

            DateTime rdvDate = dateSelected.Date;
            TimeSpan startTime;
            TimeSpan endTime;

            if (!TimeSpan.TryParse(cbStartTime.Text, out startTime))
            {
                MessageBox.Show("Invalid start time.");
                return;
            }

            if (!TimeSpan.TryParse(txtEndTime.Text, out endTime))
            {
                MessageBox.Show("Invalid end time.");
                return;
            }

            if (endTime <= startTime)
            {
                MessageBox.Show("End time must be greater than start time.");
                return;
            }

            AppointmentDTO dto = new AppointmentDTO()
            {
                RdvDate = rdvDate,
                NewStart = startTime,
                NewEnd = endTime,
                Status = cbStatus.Text,
                PatientID = patientId,
                DentistID = dentistId
            };

            AppointmentBL bl = new AppointmentBL(dto);

            if (bl.isAppointmentIsValid())
            {
                MessageBox.Show("The selected time slot is not available. The dentist or the patient already has an appointment at this time.");
            }
            else
            {
                MessageBox.Show("The appointment is available.");
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {

            frmListPatients frm1 = new frmListPatients();
            frm1.ShowDialog();
            this.Close();

        }
        private void cbStartTime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbStartTime.Text))
            {
                errorProviderAppointment.SetError(cbStartTime, "you should fill your start time ");
                cbStartTime.Focus();
            }
            else
                errorProviderAppointment.SetError(cbStartTime, "");
        }
    }
}
