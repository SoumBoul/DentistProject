using System;
using System.Windows.Forms;

using System.Drawing;
using System.Collections.Generic;
using ProjectDentiste.Patients;
using DTO_Framwork;
using BL_Framwork;


using System.IO;
using ProjectDentiste.Properties;
using ProjectDentiste.Personnes;
using ProjectDentiste.Appointments;
using ProjectDentiste.MedicalRecord;
using ProjectDentiste.Login;
using ProjectDentiste.Payment;
using ProjectDentiste.MedicalRecord.Contols;
using System.Web.UI.WebControls;
using System.Data;
using ProjectDentiste.Treatments;

namespace ProjectDentiste.MainForm
{
    public partial class frmDashBoard1 : Form
    {
        frmPatientImage frm;
        frmLogin log = new frmLogin();
        public List<PatientDTO> patients = new List<PatientDTO>();
        string _username;
        MedicalRecordDTO medicalDto { get; set; }

       
        public bool appoi
        {
            get { return toolShowPatient.Enabled = false; }
        }

        PatientPaymentInfoDTO dto { get; set; }

        
        public frmDashBoard1()
        {
            
            InitializeComponent();
            GetNewPatients();
            GetDashBoardListPatients();
            GetListPatients();
            GetListDentists();
            //Appointments_ListDentists();
            ShowAllAppintments();
            lblTotalPatients.Text = dgvListPatients.Rows.Count.ToString();
            lblDentistTotal.Text = dgvListDentists.Rows.Count.ToString();
            l.Text = dgNewPatients.Rows.Count.ToString();
            lblTotalDentists.Text = dgvListDentists.Rows.Count.ToString();
            lblTotalAppointments.Text = dgShowAllApointments.Rows.Count.ToString();
            cbFilter.Text = "FullName";
            dgvListPatients.RowTemplate.Height = 90;
            
            pbUser.ImageLocation = LoginBL.FindImageUser(GlobalLogin.username);
            int personid = PersonBL.FindPersonIDByUserName(GlobalLogin.username);
            var p = PersonBL.FindPersonByID(personid);
            lblDentistFullName.Text = p.FirstName + " " + p.LastName;
            lblTotalAppointmentsByDentist.Text = AppointmentBL.CountAppointmentsByDentist(personid).ToString();
            lblYearsOfExerience.Text = DentistBL.GetDentistExperience(personid).ToString();

        }


        public DataGridView dgAllRecords
        {
            get { return dgMedicalRecords; }
        }

