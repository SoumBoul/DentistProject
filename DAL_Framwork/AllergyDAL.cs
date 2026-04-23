using DTO_Framwork;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Framwork
{
    public  class AllergyDAL
    {
        static public string connectionString = "server=.;database= DentisteDB; user id=sa; password=123456; ";
        static public int AddAllergie(AllergyDto allergieDto, SqlConnection conn, SqlTransaction trans)
        {
            int AllergieID = 0;

           
                using (SqlCommand cmd = new SqlCommand("sp_AddAllergies", conn, trans))
                {
                    cmd.Transaction = trans;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AllergieName", allergieDto.AllergieName);
                    cmd.Parameters.AddWithValue("@DateAdded", allergieDto.DateAdded);
                    cmd.Parameters.AddWithValue("@EmployeID", allergieDto.EmployeID);
                    cmd.Parameters.AddWithValue("@RecordID", allergieDto.RecordID);

                    SqlParameter OutputID = new SqlParameter("@AllergieID", SqlDbType.Int);
                    OutputID.Direction = ParameterDirection.Output;

                    cmd.Parameters.Add(OutputID);

                  
                    var RowAffected = cmd.ExecuteNonQuery();
                    if (OutputID.Value != DBNull.Value)
                    {
                        AllergieID = (int)OutputID.Value;

                    }


                }


                return AllergieID;




            }
        static public List<AllergyDto >FindAllergyByRecordID(int RecordID)
        {

            AllergyDto Allergy = new AllergyDto();
            List<AllergyDto> all = new List<AllergyDto>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_FindAllergyByRecordID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RecordID",RecordID);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            var newAllergy = new AllergyDto
                            {
                                AllergieID = Convert.ToInt32(reader["AllergieID"]),
                                AllergieName = Convert.ToString(reader["AllergieName"]),
                                DateAdded = Convert.ToDateTime(reader["DateAdded"]),
                                EmployeID = Convert.ToInt32(reader["EmployeID"]),
                                RecordID = Convert.ToInt32(reader["RecordID"]),
                               
                            };


                            Allergy = newAllergy;
                            all.Add(Allergy);

                        }

                    }


                }
                return all;
            }

        }
        static public bool UpdateAllergie(AllergyDto allergieDto)
        {
            bool IsUpdate=  false;

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateAllergies", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AllergieName", allergieDto.AllergieName);
                    cmd.Parameters.AddWithValue("@DateAdded", allergieDto.DateAdded);
                    cmd.Parameters.AddWithValue("@EmployeID", allergieDto.EmployeID);
                    cmd.Parameters.AddWithValue("@RecordID", allergieDto.RecordID);
                    cmd.Parameters.AddWithValue("@AllergieID", allergieDto.AllergieID);

                    conn.Open();

                    var RowAffected = cmd.ExecuteNonQuery();

                    if (RowAffected > 0)
                    {
                        return IsUpdate = true;
                    }


                }


            }


            return IsUpdate;




        }








    }
                

    
}
