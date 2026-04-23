using System;
using System.Collections.Generic;
using System.Text;
using BL_Framwork;

using System.Windows.Forms;
using ProjectDentiste.Properties;

namespace ProjectDentiste.Patients
{
    public partial class frmPatientImage : Form
    {
        int PatientID = -1;
        public frmPatientImage(int patientID)
        {
            InitializeComponent();
            this.PatientID = patientID;
        }

        public void LoadImage(int p)
        {
            p = PatientID;
            if(p<=0)
            {
                pbPatientImage.Image = Resources.Aucune_image_disponible;
                
            }
            pbPatientImage.ImageLocation = PatientBL.FindPatientImage(p);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
