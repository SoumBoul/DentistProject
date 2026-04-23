using DTO_Framwork;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;


namespace DAL_Framwork
{
    public class MedicalRecordDAL
    {

        static public string connectionString = "server=.;database=DentisteDB;Integrated Security=True;";
        static public List<MedicalRecordDTO> GetAllMedicalRecord()
        {

            List<MedicalRecordDTO> medicalRecord = new List<MedicalRecordDTO>();


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetAllMedicalRecord", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            var v = (new MedicalRecordDTO
                            {
                                RecordID = reader.GetInt32(reader.GetOrdinal("RecordID")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                Allergies = reader.GetString(reader.GetOrdinal("Allergies")),
                                MedicalHistory = reader.GetString(reader.GetOrdinal("MedicalHistory")),
                                CurrentMedicaments = reader.GetString(reader.GetOrdinal("CurrentMedications")),
                                Notes = reader.GetString(reader.GetOrdinal("Notes")),



                            });
                            medicalRecord.Add(v);


                        }
                    }
                }

                return medicalRecord;
            }
        }
        static public MedicalRecordDTO FindMedicalRecordByFullName(string name)
        {

           MedicalRecordDTO medicalRecord = new MedicalRecordDTO();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_FindMedicalRecordByFullName", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FullName", name);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            var newMedicalRecord = new MedicalRecordDTO
                            {
                                MedicalRecordNumber= Convert.ToString(reader["MedicalRecordNumber"]),
                                RecordID = Convert.ToInt32(reader["RecordID"]),
                                FullName = Convert.ToString(reader["FullName"]),
                                Allergies = Convert.ToString(reader["Allergies"]),
                                MedicalHistory = Convert.ToString(reader["MedicalHistory"]),
                                CurrentMedicaments = Convert.ToString(reader["CurrentMedications"]),
                                Notes = Convert.ToString(reader["Notes"]),
                            };


                            medicalRecord = newMedicalRecord;

                        }

                    }


                }
                return medicalRecord;
            }

        }
        static public int InsertMedicalRecord(MedicalRecordDTO medicalRecord, SqlConnection conn, SqlTransaction trans)
        {


            int medicalRecordID = 0;
           
                using (SqlCommand cmd = new SqlCommand("sp_InsertMedicalRecord", conn,trans))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PatientID", medicalRecord.PatientID);
                    cmd.Parameters.AddWithValue("@MedicalRecordNumber", medicalRecord.MedicalRecordNumber);
                    cmd.Parameters.AddWithValue("@Allergies", medicalRecord.Allergies == " " ? "" : medicalRecord.Allergies);
                    cmd.Parameters.AddWithValue("@MedicalHistory", medicalRecord.MedicalHistory);
                    cmd.Parameters.AddWithValue("@CurrentMedications", medicalRecord.CurrentMedicaments);
                    cmd.Parameters.AddWithValue("@Notes", medicalRecord.Notes);




                    SqlParameter OutPutId = new SqlParameter("@RecordID", SqlDbType.Int);
                    OutPutId.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(OutPutId);



                    var RowAffected = cmd.ExecuteNonQuery();
                    if (OutPutId.Value != DBNull.Value)
                    {

                        medicalRecordID = (int)OutPutId.Value;
                    }

                }

                return medicalRecordID;

            
        }
        static public bool UpdateMedicalRecord(MedicalRecordDTO medicalRecord, SqlConnection conn, SqlTransaction trans)
        {

            bool isUpDate = false;

            int medicalRecordID = 0;
           
                using (SqlCommand cmd = new SqlCommand("sp_UpdateMedicalRecords", conn,trans))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PatientID", medicalRecord.PatientID);
                    cmd.Parameters.AddWithValue("@MedicalRecordNumber", medicalRecord.MedicalRecordNumber);
                    cmd.Parameters.AddWithValue("@Allergies", medicalRecord.Allergies == " " ? "" : medicalRecord.Allergies);
                    cmd.Parameters.AddWithValue("@MedicalHistory", medicalRecord.MedicalHistory);
                    cmd.Parameters.AddWithValue("@CurrentMedications", medicalRecord.CurrentMedicaments);
                    cmd.Parameters.AddWithValue("@Notes", medicalRecord.Notes);


                 

                    var RowAffected = cmd.ExecuteNonQuery();
                    try
                    {
                        if (RowAffected > 0)
                        {
                            isUpDate = true;
                        }
                        else
                            isUpDate = false;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }


                return isUpDate;



            
        }
    }
}

