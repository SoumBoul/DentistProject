
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Framwork
{
    public class PatientRegistrationDto
    {
        public PersonDTO person { get; set; }
        public PatientDTO patient { get; set; }
        public MutuellDTO mutuelle { get; set; }     
        public MedicalRecordDTO medicalRecordDto { get; set; }
        public List<AllergyDto> allergy { get; set; }


    }
}
