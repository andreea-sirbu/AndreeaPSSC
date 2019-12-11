using PSSC.Models.CommonComponents;
using PSSC.Models.FarmacistComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSSC.Models
{
    public class Farmacist
    {
        // Nume, Prenume, CNP, E-mail, NrTelefon, Adresa Farmacie
        private Text Nume, Prenume;
        private CNP cnp;
        private NrTelefon nrTelefon;
        private Email email;

        private AdresaFarmacie adresaFarmacie;
        public Farmacist(AdresaFarmacie adresa)
        {
            this.adresaFarmacie = adresa;



        }


    }


       
    }
}