        public string FullName
        {          
            get { return dgvListPatients.CurrentRow.Cells["FullName"].Value.ToString(); }
        }
        public int  RdvID
        {
            get { return (int)dgShowAllApointments.CurrentRow.Cells["RdvID"].Value; }
        }
        public void GetNewPatients()
        {
            dgNewPatients.DataSource = BL_Framwork.PatientBL.GetListNewPatients();
            if (dgNewPatients.Columns.Count > 0)
            {
                dgNewPatients.Columns[0].HeaderText = " PatientID";
                dgNewPatients.Columns[1].HeaderText = " Dossier num ";
                dgNewPatients.Columns[2].HeaderText = " FullName";
                dgNewPatients.Columns[3].HeaderText = " Date De Creation";
                dgNewPatients.Columns[4].HeaderText = " Note Generale";
                dgNewPatients.Columns[5].HeaderText = " Dentist FullName";
                dgNewPatients.Columns[6].HeaderText = " Compagnie";


                dgNewPatients.Columns["PersonID"].Visible = false;
                dgNewPatients.Columns["DentistID"].Visible = false;
                dgNewPatients.Columns["Nom"].Visible = false;
                dgNewPatients.Columns["Email"].Visible = false;
                dgNewPatients.Columns["Telephone"].Visible = false;
                dgNewPatients.Columns["DateNaissance"].Visible = false;
                dgNewPatients.Columns["DentisteFullName"].Visible = false;

                dgNewPatients.Columns["Image"].Visible = false;
                dgNewPatients.Columns["Compagnie"].Visible = false;
                dgNewPatients.Columns["NoteGenerale"].Visible = false;
                dgNewPatients.Columns["DateDeCreation"].Visible = false;
                dgNewPatients.Columns["Status"].Visible = false;


    }

  }
        //public frmDashBoard1(string username)
        //{
        //    InitializeComponent();
        //    _username = username;
        //}
        public void IfAppointmentExist()
        {
            
            //Dictionary<int, SortedList<DateTime, string>> appointmentDentist = new Dictionary<int, SortedList<DateTime, string>>();

            //appointmentDentist


        }
        public void ShowAllAppintments()
        {
            dgShowAllApointments.DataSource = AppointmentBL.GetAllApointments();
            if (dgShowAllApointments.Columns.Count > 0)
            {
                
                dgShowAllApointments.Columns["RdvID"].HeaderText = " Appointment ID";
                dgShowAllApointments.Columns["FullName"].HeaderText = "FullName";
                dgShowAllApointments.Columns["RdvDate"].HeaderText = "Appointment Date";
                dgShowAllApointments.Columns["NewStart"].HeaderText = "Start Date";
                dgShowAllApointments.Columns["NewEnd"].HeaderText = "End Date";
                dgShowAllApointments.Columns["Status"].HeaderText = "Status";
                dgShowAllApointments.Columns["NoteGenerale"].HeaderText = "General Note";
                dgShowAllApointments.Columns["DentistName"].HeaderText = "Dentist Name";

                dgShowAllApointments.Columns["DentistID"].Visible = false;
                dgShowAllApointments.Columns["PatientID"].Visible = false;

                dgShowAllApointments.Columns["NewStart"].Visible = false;
                dgShowAllApointments.Columns["NewEnd"].Visible = false;

            }
           
        }
        public void GetListPatients()
        {
            dgvListPatients.DataSource = BL_Framwork.PatientBL.GetListPatients();
            if (dgvListPatients.Columns.Count > 0)
            {
                dgvListPatients.Columns[0].HeaderText = " Patient ID";
                dgvListPatients.Columns[1].HeaderText = " Dossier num";
                dgvListPatients.Columns[2].HeaderText = " FullName";
                dgvListPatients.Columns[3].HeaderText = " Birth day";
                dgvListPatients.Columns[4].HeaderText = " Cell Phone";

                
                dgvListPatients.Columns[5].HeaderText = " Dentist Name";
                dgvListPatients.Columns[6].HeaderText = " Status";

                dgvListPatients.Columns["DateDeCreation"].Visible = false;
                dgvListPatients.Columns["NoteGenerale"].Visible = false;
                dgvListPatients.Columns["PersonID"].Visible = false;
                dgvListPatients.Columns["DentistID"].Visible = false;
                dgvListPatients.Columns["Nom"].Visible = false;
                dgvListPatients.Columns["Email"].Visible = false;
                dgvListPatients.Columns["Image"].Visible = false;
                //dgvListPatients.Columns["Status"].Visible = false;




            }

        }
        public void GetListDentists()
        {
            dgvListDentists.DataSource = DentistBL.GetAllDentists();
            
            if(dgvListDentists.Rows.Count>0)
            {
               
                dgvListDentists.Columns[1].HeaderText = "DentistID";
                dgvListDentists.Columns[2].HeaderText = "FullName ";
                dgvListDentists.Columns[3].HeaderText = "Telephone";
                dgvListDentists.Columns[4].HeaderText = "Email";
                dgvListDentists.Columns[5].HeaderText = "Specialisation";
                dgvListDentists.Columns[6].HeaderText = "Created AT";

                dgvListDentists.Columns["Image"].Visible = false;
                dgvListDentists.Columns["PersonID"].Visible = false;

            }
            DataGridViewImageColumn image = new DataGridViewImageColumn();
            image.Name = "Photo";
            image.HeaderText = "Photo";
            image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            

            dgvListDentists.Columns.Insert(0, image);
            dgvListDentists.Columns["Photo"].Width = 60;

            if (dgvListDentists.Columns["Image"] == null)
            {
                image.Image = Resources.Aucune_image_disponible;
            }

        }
        public void GetDashBoardListPatients()
        {
            dgvDashBoardListPatients.DataSource = BL_Framwork.PatientBL.GetListPatients();

            if (dgvDashBoardListPatients.Columns.Count > 0)
            {
                dgvDashBoardListPatients.Columns[0].HeaderText = " PatientID";
                dgvDashBoardListPatients.Columns[1].HeaderText = " Dossier num";
                dgvDashBoardListPatients.Columns[2].HeaderText = " FullName";
                dgvDashBoardListPatients.Columns[3].HeaderText = " Birth day";
                dgvDashBoardListPatients.Columns[4].HeaderText = " Cell Phone";
                dgvDashBoardListPatients.Columns[5].HeaderText = " Dentist FullName";
                //dgvDashBoardListPatients.Columns[6].HeaderText = " Status";
                dgvDashBoardListPatients.Columns[6].HeaderText = " Compagnie";

                dgvDashBoardListPatients.Columns["DateDeCreation"].Visible = false;
                dgvDashBoardListPatients.Columns["NoteGenerale"].Visible = false;
                dgvDashBoardListPatients.Columns["PersonID"].Visible = false;
                dgvDashBoardListPatients.Columns["DentistID"].Visible = false;
                dgvDashBoardListPatients.Columns["Nom"].Visible = false;
                dgvDashBoardListPatients.Columns["Email"].Visible = false;

            }





        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            frmAddUpdatePatient frm = new frmAddUpdatePatient();
            frm.ShowDialog();
        }
        private void contextMenuStrip1_Click_1(object sender, EventArgs e)
        {
            frmAddUpdatePatient frm = new frmAddUpdatePatient((int)dgvListPatients.CurrentRow.Cells["PatientID"].Value);
            frm.ShowDialog();
        }
        private void frmDashBoard1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_username))
            {
                string image = LoginBL.FindImageUser(_username);
            }
            lblTotalPatients.Text = dgvListPatients.Rows.Count.ToString();
            cbDentistFilter.SelectedIndex = 1;
            lblNewPatients.Text = dgNewPatients.Rows.Count.ToString();
            lblTotalDentists.Text = dgvListDentists.Rows.Count.ToString();
            lblTotalAppointments.Text = dgShowAllApointments.Rows.Count.ToString();
            lblPatientsTotal.Text = dgvListPatients.Rows.Count.ToString();
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            lblTotalPatients.Text = dgvListPatients.Rows.Count.ToString();
        }  
        private void dgvListPatients_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if(frm==null)
            {
                return;
            }
            frm.Visible = false;

        }
        private void dgvListPatients_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int patientId = (int)dgvListPatients.Rows[e.RowIndex].Cells[0].Value;

            frm = new frmPatientImage(patientId);
            // charger image UNE fois
            frm.LoadImage(patientId);

            // position souris
            Point pos = this.PointToClient(Cursor.Position);

            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(pos.X + 15, pos.Y + 15);

            // IMPORTANT : afficher sans bloquer
            if (!frm.Visible)
                frm.Show();
        }
        private void dgvListDentists_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListDentists.Columns[e.ColumnIndex].Name == "Photo")
            {
                var path = dgvListDentists.Rows[e.RowIndex].Cells["Image"].Value?.ToString();

                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    using (var image = System.Drawing.Image.FromFile(path))
                    {
                        e.Value = new System.Drawing.Bitmap(image);
                    }
                }
            }

        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            frmAddUpdateDentist frm = new frmAddUpdateDentist();
            frm.ShowDialog();
        }
        private void txtSearshDentist_TextChanged(object sender, EventArgs e)
        {
          
            switch(cbDentistFilter.Text)
            {

                case "DentistID":


                   dgvListDentists.DataSource= string.IsNullOrWhiteSpace(txtSearshDentist.Text) ?
                   dgvListDentists.DataSource = DentistBL.GetAllDentists() :
                   dgvListDentists.DataSource = DentistBL.FilterDentistWithID(Convert.ToInt32(txtSearshDentist.Text));

                   
                    dgvListDentists.Show();
                    break;

                case "FullName":
                    List<DentistDTO> d = DentistBL.FilterDentistWithFullName(txtSearshDentist.Text);
                    dgvListDentists.DataSource = d;
                    dgvListDentists.Show();
                    break;

                case "Specialization":
                    List<DentistDTO> specialization = DentistBL.FilterDentistWithSpecialization(txtSearshDentist.Text);

                    dgvListDentists.DataSource = specialization;
                    dgvListDentists.Show();
                    break;
                case "Email":
                    List<DentistDTO> email = DentistBL.FilterDentistWithEmail(txtSearshDentist.Text);

                    dgvListDentists.DataSource = email;
                    dgvListDentists.Show();
                    break;

            }
            
         
        }
        private void toolShowPatient_Click(object sender, EventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo(dgvListPatients.CurrentRow.Cells[4].Value.ToString());
          
            frm.ShowDialog();
        }
        private void toolUpdatePatient_Click(object sender, EventArgs e)
        {
            frmAddUpdatePatient frm = new frmAddUpdatePatient((int)dgvListPatients.CurrentRow.Cells[0].Value);
           
            frm.ShowDialog();
        }
        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            frmAddUpdatePatient frm = new frmAddUpdatePatient();
            frm.ShowDialog();
        }
        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            frmAddUpdateDentist frm = new frmAddUpdateDentist();
            frm.ShowDialog();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo(dgvListDentists.CurrentRow.Cells[4].Value.ToString());
            
            frm.ShowDialog();
        }
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Close();
        } 
        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void btnVreateAppointment_Click_1(object sender, EventArgs e)
        {
            frmListPatients frm = new frmListPatients();
            frm.ShowDialog();
        }
        private void txtSearsh_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "FullName")
            {
                List<PatientDTO> m = BL_Framwork.PatientBL.FiterPatients_With_FullName(txtSearsh.Text);

                dgvListPatients.DataSource = m;
                dgvListPatients.Show();

            }
            if (cbFilter.Text == "Numero De Dossier")
            {
                List<PatientDTO> m = BL_Framwork.PatientBL.FiterPatients_With_NumeroDeDossier(txtSearsh.Text);

                dgvListPatients.DataSource = m;
                dgvListPatients.Show();


            }

        }
        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (cbFilter.Text == "FullName")
            {
                List<PatientDTO> m = BL_Framwork.PatientBL.FiterPatients_With_FullName(txtSearsh.Text);

                dgShowAllApointments.DataSource = m;
                dgShowAllApointments.Show();

            }
            if (cbFilter.Text == "Numero De Dossier")
            {
                List<PatientDTO> m = BL_Framwork.PatientBL.FiterPatients_With_NumeroDeDossier(txtSearsh.Text);

                dgShowAllApointments.DataSource = m;
                dgShowAllApointments.Show();


            }

        }
        private void txtSearshDentist_TextChanged_1(object sender, EventArgs e)
        {
            switch (cbDentistFilter.Text)
            {

                case "DentistID":


                    if (txtSearsh.Text == " ")
                        return;
                    dgvListDentists.DataSource = string.IsNullOrWhiteSpace(txtSearshDentist.Text) ?
                    dgvListDentists.DataSource = DentistBL.GetAllDentists() :
                    dgvListDentists.DataSource = DentistBL.FilterDentistWithID(Convert.ToInt32(txtSearshDentist.Text));


                    dgvListDentists.Show();
                    break;

                case "FullName":
                    List<DentistDTO> d = DentistBL.FilterDentistWithFullName(txtSearshDentist.Text);
                    dgvListDentists.DataSource = d;
                    dgvListDentists.Show();
                    break;

                case "Specialization":
                    List<DentistDTO> specialization = DentistBL.FilterDentistWithSpecialization(txtSearshDentist.Text);

                    dgvListDentists.DataSource = specialization;
                    dgvListDentists.Show();
                    break;
                case "Email":
                    List<DentistDTO> email = DentistBL.FilterDentistWithEmail(txtSearshDentist.Text);

                    dgvListDentists.DataSource = email;
                    dgvListDentists.Show();
                    break;

            }

        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddUpdateDentist frm = new frmAddUpdateDentist((int)dgvListDentists.CurrentRow.Cells["DentistID"].Value);
            
            frm.LoadDentistInfo();
            frm.ShowDialog();
        }
        private void takeAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeAppointments frm = new frmTakeAppointments((int)dgShowAllApointments.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "FullName")
            {
                List<AppointmentDTO> m = AppointmentBL.FilterListAppointmentsWithFullName(txtFilter.Text);

                dgShowAllApointments.DataSource = m;
                dgShowAllApointments.Show();

            }
            if (cbFilter.Text == "Numero De Dossier")
            {
                List<AppointmentDTO> m = AppointmentBL.FilterListAppointmentsWithFullName(txtFilter.Text);

                dgShowAllApointments.DataSource = m;
                dgShowAllApointments.Show();


            }



        }
        private void updateAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeAppointments frm = new frmTakeAppointments((DateTime)dgShowAllApointments.CurrentRow.Cells["RdvDate"].Value);
            frm.ShowDialog();
        }
        private void txtSearshDentist_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(cbDentistFilter.Text == "DentistID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // bloque le caractère
                }
            }
            
        }
        private void cntrPersonProfile1_Load(object sender, EventArgs e)
        {
                dgMedicalRecords.DataSource = MedicalRecordBL.GetAllMedicalRecords();
                dgMedicalRecords.Columns["PatientID"].Visible = false;
                dgMedicalRecords.Columns["MedicalRecordNumber"].Visible = false;
                
        }
        private void dgvListPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       private void btnAddRecord_Click(object sender, EventArgs e)
        {
            frmMedicalRecord frm = new frmMedicalRecord();
            frm.ShowDialog();
        }
        private void takeAppontmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeAppointments frm = new frmTakeAppointments((int)dgvListPatients.CurrentRow.Cells["PatientID"].Value);
            frm.ShowDialog();
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            dto = new PatientPaymentInfoDTO()
            {
                RdvID= (int)dgShowAllApointments.CurrentRow.Cells["RdvID"].Value,
                PatientFullName = dgShowAllApointments.CurrentRow.Cells["FullName"].Value.ToString(),
                DentistName = dgShowAllApointments.CurrentRow.Cells["DentistName"].Value.ToString(),
                AppointmentDate= Convert.ToDateTime( dgShowAllApointments.CurrentRow.Cells[2].Value),
            };

            frmPayment frm = new frmPayment( dto);
           

            frm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RdvID = (int)dgShowAllApointments.CurrentRow.Cells["RdvID"].Value;
            
            frmTreatments frm = new frmTreatments(RdvID);
            frm.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
           
            frmTreatmentDetails frm = new frmTreatmentDetails();
            frm.ShowDialog();
        }
    }
}
