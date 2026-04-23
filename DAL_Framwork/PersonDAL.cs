using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO_Framwork;

namespace DAL_Framwork
{
    public class PersonDAL
    {

        public PersonDTO person;
        static public string connectionString = "server=.;database=DentisteDB;Integrated Security=True;";
        static public List<PersonDTO> GetAllPeople()
        {

            List<PersonDTO> people = new List<PersonDTO>();


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetAllPeople", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            var v = (new PersonDTO
                            {
                                //PersonID = reader.GetInt32(reader.GetOrdinal("PersonID").ToString()),
                                //Nom = reader.GetString(reader.GetOrdinal("Nom").ToString()),
                                //Prenom = reader.GetString(reader.GetOrdinal("Prenom").ToString()),
                                //DateNaissance = reader.GetDateTime(reader.GetOrdinal("DateDeNaissance")),
                                //Telephone = reader.GetString(reader.GetOrdinal("Telephone").ToString()),
                                //Email = reader.GetString(reader.GetOrdinal("Email").ToString()),
                                //Adresse = reader.GetString(reader.GetOrdinal("Adresse").ToString()),
                                //Image = reader.GetString(reader.GetOrdinal("Image").ToString())


                            });
                            people.Add(v);


                        }
                    }
                }

                return people;
            }

        }
        static public int AddPerson(PersonDTO person, SqlConnection conn, SqlTransaction trans)
        {

            int PersonId = 0;

            using (SqlCommand cmd = new SqlCommand("sp_AddPerson", conn, trans))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = trans;
                cmd.Parameters.AddWithValue("@NationalNumber", person.NationalNumber);
                cmd.Parameters.AddWithValue("@Nom", person.FirstName);
                cmd.Parameters.AddWithValue("@Prenom", person.LastName);
                cmd.Parameters.AddWithValue("@DateNaissance", person.DateOfBirth);
                cmd.Parameters.AddWithValue("@Telephone", person.Phone);
                cmd.Parameters.AddWithValue("@Email", person.Email);
                cmd.Parameters.AddWithValue("@Adresse", person.Adresse);
                cmd.Parameters.AddWithValue("@image", person.Image == null ? " " : person.Image);

                SqlParameter outputId = new SqlParameter("@PersonID", SqlDbType.Int);
                outputId.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(outputId);

                var RowAffected = cmd.ExecuteNonQuery();
                if (outputId.Value != DBNull.Value)
                {

                    PersonId = (int)outputId.Value;
                }

            }

            return PersonId;

        }
        static public PersonDTO FindPersonByID(int PersonID)
        {
            PersonDTO dto = new PersonDTO();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_FindPersonByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new PersonDTO()
                            {
                                PersonID = Convert.ToInt32(reader[("PersonID")]),
                                NationalNumber = reader["NationalNumber"].ToString(),
                                FirstName = reader[("Nom")].ToString(),
                                LastName = reader[("Prenom")].ToString(),
                                DateOfBirth = Convert.ToDateTime(reader["DateNaissance"]),
                                Phone = reader[("Telephone")].ToString(),
                                Email = reader[("Email")].ToString(),
                                Adresse = reader[("Adresse")].ToString(),
                                Image = reader[("Image")].ToString(),
                            };

                        }


                    }

                    return dto;

                }

            }


        }
        static public PersonDTO FindPersonByPhone(string phone)
        {
            PersonDTO dto = new PersonDTO();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("FindPatientByPhone", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new PersonDTO()
                            {
                                PersonID = Convert.ToInt32(reader[("PersonID")]),
                                NationalNumber = reader[("NationalNumber")].ToString(),
                                FirstName = reader[("Nom")].ToString(),
                                LastName = reader[("Prenom")].ToString(),
                                DateOfBirth = Convert.ToDateTime(reader["DateNaissance"]),
                                Phone = reader[("Telephone")].ToString(),
                                Email = reader[("Email")].ToString(),
                                Adresse = reader[("Adresse")].ToString(),
                                Image = reader[("Image")].ToString(),
                            };

                        }


                    }

                    return dto;

                }

            }


        }
        static public bool UpdatePerson(PersonDTO person, SqlConnection conn, SqlTransaction trans)
        {
            using (SqlCommand cmd = new SqlCommand("sp_UpdatePerson", conn, trans))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PersonID", person.PersonID);
                cmd.Parameters.AddWithValue("@NationalNumber", person.NationalNumber);

                cmd.Parameters.AddWithValue("@Nom", person.FirstName);
                cmd.Parameters.AddWithValue("@Prenom", person.LastName);
                cmd.Parameters.AddWithValue("@DateDeNaissance", person.DateOfBirth);
                cmd.Parameters.AddWithValue("@Telephone", person.Phone);
                cmd.Parameters.AddWithValue("@Email", person.Email);
                cmd.Parameters.AddWithValue("@Addresse", person.Adresse);
                cmd.Parameters.AddWithValue("@Image", person.Image == null ? " " : person.Image);



                int RowAffected = cmd.ExecuteNonQuery();

                return RowAffected > 0;

            }



        }
        static public bool IsPersonExist(int personID)
        {
            bool isExist = false;
            int id = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_IsPersonExist", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@personID", personID);

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


                    return isExist;


                }
            }
        }
        static public bool IsNationalNumberExist(string NoNumber)
        {
            bool isExist = false;
            int id = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_FindPersonWithNationalNum", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NOnumber", NoNumber);

                    conn.Open();

                    var d = cmd.ExecuteScalar();




                    if (d != null)
                    {
                        return isExist = true;
                    }
                    else
                        return isExist = false;
                }
            }


            return isExist;


        }
        static public PersonDTO FindPersonByFullName(string FullName)
        {
            PersonDTO dto = new PersonDTO();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_FindPersonByFullName", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FullName", FullName);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new PersonDTO()
                            {
                                PersonID = Convert.ToInt32(reader[("PersonID")]),
                                NationalNumber = reader[("NationalNumber")].ToString(),
                                FirstName = reader[("Nom")].ToString(),
                                LastName = reader[("Prenom")].ToString(),
                                DateOfBirth = Convert.ToDateTime(reader["DateNaissance"]),
                                Phone = reader[("Telephone")].ToString(),
                                Email = reader[("Email")].ToString(),
                                Adresse = reader[("Adresse")].ToString(),
                                Image = reader[("Image")].ToString(),
                            };

                        }


                    }

                    return dto;

                }

            }


        }
        static public int FindPersonIDByUserName(string username)
        {
            int id = -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("FindPersonIDByUserName", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    conn.Open();

                    var result = cmd.ExecuteScalar();
                       
                            id = Convert.ToInt32(result);


                      
                    

                    return id;

                }

            }






        }
        static public int GetPersonIDByFullName(string FullName)
        {
            int id = -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetPersonIDbyFullName", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FullName", FullName);
                    conn.Open();

                    var result = cmd.ExecuteScalar();

                    id = Convert.ToInt32(result);





                    return id;

                }

            }






        }



    }
}

