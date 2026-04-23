using BL_Framwork;
using ProjectDentiste.Patients;
using ProjectDentiste.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DTO_Framwork;

namespace ProjectDentiste.Appointments
{
    public partial class frmListPatients : Form
    {
        public frmListPatients()
        {
            InitializeComponent();

        }
        PatientAppointmentInfoDto dto;

        private void LoadTakeAppontment()
        {
            dgListPatientsForAppointment.DataSource = PatientBL.GetListPatients();
            if (dgListPatientsForAppointment.Rows.Count > 0)
            {
                dgListPatientsForAppointment.Columns[1].HeaderText = " Patient ID";
                dgListPatientsForAppointment.Columns[2].HeaderText = " Dossier num";
                dgListPatientsForAppointment.Columns[3].HeaderText = " FullName";
                dgListPatientsForAppointment.Columns[4].HeaderText = " Birth day";
                dgListPatientsForAppointment.Columns[5].HeaderText = " Cell Phone";
                dgListPatientsForAppointment.Columns[6].HeaderText = " Dentist FullName";
                //dgvListPatients.Columns[6].HeaderText = " Status";

                dgListPatientsForAppointment.Columns["DateDeCreation"].Visible = false;
                dgListPatientsForAppointment.Columns["NoteGenerale"].Visible = false;
                dgListPatientsForAppointment.Columns["PersonID"].Visible = false;
                dgListPatientsForAppointment.Columns["DentistID"].Visible = false;
                dgListPatientsForAppointment.Columns["Nom"].Visible = false;
                dgListPatientsForAppointment.Columns["Email"].Visible = false;
                dgListPatientsForAppointment.Columns["Compagnie"].Visible = false;
                dgListPatientsForAppointment.Columns["Image"].Visible = false;
                            

            }

            DataGridViewImageColumn myImage = new DataGridViewImageColumn();
            myImage.Name = "Photo";

            myImage.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgListPatientsForAppointment.Columns.Insert(0, myImage);

            if (dgListPatientsForAppointment.Columns["Image"] == null)
            {
                myImage.Image = Resources.Aucune_image_disponible;

            }

        }
        private void frmTakeAppointment_Load(object sender, EventArgs e)
        {
            LoadTakeAppontment();

        }
        private void dgListPatientsForAppointment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (dgListPatientsForAppointment.Columns[e.ColumnIndex].Name == "Photo")
            {
                var path = dgListPatientsForAppointment.Rows[e.RowIndex].Cells["Image"].Value?.ToString();

                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    using (var image = Image.FromFile(path))
                    {
                        e.Value = new Bitmap(image);
                    }
                }
            }


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
             dto = new PatientAppointmentInfoDto()
            {
                PatientID = (int)dgListPatientsForAppointment.CurrentRow.Cells["PatientID"].Value,
                FullName = dgListPatientsForAppointment.CurrentRow.Cells["FullName"].Value.ToString(),
                Phone = dgListPatientsForAppointment.CurrentRow.Cells["Telephone"].Value.ToString(),
                
            };
            dto.PersonID = PersonBL.GetPersonIDByFullName(dto.FullName);
            
            frmTakeAppointments frm = new frmTakeAppointments(dto);
            frm.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmAddUpdatePatient frm = new frmAddUpdatePatient();
            this.Close();
            frm.ShowDialog();
        }

        private void txtSearsh_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "FullName")
            {
                List<PatientDTO> m = BL_Framwork.PatientBL.FiterPatients_With_FullName(txtSearsh.Text);

                dgListPatientsForAppointment.DataSource = m;
                dgListPatientsForAppointment.Show();

            }
            if (cbFilter.Text == "Numero De Dossier")
            {
                List<PatientDTO> m = BL_Framwork.PatientBL.FiterPatients_With_NumeroDeDossier(txtSearsh.Text);

                dgListPatientsForAppointment.DataSource = m;
                dgListPatientsForAppointment.Show();


            }

        }
    }





}
