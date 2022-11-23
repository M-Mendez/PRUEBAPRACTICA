using System;
using System.ComponentModel.DataAnnotations;

namespace PRUEBAPRACTICA.Models
{
    public class ReporteDTO
    {
        public string Nombre { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Fecha { get; set; }
        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }
        [DataType(DataType.Currency)]
        public decimal PrecioVenta { get; set; }    
        public string caracteristicas { get; set; }
    }
}
