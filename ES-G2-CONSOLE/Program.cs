using ES_G2;
using ES_G2.Service;

internal class Program
{
    // Dichiarazione del servizio per la gestione del curriculum vitae
    private static iCv _service = new LocalCvService();

    // Metodo per stampare il curriculum vitae
    private static void Stampa(Cv cv)
    {
        Console.WriteLine("Curriculum Vitae:\n Nome: {0}\n Cognome:{1}\n ", cv.PersonalInfo.Nome, cv.PersonalInfo.Cognome);
        foreach (var titolo in cv.Studi)
        {
            Console.WriteLine("Titolo di studio: {0}\n Istituto: {1}\n Dal: {2}\n Al: {3}\n ", titolo.Qualifica, titolo.Istituto, titolo.Dal, titolo.Al);
        }
    }

    private static void Main(string[] args)
    {
        // Aggiunta di un titolo di studio al curriculum vitae
        _service.AggiungiTitoloStudio(new ES_G2.Studi
        {
            Qualifica = "Laurea in Informatica",
            Dal = new DateTime(2015, 10, 1),
            Al = new DateTime(2018, 10, 1),
            Istituto = "Università Di Catania"
        });

        // Aggiunta di un'esperienza lavorativa al curriculum vitae
        _service.aggiungiEsperienza(new ES_G2.Esperienze
        {
            Azienda = "Google",
            Dal = new DateTime(2018, 10, 1),
            Al = new DateTime(2020, 10, 1),
            Compiti = "Sviluppatore Software",
            Descrizione = "Sviluppo di software per la gestione di grandi quantità di dati",
            JobTitle = "Sviluppatore Software"
        });

        // Aggiunta delle informazioni personali al curriculum vitae
        _service.AggiungiInformazioniPersonali(new ES_G2.InformazioniPersonali
        {
            Cognome = "Rossi",
            Nome = "Mario",
            Telefono = "123456789",
            Email = "mario.rossi@example.com"
        });

        // Creazione del curriculum vitae
        var cv = _service.CreaCv();

        // Stampa del curriculum vitae
        Stampa(cv);
    }
}
