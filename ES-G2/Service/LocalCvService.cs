using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_G2.Service
{
    public class LocalCvService : iCv
    {
        private readonly Cv cv = new Cv();

        // Aggiunge un'esperienza al CV
        public void aggiungiEsperienza(Esperienze Esperienza)
        {
            cv.Impiego.Add(Esperienza);
        }

        // Aggiunge un titolo di studio al CV
        public void AggiungiTitoloStudio(Studi TitoloStudio)
        {
            cv.Studi.Add(TitoloStudio);
        }

        // Aggiunge le informazioni personali al CV
        public void AggiungiInformazioniPersonali(InformazioniPersonali InformazioniPersonali)
        {
            cv.PersonalInfo = InformazioniPersonali;
        }

        // Crea il CV
        public Cv CreaCv()
        {
            return cv;
        }
    }
}
