using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_G2.Service
{
    // Definizione dell'interfaccia iCv
    public interface iCv
    {
        // Metodo per aggiungere un titolo di studio al CV
        void AggiungiTitoloStudio(Studi TitoloStudio);

        // Metodo per aggiungere un'esperienza al CV
        void aggiungiEsperienza(Esperienze Esperienza);

        // Metodo per aggiungere informazioni personali al CV
        void AggiungiInformazioniPersonali(InformazioniPersonali InformazioniPersonali);

        // Metodo per creare il CV
        Cv CreaCv();
    }
}
