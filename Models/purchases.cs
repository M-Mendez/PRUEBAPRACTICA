using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRUEBAPRACTICA.Models
{
    public class purchases
    {
        public int Id { get; set; }
        public int CardId {get;set;}
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("CarId")]
        public virtual customers customer { get; set; }
        [ForeignKey("CustomerId")]
        public virtual cars cars { get; set; }
    }
}
