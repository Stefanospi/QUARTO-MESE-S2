using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;
using System;

namespace ES_G2
{
    // La classe principale, chiamata CV, rappresenta un curriculum vitae e contiene tre proprietà: InformazioniPersonali, StudiEffettuati e Impieghi.
    public class Cv
    {
        public InformazioniPersonali PersonalInfo { get; set; } // Proprietà che rappresenta le informazioni personali del candidato
        public List<Studi> Studi = new List<Studi>(); // Proprietà che rappresenta gli studi effettuati dal candidato
        public List<Esperienze> Impiego = new List<Esperienze>(); // Proprietà che rappresenta gli impieghi del candidato
    }
}
