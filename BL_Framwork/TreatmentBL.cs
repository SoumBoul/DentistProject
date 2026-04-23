using DAL_Framwork;
using DTO_Framwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Framwork
{
    public class TreatmentBL
    {

        TreatmentDTO dto { get; set; }
        public enum enMode { AddNew = 0, Update = 1 };
         enMode _Mode = enMode.AddNew;

        public int InsertTreatment()
        {
            return TreatmentDAL.InsertTreatment(dto);
        }

        static public decimal GetPriceOfTreatment(int TreatmentID)
        {
            return TreatmentDAL.GetPriceOfTreatment(TreatmentID);
        }

        public TreatmentBL(TreatmentDTO DTO)
        {
            dto = DTO;
        }


        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:

                    InsertTreatment();
                    _Mode = enMode.Update;
                    return true;
                    break;

                case enMode.Update:

                    return true;
                    break;



            }

            return false;

        }


    }
}
