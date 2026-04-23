using System;
using DTO_Framwork;

namespace DAL_Framwork
{
    public class PatientProfileService
    {
        static public PatientRegistrationDto PatientProfile(int PatientID)
        {
            PatientRegistrationDto dto = new PatientRegistrationDto();
           
                dto.patient = PatientsDAL.FindPatientByID(PatientID);
                dto.person = PersonDAL.FindPersonByID(dto.patient.PersonID);
                dto.mutuelle = MutuelleDAL.FindMutuelleByPatientID(dto.patient.PatientID);

                string fullName = dto.person.FirstName + " " + dto.person.LastName;

                dto.medicalRecordDto = MedicalRecordDAL.FindMedicalRecordByFullName(fullName);
                dto.allergy = AllergyDAL.FindAllergyByRecordID(dto.medicalRecordDto.RecordID);
          
            return dto;


        }

    }
}
