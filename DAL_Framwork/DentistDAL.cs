using DTO_Framwork;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_Framwork
{
    public class DentistDAL
    {
        static public string connectionString = "server=.;database=DentisteDB;Integrated Security=True;";

        static public List<DentistDTO> GetListDentists()
        {
            List<DentistDTO> Dentists = new List<DentistDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetAllDentists", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            var MyList = new DentistDTO()
                            {

                                DentistID = Convert.ToInt32(reader["DentistID"]),
                                FullName = Convert.ToString(reader["FullName"]),
                                Email = Convert.ToString(reader["Email"]),
                                Phone = Convert.ToString(reader["Telephone"]),
                                Specialisation = Convert.ToString(reader["Specialization"]),
                                Image = Convert.ToString(reader["Image"] != DBNull.Value ? Convert.ToString(reader["Image"]) : " "),
                                CreatedAT = Convert.ToDateTime(reader["CreatedAt"].ToString())

                            };
                            Dentists.Add(MyList);

                        }


                    }
                }

                return Dentists;
            }
        }
        static public List<DentistDTO> GetInfoDentistsForAppointments()
        {
            List<DentistDTO> Dentists = new List<DentistDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetInfoDentistForAppointments", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            var MyList = new DentistDTO()
                            {


                                FullName = Convert.ToString(reader["FullName"]),

                                Specialisation = Convert.ToString(reader["Specialization"]),
                                Image = Convert.ToString(reader["Image"] != DBNull.Value ? Convert.ToString(reader["Image"]) : " "),
                               // CreatedAT = Convert.ToDateTime(reader["CreatedAt"].ToString())

                            };
                            Dentists.Add(MyList);

                        }


                    }
                }

                return Dentists;
            }
        }
        static public int AddDentist(DentistDTO dentist, SqlConnection conn, SqlTransaction trans)
        {
            int dentistID = 0;

            using (SqlCommand cmd = new SqlCommand("sp_AddDentist", conn, trans))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Specialization", dentist.Specialisation);
                cmd.Parameters.AddWithValue("@CreatedAT", dentist.CreatedAT);
                cmd.Parameters.AddWithValue("@PersonID", dentist.PersonID);

                SqlParameter OutputID = new SqlParameter("@DentistID", SqlDbType.Int);
                OutputID.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(OutputID);


                var RowAffected = cmd.ExecuteNonQuery();
                if (OutputID.Value != DBNull.Value)
                {
                    dentistID = (int)OutputID.Value;
                }
            }

            return dentistID;
        }
        static public bool UpdateDentist(DentistDTO dentist, SqlConnection conn, SqlTransaction trans)
        {
            bool isUpdated = false;

            using (SqlCommand cmd = new SqlCommand("sp_UpdateDentist", conn, trans))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Specialization", dentist.Specialisation);
                cmd.Parameters.AddWithValue("@CreatedAT", dentist.CreatedAT);
                cmd.Parameters.AddWithValue("@PersonID", dentist.PersonID);


                var RowAffected = cmd.ExecuteNonQuery();
                if (RowAffected > 0)
                {
                    isUpdated = true;
                    return true;
                }
            }

            return false;
        }
        static public DentistDTO FindDentistWithID(int dentistId)
        {
            DentistDTO dto = new DentistDTO();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_FindDentistWidID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DentistID", dentistId);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dto = new DentistDTO
                            {
                                
                                Image = reader.GetString(reader.GetOrdinal("Image")),
                                DentistID = reader.GetInt32(reader.GetOrdinal("DentistID")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Phone = reader.GetString(reader.GetOrdinal("Telephone")),
                                Specialisation = reader.GetString(reader.GetOrdinal("Specialization")),
                                PersonID=  reader.GetInt32(reader.GetOrdinal("PersonID")),

                            };

                        }

                    }

                    return dto;

                }

            }

        }
        static public List<DentistDTO> FilterDentistWithFullName(string text)
        {
            List<DentistDTO> dentists = new List<DentistDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand("sp_FilterDentistWithFullName", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SearchValue", text);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DentistDTO dto = new DentistDTO()
                            {
                                DentistID = Convert.ToInt32(reader["DentistID"]),
                                Image = Convert.ToString(reader["Image"]),
                                FullName = Convert.ToString(reader["FullName"]),
                                Phone = Convert.ToString(reader["Telephone"]),
                                Email = Convert.ToString(reader["Email"]),
                                Specialisation = Convert.ToString(reader["Specialization"]),
                                //CreatedAT= Convert.ToDateTime(reader[("CreatedAT")].ToString()),


                            };


                            dentists.Add(dto);
                        }
                    }
                    return dentists;
                }



            }


        }
        static public List<DentistDTO> FilterDentistWithEmail(string text)
        {
            List<DentistDTO> dentists = new List<DentistDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand("sp_FilterDentistWithEmail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", text);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DentistDTO dto = new DentistDTO()
                            {
                                Image = Convert.ToString(reader["Image"]),
                                FullName = Convert.ToString(reader["FullName"]),
                                Phone = Convert.ToString(reader["Telephone"]),
                                Email = Convert.ToString(reader["Email"]),
                                Specialisation = Convert.ToString(reader["Specialization"]),
                                //CreatedAT=


                            };


                            dentists.Add(dto);
                        }
                    }
                    return dentists;
                }



            }

        }
        static public List<DentistDTO> FilterDentistWithSpecialization(string text)
        {
            List<DentistDTO> dentists = new List<DentistDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand("sp_Filter_Dentist_With_Specialization", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@text", text);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DentistDTO dto = new DentistDTO()
                            {
                                Image = Convert.ToString(reader["Image"]),
                                FullName = Convert.ToString(reader["FullName"]),
                                Phone = Convert.ToString(reader["Telephone"]),
                                Email = Convert.ToString(reader["Email"]),
                                Specialisation = Convert.ToString(reader["Specialization"]),
                                //CreatedAT=


                            };


                            dentists.Add(dto);
                        }
                    }
                    return dentists;
                }



            }

        }
        static public List<DentistDTO> FilterDentistWithID(int id)
        {
            List<DentistDTO> dentists = new List<DentistDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand("sp_Filter_Dentist_With_ID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DentistDTO dto = new DentistDTO()
                            {
                                Image = Convert.ToString(reader["Image"]),
                                FullName = Convert.ToString(reader["FullName"]),
                                Phone = Convert.ToString(reader["Telephone"]),
                                Email = Convert.ToString(reader["Email"]),
                                Specialisation = Convert.ToString(reader["Specialization"]),
                                //CreatedAT=


                            };


                            dentists.Add(dto);
                        }
                    }
                    return dentists;
                }



            }

        }
        static public int FindDentistID(string name)
        {
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_FindDentistID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", name);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader["DentistID"]);
                        }
                    }

                    return id;


                }
            }
        }
        static  public bool  isDentisExist(int dentistID)
        {
            int id = 0;
            bool isExist = false;
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand("sp_IsDentistExist", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dentistID", dentistID);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader["DentistID"]);
                            if (id > 0)
                            {
                                return isExist = true;
                            }
                            else
                                return isExist = false;
                            
                           
                        }
                    }
                  
                }
               


            }
            return isExist;

        }
        static public int GetDentistYearsOfExperience(int PersonID)
        {
            int years = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetDentistExperienceYearsByPersonID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID",PersonID);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            years = Convert.ToInt32(reader["years"]);
                        }
                    }

                    return years;


                }
            }
        }




    }
}

