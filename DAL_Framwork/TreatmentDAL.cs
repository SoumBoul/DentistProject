using DTO_Framwork;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;


namespace DAL_Framwork
{
    public class TreatmentDAL
    {
        static public string connectionString = "server=.;database= DentisteDB; user id=sa; password=123456; ";

        static public int InsertTreatment(TreatmentDTO treatmentDTO)
        {
            int TreatmentID = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertTreatmentDetails", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.AddWithValue("@TreatmentID", treatmentDTO.TreatmentID);
                    cmd.Parameters.AddWithValue("@Description", treatmentDTO.Description);
                    cmd.Parameters.AddWithValue("@Quantity", treatmentDTO.Quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", treatmentDTO.UnitPrice);
                    cmd.Parameters.AddWithValue("@TotalPrice", treatmentDTO.TotalPrice);
                    cmd.Parameters.AddWithValue("@TreatmentTypeID", treatmentDTO.TreatmentTypeID);



                    SqlParameter OutputID = new SqlParameter("@TreatmentDetailsID", SqlDbType.Int);
                    OutputID.Direction = ParameterDirection.Output;

                    cmd.Parameters.Add(OutputID);
                    conn.Open();

                    var RowAffected = cmd.ExecuteNonQuery();
                    if (OutputID.Value != DBNull.Value)
                    {
                        TreatmentID = (int)OutputID.Value;

                    }


                }



            }


            return TreatmentID;




        }
        static public decimal GetPriceOfTreatment(int TreatmentID)
        {
            int id = -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetPriceOfTreatment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TreatmentsID", TreatmentID);
                    conn.Open();

                    var result = cmd.ExecuteScalar();

                    id = Convert.ToInt32(result);




                    return id;

                }

            }




        }
    }
}
