
using System;
using System.Collections.Generic;
using System.Data;
using DAL_Framwork;
using DTO_Framwork;

namespace BL_Framwork
{
    public  class PersonBL
    {
        public enum enMode { AddNew = 0, Update = 1 };
        static enMode _Mode = enMode.AddNew;


        static public PersonDTO personDTO;
        static public PatientDTO patientDTO { get; set; }
        static public MutuellDTO mutuelleDTO { get; set; }
        static public MedicalRecordDTO medicalRecord { get; set; }
        static public List<AllergyDto> allergieDto { get; set; }

        //static public List<PatientDTO> GetListPatients()
        //{
        //    return DataAccessLayer.clsPatientsDAL.GetListPatients();

        //}


        static public int AddPatientWithTransaction(ref PersonDTO personDto, PatientDTO patientDto, MutuellDTO mutuellDto, MedicalRecordDTO medicalRecord, List<AllergyDto> allergyDto)
        {

            //personDTO = new PersonDTO();
            return PatientRegistrationService.AddPatientWithTransaction( personDto, patientDto, mutuellDto,medicalRecord,  allergieDto);

        }
        static public PersonDTO FindPersonByID(int personID)
        {
             return PersonDAL.FindPersonByID(personID);

        }

        static public PersonDTO FindPersonByFullName(string FullName)
        {
            return PersonDAL.FindPersonByFullName(FullName);

        }
        static public bool IsNationalNumberExist(string NoNumber)
        {
            return PersonDAL.IsNationalNumberExist(NoNumber);
        }
        static public PersonDTO FindPatientWithPhone(string phone)
        {
            return PersonDAL.FindPersonByPhone(phone);

        }
        static public int FindPersonIDByUserName(string username)
        {
            return PersonDAL.FindPersonIDByUserName(username);

        }
        static public int GetPersonIDByFullName(string FullName)
        {
            return PersonDAL.GetPersonIDByFullName(FullName);

        }


        static public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddNew:

                    AddPatientWithTransaction(ref personDTO, patientDTO, mutuelleDTO, medicalRecord, allergieDto);
                    _Mode = enMode.Update;
                    return true;

                case enMode.Update:

                    return false;




            }

            return true;



        }

    }
}
