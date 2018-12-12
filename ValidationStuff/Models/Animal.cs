using System.ComponentModel.DataAnnotations;

namespace ValidationStuff.Models
{
    public class Animal
    {
        [Required]
        public string Genus { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string Species { get; set; }

        [Required(ErrorMessage = "GFY")]
        [StringLength(1000,MinimumLength = 10)]
        public string Name { get; set; }

        [Range(0,1000)]
        public int Age { get; set; }

        public string Sex { get; set; }

        [Required]
        public Automobile Automobile { get; set; }
    }
}