using PSSC.Models.CommonComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSSC.Models.FarmacistComponents
{
    public class NrTelefon
    {
        private Text nrTelefonText;

        public NrTelefon(Text nrTel)
        {

           nrTelefonText = nrTel;
        }
        public Text getNrTelefon{ get { return nrTelefonText; } }
    }
}
