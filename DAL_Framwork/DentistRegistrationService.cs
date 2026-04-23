using System;
using System.Data.SqlClient;
using DAL_Framwork;
using DTO_Framwork;

namespace DAL_Framwork
{
    public class DentistRegistrationService
    {
        static public string connectionString = "server=.;database=DentisteDB;Integrated Security=True;";

        static  public int AddDentistWithTransaction(PersonDTO person, DentistDTO dentist)
        {
            int dentistID = 0;
            
           using(SqlConnection conn= new SqlConnection(connectionString))
            {
                conn.Open();
               
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    int PersonID = PersonDAL.AddPerson(person, conn, trans);
                    if (PersonID < 0)
                    {
                        trans.Rollback();
                    }


                    int EmployeID = EmployeDAL.AddEmploye(PersonID, conn, trans);

                    if (EmployeID < 0)
                    {
                        trans.Rollback();
                    }

                  
                    dentist.PersonID = PersonID;

                    dentistID = DentistDAL.AddDentist(dentist, conn, trans);
                    if (dentistID < 0)
                    {
                        trans.Rollback();
                    }


                }
                catch
                {
                    trans.Rollback();


                }
                trans.Commit();
            }

            return dentistID;



        }
        static public bool UpdateDentistWithTransaction(PersonDTO person, DentistDTO dentist)
        {
            int dentistID = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                  bool isPersonUpdated= PersonDAL.UpdatePerson(person, conn, trans);
                    if (isPersonUpdated == false)
                    {
                        trans.Rollback();
                    }

                    dentist.PersonID = person.PersonID;

                    bool isDentistUpdated = DentistDAL.UpdateDentist(dentist, conn, trans);

                    if (isDentistUpdated == false)
                    {
                        trans.Rollback();
                    }

                    trans.Commit();
                    return true;

                }
                catch
                {
                    trans.Rollback();
                }
                trans.Commit();
            }

            return false; ;

        }

        static  bool GetDentistsProfile(PersonDTO person, DentistDTO dentist)
        {
            int dentistID = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    bool isPersonExist = PersonDAL.IsPersonExist(person.PersonID);
                    if (isPersonExist == false)
                    {
                        trans.Rollback();
                    }

                    dentist.PersonID = person.PersonID;

                    bool isDentistUpdated = DentistDAL.isDentisExist(dentist.DentistID);

                    if (isDentistUpdated == false)
                    {
                        trans.Rollback();
                    }

                    trans.Commit();
                    return isDentistUpdated;

                }
                catch
                {
                    trans.Rollback();


                }
                trans.Commit();
            }

            return false; ;



        }






    }
}

