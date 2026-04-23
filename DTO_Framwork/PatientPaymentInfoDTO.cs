using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Framwork
{
    public  class PatientPaymentInfoDTO
    {
        public string PatientFullName { get; set; }
        public string DentistName { get; set; }
        public decimal Amount { get; set; }
        public float Reminder { get; set; }
        public string PaymentMethode { get; set; }
        public decimal Total { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int RdvID { get; set; }
    }
}
