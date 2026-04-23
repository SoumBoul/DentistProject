using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using DAL_Framwork;
using DTO_Framwork;

namespace BL_Framwork
{
    public class AppointmentBL
    {
        public enum enMode { AddNew = 0, Update = 1 };
        static enMode _Mode = enMode.AddNew;

        AppointmentDTO dto = new AppointmentDTO();

        public AppointmentBL(AppointmentDTO appointment)
        {
            dto = appointment;
            
        }
        static public List<AppointmentDTO>GetAllApointments()
        {
            return AppointmentDAL.GetAllApointments();
        }

         public int InsertAppointment()
        {
            return AppointmentDAL.InsertAppointment(dto);
        }

        static public bool UpdateStatusAppointment(int AppointmentID)
        {
            return AppointmentDAL.UpdateStatusAppointment(AppointmentID);
        }
        public int FindDentistAppointWithID()
        {
            return DentistDAL.FindDentistID(dto.FullName);
        }

       static public int CountAppointmentsByDentist(int personID)
        {
            return AppointmentDAL.CountAppointments(personID);
        }

        public bool isAppointmentIsValid()
        {
            return AppointmentDAL.IsApppointmentIsValid(dto);
        }
        static public List<AppointmentDTO>FilterListAppointmentsWithFullName(String fullname)
        {
            return AppointmentDAL.FilterAppointments_With_FullName(fullname);
        }

        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddNew:

                    InsertAppointment();
                    _Mode = enMode.Update;
                    return true;

                case enMode.Update:

                    
                    return true;




            }

            return false;



        }


    }
}
