using BL_Framwork;
using DTO_Framwork;
using ProjectDentiste.MainForm;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace ProjectDentiste.Treatments
{
    public partial class frmTreatments : Form
    {
        List<TreatmentDTO> _TreatmentDTO= new List<TreatmentDTO>();
        TreatmentDTO dto;
        int rdvID = -1;
        public frmTreatments()
        {
            InitializeComponent();
        }

        public frmTreatments(int RdvID)
        {
            InitializeComponent();
            
            rdvID = RdvID;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(cbTreatmentName.Text))
            {
                return;
            }

            
             dto= new TreatmentDTO()
            {
                
                TreatmentTypeID = cbTreatmentName.SelectedIndex,
                Description= txtDescription.Text,
                Quantity= Convert.ToInt32(txtQuantity.Text),
                UnitPrice= Convert.ToDecimal(txtTotalPrice.Text),
                TotalPrice= Convert.ToDecimal(txtTotalPrice.Text),

             };

            _TreatmentDTO.Add(dto);
            dgListTreatments.DataSource = null;
            dgListTreatments.DataSource = _TreatmentDTO;





        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TreatmentBL treatment = new TreatmentBL(dto);
            if (treatment.Save())
            {
                txtTreatmentDetailsID.Text = dto.RdvID.ToString();
                MessageBox.Show("The Treatment Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The Treatment NOT Added ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }




        }

        private void cbTreatmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text=="")
            {
                txtQuantity.Text = 1.ToString();
            }
            switch(cbTreatmentName.Text)
            {
                case "Scaling":
                    decimal price= TreatmentBL.GetPriceOfTreatment(cbTreatmentName.SelectedIndex+1);

                    int quantity = Convert.ToInt32(txtQuantity.Text);
                    txtTotalPrice.Text = (price * quantity).ToString();
                    break;




            }
        }
    }
}
