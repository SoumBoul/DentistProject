using System;
using DAL_Framwork;
using DTO_Framwork;

namespace BL_Framwork
{
    public  class MutuelleBL
    {

        static public MutuellDTO FindMutuelleByPatientID(int patientID)
        {

            return MutuelleDAL.FindMutuelleByPatientID(patientID);
        }






    }
}
