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
