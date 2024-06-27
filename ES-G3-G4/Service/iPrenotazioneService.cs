using ES_G3_G4.Class;

namespace ES_G3_G4.Service
{
    public interface iPrenotazioneService
    {
        public void PrenotaBiglietto(AddettoBot addettoBot);

        public List<AddettoBot> addettoBots { get; set; }



    }
}
