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
    public class LoginDAL
    {
        static public string connectionString = "server=.;database=DentisteDB;Integrated Security=True;";

        static public bool  LoginWithUserNameAndPassword(string username, string password)
        {
            bool isFound = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Login", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    conn.Open();
                
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return isFound = true;

                        }
                        else
                            return isFound = false;


                    }

                  

                }

            }


        }
        static public string FindImageUser(string username)
        {
            string image = "";
          
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetImageUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
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
       


        }
}

