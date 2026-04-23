using DTO_Framwork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;

namespace DAL_Framwork
{
    public class AppointmentDAL
    {
        static public string connectionString = "server=.;database=DentisteDB;Integrated Security=True;";

        static public List<AppointmentDTO> GetAllApointments()
        {
            List<AppointmentDTO> Appointments = new List<AppointmentDTO>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ShowAllAppointments ", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            var MyList = new AppointmentDTO()
                            {
                                RdvID = Convert.ToInt32(reader["RdvID"]),
                                FullName = Convert.ToString(reader["FullName"]),
                                RdvDate = Convert.ToDateTime(reader["DateRdv"].ToString()),
                                NewStart = TimeSpan.Parse(reader["StartDate"].ToString()),
                                NewEnd = TimeSpan.Parse(reader["EndDate"].ToString()),
                                Status = Convert.ToString(reader["Status"]),
                                DentistID = reader["DentistID"] != DBNull.Value ? Convert.ToInt32(reader["DentistID"]) : 0,
                                DentistName = reader["DentistName"] != DBNull.Value ? reader["DentistName"].ToString() : " ",
                                NoteGenerale = Convert.ToString(reader["NoteGenerale"]),
                                Specialisation = reader["Specialization"] != DBNull.Value ? reader["Specialization"].ToString() : null,



                            };
                            Appointments.Add(MyList);

                        }


                    }
                }

                return Appointments;
            }




        }
        static public int InsertAppointment(AppointmentDTO appointment)
        {
            int RdvID = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertAppointment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DateRdv", appointment.RdvDate);
                    cmd.Parameters.AddWithValue("@StartDate", appointment.NewStart);
                    cmd.Parameters.AddWithValue("@EndDate", appointment.NewEnd);
                    cmd.Parameters.AddWithValue("@Status", appointment.Status);
                    cmd.Parameters.AddWithValue("@PatientID ", appointment.PatientID);
                    cmd.Parameters.AddWithValue("@DentistID ", appointment.DentistID);

                    SqlParameter OutputID = new SqlParameter("@RdvID", SqlDbType.Int);
                    OutputID.Direction = ParameterDirection.Output;

                    cmd.Parameters.Add(OutputID);

                    conn.Open();

                    var RowAffected = cmd.ExecuteNonQuery();
                    if (OutputID.Value != DBNull.Value)
                    {
                        RdvID = (int)OutputID.Value;

                    }
                }

            }


            return RdvID;




        }
        static public bool IsApppointmentIsValid(AppointmentDTO appointment)
        {

            bool RdvID = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_IsAppointmentExist", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DateRdv", appointment.RdvDate);
                    cmd.Parameters.AddWithValue("@NewStart", appointment.NewStart);

                    cmd.Parameters.AddWithValue("@NewEnd", appointment.NewEnd);

                    cmd.Parameters.AddWithValue("@DentistID ", appointment.DentistID);
                    cmd.Parameters.AddWithValue("@PatientID ", appointment.PatientID);

                    SqlParameter output = new SqlParameter("@IsExist", SqlDbType.Bit);
                    output.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(output);



                    conn.Open();

                    var result = cmd.ExecuteScalar();
                    bool isExist = Convert.ToBoolean(output.Value);
                    if (isExist == true)
                    {

                        return true;

                    }
                }

            }


            return RdvID;



        }
        static public List<AppointmentDTO> FilterAppointments_With_FullName(string text)
        {
            List<AppointmentDTO> appointments = new List<AppointmentDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand("sp_FilterAppointmentsWithFullName", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FullName", text);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AppointmentDTO dto = new AppointmentDTO()
                            {
                                RdvID = Convert.ToInt32(reader["RdvID"]),
                                FullName = Convert.ToString(reader["FullName"]),

                                RdvDate = Convert.ToDateTime(reader["DateRdv"]),
                                NewStart = TimeSpan.Parse(reader["StartDate"].ToString()),
                                NewEnd = TimeSpan.Parse(reader["EndDate"].ToString()),
                                Status = Convert.ToString(reader["Status"]),
                                DentistID = Convert.ToInt32(reader["DentistID"]),
                                DentistName = Convert.ToString(reader["DentistName"]),
                                NoteGenerale = Convert.ToString(reader["NoteGenerale"]),
                                Specialisation = Convert.ToString(reader["Specialization"]),
                            };

                            appointments.Add(dto);
                        }
                    }
                    return appointments;
                }



            }



        }
        static public int CountAppointments(int personID)
        {
            int count = -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_CountAppointmentsByDentistID ", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("PersonID",personID);

                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if(result !=null)
                    { 
                        count = Convert.ToInt32(result);


                    }
                }

                return count;
            }




        }

        static public bool UpdateStatusAppointment(int AppointmentID)
        {
            bool IsPaid= false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateAppointmentStatus", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RndvID",AppointmentID);

                    SqlParameter output = new SqlParameter("@IsPaied",SqlDbType.Bit);
                    output.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(output);

                    conn.Open();

                    var RowAffected = cmd.ExecuteScalar();
                    IsPaid =Convert.ToBoolean( output.Value);
                    if (IsPaid ==true)
                    {
                        return IsPaid = true;

                    }
                    else
                        IsPaid = false;
                }

            }

            return IsPaid;

        }

    }
}

