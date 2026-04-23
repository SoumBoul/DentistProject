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
    public class EmployeDAL
    {
        static public string connectionString = "server=.;database=DentisteDB;Integrated Security=True;";
        static public int AddEmploye(int PersonID, SqlConnection conn, SqlTransaction trans)
        {
            int EmployeID = 0;

            using (SqlCommand cmd = new SqlCommand("sp_AddEmploye", conn, trans))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonID", PersonID);

                SqlParameter OutputID = new SqlParameter("@EmployeID", SqlDbType.Int);
                OutputID.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(OutputID);



                var RowAffected = cmd.ExecuteNonQuery();
                if (OutputID.Value != DBNull.Value)
                {
                    EmployeID = (int)OutputID.Value;
                }
            }

            return EmployeID;
        }

        static public int UpdateEmploye(int PersonID, SqlConnection conn, SqlTransaction trans)
        {
            int EmployeID = 0;

            using (SqlCommand cmd = new SqlCommand("sp_AddEmploye", conn, trans))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonID", PersonID);

                SqlParameter OutputID = new SqlParameter("@EmployeID", SqlDbType.Int);
                OutputID.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(OutputID);



                var RowAffected = cmd.ExecuteNonQuery();
                if (OutputID.Value != DBNull.Value)
                {
                    EmployeID = (int)OutputID.Value;
                }
            }

            return EmployeID;
        }

        static public EmployeDTO FindEmployeByID(int PersonID)
        {
            EmployeDTO dto = new EmployeDTO();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_FindEmployeByPersonID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dto = new EmployeDTO
                            {
                                EmployeID = reader.GetOrdinal("EmployeID"),



                            };




                        }


                    }

                    return dto;

                }






            }

        }
    }
}

















        

    


