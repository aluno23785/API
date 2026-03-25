using System.ComponentModel.DataAnnotations;

namespace API.Models
/// <summary>
/// User
/// </summary>
{
    public class MyUser
    {
        /// <summary>
        /// PK
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// morada
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// código postal
        /// </summary>
        public string postal_code { get; set; }
        /// <summary>
        /// Pais de morada do user
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Número de contribuinte
        /// </summary>
       
        public string taxnumber { get; set; }
        /// <summary>
        /// telemóvel do user
        /// </summary>
        public string CellPhone { get; set; }

        /*********************************
         *Relacionamentos 1-N
         ******************************** */

        /// <summary>
        /// lista das compras das fotografias efetuadas pelo Cliente
        /// </summary>


        public ICollection<Purchase> ListOfPurchase { get; set; }
    }
}
