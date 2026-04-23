using System;
using System.Data;
using DTO_Framwork;
using BL_Framwork;
using System.Windows.Forms;

namespace ProjectDentiste.Personnes
{
    public partial class frmPersonInfo : Form
    {
       
        int PersonID = -1;
        string Phone = " ";
        PersonDTO person;
      
        public frmPersonInfo(int personid )
        {
            InitializeComponent();
            PersonID = personid;
           
        }
        public frmPersonInfo(string phone)
        {
            InitializeComponent();
            Phone = phone;

        }
        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
            if(Phone == null)
            {
                person = PersonBL.FindPersonByID(PersonID);

                ctrlPersonInfo1.LoadPersonInfo(person);
            }
           else
            {
                person = PersonBL.FindPatientWithPhone(Phone);

                ctrlPersonInfo1.LoadPersonInfo(person);
            }
          

        }
    }
}
