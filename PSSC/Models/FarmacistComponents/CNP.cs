using PSSC.Models.CommonComponents;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace PSSC.Models.FarmacistComponents
{
    public class CNP
    {
        private Text cnpText; 

        public CNP(Text cnp)
        {
            
            cnpText = cnp;
        }
        public Text getCNP { get { return cnpText; } }
        
    }
}
