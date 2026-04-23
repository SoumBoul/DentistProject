using System;

namespace DTO_Framwork
{
    public class PersonDTO
    {
        public int PersonID { get; set; }

        public string NationalNumber { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Adresse { get; set; }

        public string Image { get; set; }


        public PersonDTO()
        {
        }


        public PersonDTO(int personId,string NationalNumber, string firstname, string lastname, DateTime datePfBirth, string phone,
            string email, string adresse, string image)
        {
            this.PersonID = personId;
            this.NationalNumber = NationalNumber;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.DateOfBirth = datePfBirth;
            this.Phone = phone;
            this.Email = email;
            this.Adresse = adresse;
            this.Image = image;


        }
    }



    
}

