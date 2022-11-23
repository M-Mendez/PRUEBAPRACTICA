using System.Collections.Generic;

namespace PRUEBAPRACTICA.Models
{
    public class customers
    {
        public int Id { get; set; }
        public string firstname { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }   
        public string address { get; set; } 
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public List<purchases> purchases { get; set; }

    }
}
