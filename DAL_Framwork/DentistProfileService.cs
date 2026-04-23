using System;
using DTO_Framwork;
using DAL_Framwork;

namespace DAL_Framwork
{
    public  class DentistProfileService
    {
        static public DentistRegistrationDto DentistProfil( int dentistID )
        {
            DentistRegistrationDto dto = new DentistRegistrationDto();
            dto.dentist = DentistDAL.FindDentistWithID(dentistID);
            int Personid = dto.dentist.PersonID;

            dto.person = PersonDAL.FindPersonByID(Personid);
          
            
           
                return dto;



        }

        


    }
}
