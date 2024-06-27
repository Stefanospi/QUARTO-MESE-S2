using ES_G3_G4.Class;
using System.ComponentModel.DataAnnotations;

namespace ES_G3_G4.Models
{
    public class AcquistoDati
    {
        [Display(Name = "Nome")]
        public string name { get; set; }
        [Display(Name = "Cognome")]
        public string surname { get; set; }
        [Display(Name = "Tipo Biglietto")]
        public Biglietto tipoBiglietto { get; set; }
        
        [Display(Name = "Sala")]
        public List<Sala> Sale { get; set; }

    }
}
