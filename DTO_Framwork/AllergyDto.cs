using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Framwork
{
    public class AllergyDto
    {
        public int AllergieID { get; set; }
        public string AllergieName { get; set; }
        public DateTime DateAdded { get; set; }
        public int EmployeID { get; set; }
        public int RecordID { get; set; }

        public AllergyDto()
        {

        }
        public AllergyDto(AllergyDto dto)
        {
            AllergieName = dto.AllergieName;
            DateAdded = dto.DateAdded;
            EmployeID = dto.EmployeID;
            RecordID = dto.RecordID;

        }



    }
}
