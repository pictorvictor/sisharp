using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credite
{
    [Serializable]
    public class Credit
    {
        [Required(ErrorMessage = "Introdu rata dobanzii")]
        [Range(5, 25, ErrorMessage = "Rata dobanzii a creditului trebuie sa fie intre 5% si 25%")]
        public int rataDobanda { get; set;}
        [Required(ErrorMessage = "Introdu durata")]
        [Range(1, 30, ErrorMessage = "Durata creditului trebuie sa fie intre 1 si 30 ani")]
        public int durata { get; set; }
        [Required(ErrorMessage = "Introdu valoarea")]
        [Range(100, 100000, ErrorMessage = "Valoarea creditului trebuie sa fie intre 100 si 100000 lei")]
        public int valoare { get; set; }

        public Credit()
        {
            this.valoare = 0;
            this.durata = 0;
            this.rataDobanda = 0;
        }

        public Credit(int rataDobanda, int durata, int valoare)
        {
            this.rataDobanda = rataDobanda;
            this.durata = durata;
            this.valoare = valoare;
        }

        public override string ToString()
        {
            return "credit in valoare de " + valoare +" cu rata de " + rataDobanda + "% si este pe o durata de " + durata + " ani.";
        }


    }
}
