using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Framwork
{
    public class AppointmentDTO
    {
        public int RdvID { get; set; }
        public string FullName { get; set; }
        public DateTime RdvDate { get; set; }
        //public TimeSpan StartDate { get; set; }
        //public TimeSpan EndDate { get; set; }
        public TimeSpan NewStart { get; set; }
        public TimeSpan NewEnd { get; set; }
        public string DentistName { get; set; }
        public string Status { get; set; }
        public int DentistID { get; set; }
        public int PatientID { get; set; }
        public string NoteGenerale { get; set; }
        public string Specialisation { get; set; }
       
       





    }
}
