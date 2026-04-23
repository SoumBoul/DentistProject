using System;
using System.Collections.Generic;
using System.Text;
using DAL_Framwork;
using DTO_Framwork;



namespace BL_Framwork
{
    public class DentistBL
    {
        public enum enMode { AddNew=0, Update= 1 };
        static enMode _Mode = enMode.AddNew;

        int DentistID = -1;

        static PersonDTO Person { get; set; }
        static DentistDTO Dentist { get; set; }
        static EmployeDTO Employe { get; set; }
        public DentistBL(PersonDTO person,DentistDTO dentist, EmployeDTO employeID )
        {
            Person = person;
            Dentist = dentist;
            Employe = employeID;

             
        }

        public DentistBL(PersonDTO person, DentistDTO dentist)
        {
            Person = person;
            Dentist = dentist;
            _Mode = enMode.Update;


        }
        static public List<DentistDTO> GetAllDentists()
        {
            return DentistDAL.GetListDentists();

        }

        static public List<DentistDTO> GetInfoDentistsForAppointments()
        {
            return DentistDAL.GetInfoDentistsForAppointments();

        }

        static public DentistRegistrationDto FindDentistProfile(int dentistID)
        {
            return DentistProfileService.DentistProfil(dentistID);

        }
        static public List<DentistDTO> FilterDentistWithFullName(string text)
        {
            return  DentistDAL.FilterDentistWithFullName(text);

        }
        static public List<DentistDTO> FilterDentistWithSpecialization(string text)
        {
            return DentistDAL.FilterDentistWithSpecialization(text);

        }

        static public List<DentistDTO> FilterDentistWithEmail(string email)
        {
            return DentistDAL.FilterDentistWithEmail(email);

        }

        static public List<DentistDTO> FilterDentistWithID(int ID)
        {
            return DentistDAL.FilterDentistWithID(ID);

        }
        static public int FindDentistWithName(string name)
        {
            return DentistDAL.FindDentistID(name);

        }
        static public int GetDentistExperience(int PersonID)
        {
            return DentistDAL.GetDentistYearsOfExperience(PersonID);

        }
        static public bool UpdateDentist()
        {
            return DentistRegistrationService.UpdateDentistWithTransaction(Person, Dentist);
        }
        static public int AddDentistWithTransaction()
           {
             return DentistRegistrationService.AddDentistWithTransaction(Person,Dentist);
            
           }
          public bool Save()
         {
            switch(_Mode)
            {
                case enMode.AddNew:
                    AddDentistWithTransaction();
                    _Mode = enMode.Update;
                    return true;
                  

                case enMode.Update:

                    UpdateDentist();
                    return true;
                    


            }
            return false;

        }


    }
}
