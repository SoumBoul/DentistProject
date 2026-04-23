using System;
using System.IO;

namespace DTO_Framwork
{
    public class InvoiceDTO
    {
        public decimal Montant { get; set; }
        public decimal Taxe { get; set; }
        public int MutuelleID { get; set; }
        public int RdvID { get; set; }
        public int InvoiceStatusID { get; set; }
        public int InvoiceID { get; set; }
       

       

    }
}
