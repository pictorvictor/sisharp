using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credite
{
    [Serializable]
    public class Client
    {
        [Required(ErrorMessage = "Introdu CNP")]
        [RegularExpression("^[0-9]{13}$", ErrorMessage = "CNP invalid")]
        public string cnp { get; set; }
        [Required(ErrorMessage = "Introdu Nume")]
        public string nume { get; set; }
        [Required(ErrorMessage = "Introdu Prenume")]
        public string prenume { get; set; }

        [Required(ErrorMessage = "Introdu Email")]
        [EmailAddress(ErrorMessage = "Email-ul trebuie sa fie valid")]
        public string email { get; set; }
        [Required(ErrorMessage = "Alege un credit")]
        public Credit credit { get; set; }
        public Client() 
        {
            this.email = string.Empty;
            this.credit = new Credit();
            this.cnp = string.Empty;
            this.nume = string.Empty;
            this.prenume = string.Empty;
        }

        Client(string cnp, string nume, string prenume, string email, Credit credit)
        {
            this.cnp = cnp;
            this.nume = nume;
            this.prenume = prenume;
            this.email = email;
            this.credit = credit;
        }



        public override string ToString()
        {
            return "Clientul cu CNP " + cnp + " are un " + credit;
        }
    }
}
