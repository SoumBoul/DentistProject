using System;
using System.Data.SqlClient;
using System.Data;
using DTO_Framwork;

namespace DAL_Framwork
{
    public class InvoiceDAL
    {
        static public string connectionString = "server=.;database=DentisteDB;Integrated Security=True;";

       static  public int InsertInvoice(InvoiceDTO invoiceDTO)
        {

            int InvoiceID = -1;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertInvoice", conn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Montant", invoiceDTO.Montant);
                        cmd.Parameters.AddWithValue("@Taxe", invoiceDTO.Taxe);
                        cmd.Parameters.AddWithValue("@MutuelleID", invoiceDTO.MutuelleID);
                        cmd.Parameters.AddWithValue("@RdvID", invoiceDTO.RdvID);
                        cmd.Parameters.AddWithValue("@InvoiceStatusID", invoiceDTO.InvoiceStatusID);

                        SqlParameter output = new SqlParameter("@InvoiceID", SqlDbType.Int);
                    
                        output.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(output);

                        conn.Open();
                        var RowAffected = cmd.ExecuteNonQuery();
                    if (output.Value!= DBNull.Value)
                        {
                        InvoiceID = (int)output.Value;

                        }

                    }


                }


                return InvoiceID;




            }


        }




    
}

