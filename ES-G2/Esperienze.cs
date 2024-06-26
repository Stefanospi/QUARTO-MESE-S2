using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_G2
{

    //- Class Esperienza [azienda, jobTitle, dal, al, descrizione, compiti].
    public class Esperienze
    {
        public string Azienda { get; set; }
        public string JobTitle { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
        public string Descrizione { get; set; }
        public string Compiti { get; set; }
    }
}
