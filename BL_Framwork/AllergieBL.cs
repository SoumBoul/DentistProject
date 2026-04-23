using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Framwork;
using DTO_Framwork;

namespace BL_Framwork
{
    public class AllergieBL
    {

        
        static  List< AllergyDto> allergies { get; set; }
        static AllergyDto allergydto = new AllergyDto();


        static public List<AllergyDto> FindAllergieByRecordID(int RecordID)
        {

            return AllergyDAL.FindAllergyByRecordID(RecordID);

        }

       static  public bool UpdateAllergies(AllergyDto dto)
        {
            //dto = allergydto;
            return AllergyDAL.UpdateAllergie(dto) ;

        }



    }
}
