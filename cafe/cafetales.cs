using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class cafetales 
    {
        public int ID { get; set; }
        public string marca { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime inventario { get; set; }
        public int cantidad  { get; set; } 
        public decimal Precio { get; set; }
    }
}