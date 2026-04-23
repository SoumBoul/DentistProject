
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DTO_Framwork;


namespace DAL_Framwork
{
    public class PatientsDAL
    {

        static public string connectionString = "server=.;database=DentisteDB;Integrated Security=True;";

        static public List<PatientDTO> GetListPatients()
        {
            List<PatientDTO> Patients = new List<PatientDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetListPatients", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            var MyList = new PatientDTO()
                            {
                                Image = reader.IsDBNull(reader.GetOrdinal("Image")) ? " " : Convert.ToString(reader["Image"]),
                                PatientID = reader.IsDBNull(reader.GetOrdinal("PatientID")) ? 0 : Convert.ToInt32(reader["PatientID"]),
                                FullName = reader.IsDBNull(reader.GetOrdinal("FullName")) ? null : Convert.ToString(reader["FullName"]),
                                NumeroDeDossier = reader.IsDBNull(reader.GetOrdinal("NumeroDeDossier")) ? null : Convert.ToString(reader["NumeroDeDossier"]),
                                DateNaissance = Convert.ToDateTime(reader["DateNaissance"]),
                                Telephone = reader.IsDBNull(reader.GetOrdinal("Telephone")) ?
                                null : Convert.ToString(reader["Telephone"]),
                                DentisteFullName = reader.IsDBNull(reader.GetOrdinal("DentistFullName")) ? null : Convert.ToString(reader["DentistFullName"]),
                                Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? null : Convert.ToString(reader["Status"]),
                                Compagnie = reader.IsDBNull(reader.GetOrdinal("NomDeCompagnie")) ? null : Convert.ToString(reader["NomDeCompagnie"]),

                            };
                            Patients.Add(MyList);

                        }


                    }
                }

                return Patients;
            }

        }
        static public List<PatientDTO> GetListNewPatients()
        {
            List<PatientDTO> Patients = new List<PatientDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetListNewPatients", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            var MyList = new PatientDTO()
                            {
                                PatientID = Convert.ToInt32(reader["PatientID"]),
                                FullName = Convert.ToString(reader["FullName"]),
                                NumeroDeDossier = Convert.ToString(reader["NumeroDeDossier"]),
                                DateDeCreation = Convert.ToDateTime(reader["DateDeCreation"]),
                                NoteGenerale = Convert.ToString(reader["NoteGenerale"]),
                                //PersonID = Convert.ToInt32(reader["PersonID"]),
                                //DentistID = Convert.ToInt32(reader["DentisteID"]),

                            };
                            Patients.Add(MyList);

                        }


                    }
                }

                return Patients;
            }
        }
        static public int AddPatient(PatientDTO patient, SqlConnection conn, SqlTransaction trans)
        {


            int PatientID = 0;
           
                using (SqlCommand cmd = new SqlCommand("sp_AddPatient", conn, trans))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NumeroDeDossier", patient.NumeroDeDossier);
                    cmd.Parameters.AddWithValue("@DateDeCreation", patient.DateDeCreation);
                    cmd.Parameters.AddWithValue("@NoteGenerale", patient.NoteGenerale);
                    cmd.Parameters.AddWithValue("@PersonID", patient.PersonID);
                    cmd.Parameters.AddWithValue("@DentistID", patient.DentistID);


                    SqlParameter OutPutId = new SqlParameter("@PatientID", SqlDbType.Int);
                    OutPutId.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(OutPutId);


                   

                    var RowAffected = cmd.ExecuteNonQuery();
                    if (OutPutId.Value != DBNull.Value)
                    {

                        PatientID = (int)OutPutId.Value;
                    }

                }

                return PatientID;

            
        }
        static public PatientDTO FindPatientByID(int PatientID)
        {
            PatientDTO dto = new PatientDTO();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_FindPatientByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new PatientDTO()
                            {
                                PatientID = Convert.ToInt32(reader["PatientID"]),
                                NumeroDeDossier = Convert.ToString(reader["NumeroDeDossier"]),
                                DateDeCreation = Convert.ToDateTime(reader["DateDeCreation"]),
                                NoteGenerale = Convert.ToString(reader["NoteGenerale"]),
                                PersonID = Convert.ToInt32(reader["PersonID"]),
                                DentistID = Convert.ToInt32(reader["DentisteID"]),
                            };

                        }


                    }

                    return dto;

                }

            }

        }

        static public bool UpdatePatient(PatientDTO patient, SqlConnection conn, SqlTransaction trans)
        {



            
                using (SqlCommand cmd = new SqlCommand("sp_UpdatePatient", conn,trans))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@PatientID", patient.PatientID);
                    cmd.Parameters.AddWithValue("@NumeroDeDossier", patient.NumeroDeDossier);
                    cmd.Parameters.AddWithValue("@DateDeCreation", patient.DateDeCreation);
                    cmd.Parameters.AddWithValue("@NoteGenerale", patient.NoteGenerale);
                    cmd.Parameters.AddWithValue("@PersonID", patient.PersonID);
                    cmd.Parameters.AddWithValue("@DentistID", patient.DentistID);




                    var RowAffected = cmd.ExecuteNonQuery();

                    return RowAffected > 0;




                }



            
        }
        static public List<PatientDTO> FilterPatients_With_FullName(string text)
        {
            List<PatientDTO> Patients = new List<PatientDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand("sp_FilterPatients_With_FullName", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SearchValue", text);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PatientDTO dto = new PatientDTO()
                            {
                                PatientID = Convert.ToInt32(reader["PatientID"]),
                                NumeroDeDossier = Convert.ToString(reader["NumeroDeDossier"]),
                                FullName = Convert.ToString(reader["FullName"]),
                                DateNaissance = Convert.ToDateTime(reader["DateNaissance"]),
                                Telephone = Convert.ToString(reader["Telephone"]),
                                DentisteFullName = Convert.ToString(reader["DentistFullName"]),
                                Compagnie = Convert.ToString(reader["NomDeCompagnie"]),


                            };

                            Patients.Add(dto);
                        }
                    }
                    return Patients;
                }



            }


        }
        static public List<PatientDTO> FilterPatients_With_NumeroDeDossier(string text)
        {
            List<PatientDTO> Patients = new List<PatientDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand("sp_FilterPatients_With_NumeroDossier", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SearchValue", text);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PatientDTO dto = new PatientDTO()
                            {
                                PatientID = Convert.ToInt32(reader["PatientID"]),
                                NumeroDeDossier = Convert.ToString(reader["NumeroDeDossier"]),
                                FullName = Convert.ToString(reader["FullName"]),
                                DateNaissance = Convert.ToDateTime(reader["DateNaissance"]),
                                Telephone = Convert.ToString(reader["Telephone"]),
                                DentisteFullName = Convert.ToString(reader["DentistFullName"]),
                                Compagnie = Convert.ToString(reader["NomDeCompagnie"]),


                            };





                            Patients.Add(dto);
                        }
                    }
                    return Patients;
                }



            }
        }
        static public string FindImageByPatienID(int PatientID)
        {
            string image = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetImagePerson", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            image = Convert.ToString(reader["Image"]);


                        }


                    }

                    return image;

                }

            }

        }
        static public int FindPatientIdWithFolderNum(string name)
        {
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_FindPatientIDWithNumeroDeDossier", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@num", name);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader["PatientID"]);
                        }
                    }

                    return id;


                }
            }
        }
        static public int FindPatientIDByPersonID(int PersonID)
        {
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_FindPatientIDByPersonID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader["PatientID"]);
                        }
                    }

                    return id;


                }
            }
        }


    }
}

            
