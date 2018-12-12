using System.ComponentModel.DataAnnotations;

namespace ValidationStuff.Models
{
    public class Automobile
    {
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }

        [Range(1900,2020)]
        public int Year { get; set; }

        [Required]
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public decimal Price {get;set;}
        public bool HeatedSeats { get; set; }
    }
}