using System.ComponentModel.DataAnnotations;

namespace EsercizioUno.Entities
{
    public class Prodotto
    {
        [Key] public int IdProdotto { get; set; }
        [MinLength(4)] public string? Nome { get; set; }

        public decimal prezzo { get; set; }

        public int Giacenza { get; set; }
        public bool InVendita { get; set; }

        public int CategoriaIdCategoria { get; set; }
    }
}
