using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Framwork
{
    public class MedicalRecordDTO
    {
        public int RecordID { get; set; }
        public int PatientID { get; set; }
        public string FullName { get; set; }
        public string MedicalRecordNumber { get; set; }
        public string Allergies { get; set; }
        public string MedicalHistory { get; set; }
        public string CurrentMedicaments { get; set; }
        public string Notes { get; set; }





    }



}
