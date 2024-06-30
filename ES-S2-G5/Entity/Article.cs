using System.ComponentModel.DataAnnotations;

namespace ES_S2_G5.Entity
{
    public class Article
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Il nome dell'articolo è obbligatorio.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il prezzo dell'articolo è obbligatorio.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "La descrizione dell'articolo è obbligatorio.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Devi caricare necessariamente l'immagine dell'articolo è obbligatorio.")]
        public IFormFile CoverImg { get; set; }


    }
}
