using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    /// <summary>
    /// Possiveis Categorias associadas a cada foto
    /// </summary>
    public class Category
    {
        /// <summary>
        ///  PK
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Nome da Categoria
        /// </summary>
        [StringLength(20)]
        [Display(Name = "Nome da Categoria")]
        [Required(ErrorMessage ="{0} é de preenchimento obrigatório")]
        public string Name { get; set; }

        /*********************************
         *Relacionamentos 1-N
         ******************************** */
        /// <summary>
        /// List de fotografias que uma categoria tem
        /// </summary>
        public ICollection<Photography> ListOfPhotos { get; set; }
    }
}
