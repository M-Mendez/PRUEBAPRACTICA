using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRUEBAPRACTICA.Models
{
    public class cars
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public List<purchases> purchases { get; set; }
    }
}
