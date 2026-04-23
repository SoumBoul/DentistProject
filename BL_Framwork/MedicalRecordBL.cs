using DAL_Framwork;
using DTO_Framwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Framwork
{
    public  class MedicalRecordBL
    {
        static public List<MedicalRecordDTO> GetAllMedicalRecords()
        {
            return MedicalRecordDAL.GetAllMedicalRecord();
        }

         static public MedicalRecordDTO GetMedicalRecordByFullName(string fullName)
         {
            return MedicalRecordDAL.FindMedicalRecordByFullName(fullName);
         }

        



    }
}
