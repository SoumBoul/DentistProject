using System;
using System.Collections.Generic;

using DAL_Framwork;
using DTO_Framwork;

namespace BL_Framwork
{
    public class PatientBL
    {

        public enum enMode { AddNew=0, Update=1};
        static enMode _Mode = enMode.AddNew;


        static public PersonDTO personDTO ;
        static public PatientDTO patientDTO { get; set; }
        static  public MutuellDTO mutuelleDTO { get; set; }
        static public MedicalRecordDTO medicalRecordsDto { get; set; }
        static public AllergyDto AllergyDto { get; set; }


        static public List<AllergyDto> allergyList { get; set; }

        public PatientBL(PersonDTO PersonDTO, PatientDTO PatientDTO, MutuellDTO MutuelleDTO,MedicalRecordDTO MedicalRecordDto, List<AllergyDto> AllergyList)
        {
            personDTO = PersonDTO;
            patientDTO = PatientDTO;
            mutuelleDTO = MutuelleDTO;
            medicalRecordsDto = MedicalRecordDto;
            allergyList = AllergyList;
        }

        
        static public List<PatientDTO> GetListPatients()
        {
            return PatientsDAL.GetListPatients();

        }
        static public List<PatientDTO> GetListNewPatients()
        {
            return PatientsDAL.GetListNewPatients();

        }
        static public string GetListPatients(int PatientID)
        {
            return PatientsDAL.FindImageByPatienID(PatientID);

        }

        static public int FindPatientIDbyPersonID(int PersonID)
        {
            return PatientsDAL.FindPatientIDByPersonID(PersonID);

        }

        static public int AddPatientWithTransaction( PersonDTO personDto, PatientDTO patientDto, MutuellDTO mutuellDto, MedicalRecordDTO medicalRecord,  List<AllergyDto> allergyDto)
        {
           return PatientRegistrationService.AddPatientWithTransaction( personDto, patientDto, mutuellDto, medicalRecord,  allergyDto);

        }

        static public PatientRegistrationDto GetFullPatientProfile(int PatientID)
        {
            return PatientProfileService.PatientProfile(PatientID);

        }
        static public PatientDTO GetPatientProfile(int PatientID)
        {
            return  PatientsDAL.FindPatientByID(PatientID);

        }

       

        static public List<PatientDTO> FiterPatients_With_FullName(string text)
        {
            return PatientsDAL.FilterPatients_With_FullName(text);

        }
        static public List<PatientDTO> FiterPatients_With_NumeroDeDossier(string text)
        {
            return PatientsDAL.FilterPatients_With_NumeroDeDossier(text);

        }

        static public bool UpdatePatientWithTransaction(PersonDTO personDTO,PatientDTO patientDTO, MutuellDTO mutuelleDTO, MedicalRecordDTO medicalecordsDto, List<AllergyDto> Allergies)
        {
            return PatientRegistrationService.UpdatePatientWithTransaction(personDTO, patientDTO, mutuelleDTO,medicalecordsDto,Allergies);

        }

        static public bool UpdatePatient()
        {
            return PatientRegistrationService.UpdatePatientWithTransaction(personDTO, patientDTO, mutuelleDTO, medicalRecordsDto, allergyList);

        }
        static public string FindPatientImage(int patientId)
        {
            return PatientsDAL.FindImageByPatienID(patientId);
        }

        static public int FindPatientIdWithFolderNum(string name)
        {
            return PatientsDAL.FindPatientIdWithFolderNum(name);
        }

        public bool Save()
        {

            switch(_Mode)
            {
                case enMode.AddNew:

                     AddPatientWithTransaction( personDTO,patientDTO,mutuelleDTO, medicalRecordsDto, allergyList);
                     _Mode= enMode.Update;
                     return true;
                   
                case enMode.Update:

                    UpdatePatient();
                    return true;


            }

            return false;



        }

    }
}
