using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Framwork
{
    public class DentistDTO
    {
        public string Image { get; set; }
        public int DentistID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Specialisation { get; set; }    
        public DateTime CreatedAT { get; set; }
        public int PersonID { get; set; }
      

    }

    
}
