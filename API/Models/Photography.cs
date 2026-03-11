using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
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
        [StringLength(50)]
        [Display(Name ="Tìtulo")]
        [Required(ErrorMessage ="{0}   é de preenchimento Obrigatório")]
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// descrição da fotografia (opcional)
        /// </summary>
        [StringLength(300)]
        public string? Description { get; set; }
        /// <summary>
        /// nome do ficheiro
        /// </summary>
        public string File { get; set; }= ""//string.Empty;
        /// <summary>
        /// Data em que a fotografia foi tirada
        /// </summary>
   
        [DataType(DataType.Date)]
       // [Display(Name = "Data")]
        //[Required(ErrorMessage = "{0} é de preenchimento Obrigatório")]
        public DateTime Date { get; set; }
        /// <summary>
        /// Preço da foto
        /// </summary>
        [Display(Name ="Preço")]
        public decimal Price { get; set; }

        /*********************************
         *Relacionamentos 1-N
         ******************************** */
        /// <summary>
        /// Foreign Key para a Categoria de fotografia
        /// </summary>
        [Display(Name = "Categoria")]
        [ForeignKey(nameof(Category))]
        public int CategoryFK { get; set; }
        [Display(Name = "Categoria")]
        [ValidateNever]
        public Category Category { get; set; } = null!;

        /*********************************
        *Relacionamentos N-M
        ******************************** */
        /// <summary>
        /// Uma Fotografia tem uma lista de compras 
        /// </summary>
        public ICollection<Purchase> ListOfPurchases { get; set; } = []

    }
}
