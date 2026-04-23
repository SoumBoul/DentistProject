using System;
using System.Collections.Generic;


namespace DTO_Framwork
{
    public class MutuellDTO
    {
        public int MutuelleID { get; set; }
        public string Compagnie { get; set; }
        public string NumeroAdherent { get; set; }
       
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public string NiveauCouverture { get; set; }
        public int PatientID { get; set; }
        public int MutuelleCompagnieID { get; set; }






    }
}
