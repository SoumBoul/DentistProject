using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Framwork
{
    public class TreatmentDTO
    {
        public int TreatmentID { get; set; }

        public int RdvID { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int TreatmentDetailsID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int TreatmentTypeID { get; set; }


    }
}
