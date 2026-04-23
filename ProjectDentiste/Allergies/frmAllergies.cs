using BL_Framwork;
using DTO_Framwork;
using ProjectDentiste.MedicalRecord;
using ProjectDentiste.MedicalRecord.Contols;
using ProjectDentiste.Patients;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectDentiste.Allergies
{
    public partial class frmAllergies : Form
    {

        List<AllergyDto> _allergies= new List<AllergyDto>() ;
        AllergyDto all = new AllergyDto();
        AllergyDto dto = new AllergyDto();
        cntrMedicalRecords cntr = new cntrMedicalRecords();
        

        public frmAllergies()
        {
            InitializeComponent();
        }
        public frmAllergies(List<AllergyDto> allergies)
        {
            InitializeComponent();

            _allergies = allergies ?? new List<AllergyDto>(); ;
        }
       

        public frmAllergies(AllergyDto All)
        {
            InitializeComponent();

            all = All ?? new AllergyDto(); ;
        }

        public List<AllergyDto>GetAllergies
        {
            get { return _allergies; }
        }
       
        public void RefreshDataGirdAllergies()
        {
            dgGetAllAlergies.DataSource = _allergies;
        }

        public void ResetFrmAllergies()
        {
            txtAllergyName.Clear();
           
        }
        
       
        public  string AllergieName
        {
            get { return txtAllergyName.Text; }
        }
        public DateTime DateAdded
        {
            get { return DateTime.Now; }
        }
        public int EmployeID
        {
            get { return Convert.ToInt32(txtEmplyeID.Text); }
        }
       
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAllergyName.Text))
                return;


            AllergyDto allergydto = new AllergyDto
            {
                AllergieName = txtAllergyName.Text,
                DateAdded = DateTime.Now,
                EmployeID=Convert.ToInt32(txtEmplyeID.Text),
               
            };



            _allergies.Add(allergydto);
            

            dgGetAllAlergies.DataSource = null;

            dgGetAllAlergies.DataSource = _allergies;
            
            

            ResetFrmAllergies();
            

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmAllergies_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dto = new AllergyDto()
            {
                AllergieName = txtAllergyName.Text,
                DateAdded = dtAddedAT.Value,
                EmployeID = Convert.ToInt32(txtEmplyeID.Text),
                RecordID = (int)dgGetAllAlergies.CurrentRow.Cells[4].Value,
                AllergieID = (int)dgGetAllAlergies.CurrentRow.Cells[0].Value
            };
            if (AllergieBL.UpdateAllergies(dto))
            {
                MessageBox.Show("The Allergie Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGirdAllergies();
            }
            else
            {
                MessageBox.Show("The Allergie Is NOT Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateAllergyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
             dto = new AllergyDto()
            {
                AllergieName= txtAllergyName.Text,
                DateAdded= dtAddedAT.Value,
                EmployeID=Convert.ToInt32( txtEmplyeID.Text),
                RecordID = (int)dgGetAllAlergies.CurrentRow.Cells[4].Value,
                AllergieID= (int)dgGetAllAlergies.CurrentRow.Cells[0].Value
             };
            if(AllergieBL.UpdateAllergies(dto))
            {
                MessageBox.Show("The Allergie Updated Successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                RefreshDataGirdAllergies();
            }
            else
            {
                MessageBox.Show("The Allergie Is NOT Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgGetAllAlergies_DoubleClick(object sender, EventArgs e)
        {
            txtAllergyName.Text = dgGetAllAlergies.CurrentRow.Cells["AllergieName"].Value.ToString();
            txtEmplyeID.Text= dgGetAllAlergies.CurrentRow.Cells["EmployeID"].Value.ToString();
        }
    }
}
