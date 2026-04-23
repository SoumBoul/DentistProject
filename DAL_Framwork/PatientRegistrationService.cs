using System.Data.SqlClient;
using System.Data;
using DTO_Framwork;
using System.Collections.Generic;

namespace DAL_Framwork
{
    public class PatientRegistrationService
    {

        static public string connectionString = "server=.;database= DentisteDB; user id=sa; password=123456; ";
        static public int AddPatientWithTransaction(PersonDTO person, PatientDTO patient,MutuellDTO mutuelle,MedicalRecordDTO medicalRecord
                                                     ,List<AllergyDto> allergies)

        {
            int patientID = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    int personID = PersonDAL.AddPerson(person, conn, trans);
                    if (personID <= 0)
                    {
                        trans.Rollback();
                        return 0;
                    }

                    patient.PersonID = personID;

                    patientID = PatientsDAL.AddPatient(patient, conn, trans);
                    if (patientID <= 0)
                    {
                        trans.Rollback();
                        return 0;
                    }

                    if (mutuelle != null && mutuelle.MutuelleCompagnieID > 0)
                    {
                        mutuelle.PatientID = patientID;

                        int mutuelleID = MutuelleDAL.AddMutuelle(mutuelle, conn, trans);
                        if (mutuelleID <= 0)
                        {
                            trans.Rollback();
                            return 0;
                        }
                    }

                    int medicalRecordID = 0;

                    if (medicalRecord != null)
                    {
                        medicalRecord.PatientID = patientID;

                        medicalRecordID = MedicalRecordDAL.InsertMedicalRecord(medicalRecord, conn, trans);
                        if (medicalRecordID <= 0)
                        {
                            trans.Rollback();
                            return 0;
                        }
                    }

                    if (allergies != null && allergies.Count > 0)
                    {
                        
                        foreach (var allergy in allergies)
                        {
                            allergy.RecordID = medicalRecordID;

                            int allergyID = AllergyDAL.AddAllergie(allergy, conn, trans);
                            if (allergyID <= 0)
                            {
                                trans.Rollback();
                                return 0;
                            }
                        }
                    }

                    trans.Commit();
                    return patientID;
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
        static public bool UpdatePatientWithTransaction(PersonDTO person, PatientDTO patient, MutuellDTO mutuelle, MedicalRecordDTO medicalRecord
                                                     , List<AllergyDto> allergies)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var trans = conn.BeginTransaction();


                try
                {

                    bool personID = PersonDAL.UpdatePerson(person, conn, trans);
                    if (personID != true)
                    {
                        trans.Rollback();
                        throw  new System.Exception();

                    }

                    patient.PersonID = person.PersonID;
                    
                    bool PatientID = PatientsDAL.UpdatePatient(patient, conn, trans);
                    if (PatientID != true)
                    {
                        trans.Rollback();
                        return false;
                    }

                    
                    if(mutuelle.MutuelleCompagnieID > 0)
                    {
                        mutuelle.PatientID = patient.PatientID;

                        bool mutuelleID = MutuelleDAL.UpdateMutuelle(mutuelle, conn, trans);
                    }
                    int medicalRecordID = 0;


                    if (medicalRecord != null)
                    {
                        medicalRecord.PatientID = patient.PatientID;

                        medicalRecordID = MedicalRecordDAL.InsertMedicalRecord(medicalRecord, conn, trans);
                        if (medicalRecordID <= 0)
                        {
                            trans.Rollback();
                            return false; 
                        }
                    }

                    if (allergies != null && allergies.Count > 0)
                    {

                        foreach (var allergy in allergies)
                        {
                            allergy.RecordID = medicalRecordID;

                            int allergyID = AllergyDAL.AddAllergie(allergy, conn, trans);
                            if (allergyID <= 0)
                            {
                                trans.Rollback();
                                return false;
                            }
                        }
                    }

                    trans.Commit();
                    conn.Close();


                    return true;


                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }

        }

    }
}
               
