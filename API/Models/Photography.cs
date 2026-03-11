using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    /// <summary>
    /// objetos a serem vendidios na loja
    /// </summary>
    public class Photography
    {

        /// <summary>
        /// PK
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// nome associado a fotografia
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// descrição da fotografia (opcional)
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// nome do ficheiro
        /// </summary>
        public string File { get; set; }
        /// <summary>
        /// Data em que a fotografia foi tirada
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Preço da foto
        /// </summary>
        public decimal Price { get; set; }

        /*********************************
         *Relacionamentos 1-N
         ******************************** */
        /// <summary>
        /// Foreign Key para a Categoria de fotografia
        /// </summary>
        [ForeignKey(nameof(Category))]
        public int CategoryFK { get; set; }
        public Category Category { get; set; }

        /*********************************
        *Relacionamentos N-M
        ******************************** */
        /// <summary>
        /// Uma Fotografia tem uma lista de compras 
        /// </summary>
        public ICollection<Purchase> ListOfPurchases { get; set; }

    }
}
