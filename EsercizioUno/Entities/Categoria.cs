using System.ComponentModel.DataAnnotations;

namespace EsercizioUno.Entities
{
    public class Categoria
    {
        [Key] public int IdCategoria { get; set; }
        [MinLength(4)] public string Nome { get; set; }
        public string Descrizione { get; set; }
        public IEnumerable<Prodotto> Prodotti { get; set; }
    }
}
