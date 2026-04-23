using System;
using System.Data.SqlClient;
using System.Data;
using DTO_Framwork;

namespace DAL_Framwork
{
    public class MutuelleDAL
    {
        static public string connectionString = "server=.;database=DentisteDB;Integrated Security=True;";
        static public int AddMutuelle(MutuellDTO mutuelle, SqlConnection conn, SqlTransaction trans)
        {


            int MutuelleID = 0;
            using (conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_AddMutuelle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@NumeroAdherent", mutuelle.NumeroAdherent);
                    cmd.Parameters.AddWithValue("@DateDebut", mutuelle.DateDebut);
                    cmd.Parameters.AddWithValue("@DateFin", mutuelle.DateFin);
                    cmd.Parameters.AddWithValue("@NiveauCouverture", mutuelle.NiveauCouverture);
                    cmd.Parameters.AddWithValue("@PatientID", mutuelle.PatientID);
                    cmd.Parameters.AddWithValue("@MutuelleCompagnieID", mutuelle.MutuelleCompagnieID);

                    SqlParameter OutputID = new SqlParameter("MutuelleID", SqlDbType.Int);
                    OutputID.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(OutputID);



                    conn.Open();

                    var RowAffected = cmd.ExecuteNonQuery();
                    if (OutputID != null)
                    {

                        MutuelleID = (int)OutputID.Value;
                    }



                }

                return MutuelleID;

            }

        }
        static public MutuellDTO FindMutuelleByPatientID(int PatientID)
        {
            MutuellDTO dto = new MutuellDTO();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_FindMutuelleByID",conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new MutuellDTO()
                            {
                                MutuelleID= Convert.ToInt32(reader["MutuelleID"]),
                                NumeroAdherent = Convert.ToString(reader["NumeroAdherent"]),
                                DateDebut = Convert.ToDateTime(reader["DateDebut"]),
                                DateFin = Convert.ToDateTime(reader["DateFin"]),
                                NiveauCouverture = Convert.ToString(reader["NiveauCouverture"]),
                                PatientID = Convert.ToInt32(reader["PatientID"]),
                                MutuelleCompagnieID = Convert.ToInt32(reader["MutuelleCompagnieID"]),
                            };

                        }


                    }

                    return dto;

                }








            }
        }
        static public bool UpdateMutuelle(MutuellDTO mutuelle, SqlConnection conn, SqlTransaction trans)
        {


            int MutuelleID = 0;
            using (conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateMutuelle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PatientID", mutuelle.PatientID);
                    cmd.Parameters.AddWithValue("@MutuelleID", mutuelle.MutuelleID);
                    cmd.Parameters.AddWithValue("@NumeroAdherent", mutuelle.NumeroAdherent);
                    cmd.Parameters.AddWithValue("@DateDebut", mutuelle.DateDebut);
                    cmd.Parameters.AddWithValue("@DateFin", mutuelle.DateFin);
                    cmd.Parameters.AddWithValue("@NiveauCouverture", mutuelle.NiveauCouverture);
                    
                    cmd.Parameters.AddWithValue("@MutuelleCompagnieID", mutuelle.MutuelleCompagnieID);

                 
                    conn.Open();

                    var RowAffected = cmd.ExecuteNonQuery();
                    if (RowAffected > 0)
                    {

                        MutuelleID = RowAffected;
                        return true;
                    }
                    else
                        return false;



                }

              

            }

        }

    }
}

