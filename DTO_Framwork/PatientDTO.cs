using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Framwork
{
    public class PatientDTO
    {
        public int PatientID { get; set; }
        public string NumeroDeDossier { get; set; }

        public string FullName { get; set; }

        public DateTime? DateNaissance { get; set; }

        public string Telephone { get; set; }

        public string DentisteFullName { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }

        public string Compagnie { get; set; }
        public string NoteGenerale { get; set; }
        public int PersonID { get; set; }
        public int DentistID { get; set; }

        public DateTime? DateDeCreation { get; set; }
        

        public string Nom { get; set; }
        public string Email { get; set; }

        public PatientDTO()
            {

            }

        public PatientDTO(int patientID, string numeroDeDossier,DateTime dateDeCreation, string noteGenerale,int personID, int dentistId)
        {
            this.PatientID = patientID;
            this.NumeroDeDossier = numeroDeDossier;
            this.DateDeCreation = dateDeCreation;
            this.NoteGenerale = noteGenerale;
            this.PersonID = personID;
            this.DentistID = dentistId;


        }



    }
}
