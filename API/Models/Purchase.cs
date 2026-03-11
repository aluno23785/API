using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    /// <summary>
    /// dados da compra da fotografia, por um utilizador
    /// </summary>
    public class Purchase
    {
        /// <summary>
        /// PK
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Data da compra
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Estado (situação) em que se encontra a compra
        /// </summary>
        public State State { get; set; }

        /*********************************
         *Relacionamentos 1-N
         ******************************** */
        /// <summary>
        /// Foreign Key para a tabela de clientes
        /// </summary>
        [ForeignKey(nameof(Buyer))]
        public int BuyerFK { get; set; }
        /// <summary>
        /// Cliente que efetuou a compra
        /// </summary>
        public MyUser Buyer { get; set; }
        /********************************/ 

        /*********************************
        *Relacionamentos M-N
        ******************************** */
        /// <summary>
        /// Uma compra tem uma lista de fotos 
        /// </summary>
        public ICollection<Photography> ListOfPhotos { get; set; }

        /*********************************/

    }
    /// <summary>
    /// Possiveis estados associados á compra
    /// </summary>
    public enum State
    {
        Pending, //Pagamento pendente
        Paid, // Pago
        Sent, //enviado
        Delivered, //recebido
        Closed  //fechado
    }
}
