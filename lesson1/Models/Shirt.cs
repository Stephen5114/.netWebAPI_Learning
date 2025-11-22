
using lesson1.Models.Validations;
using System.ComponentModel.DataAnnotations;

namespace lesson1.Models
{
    public class Shirt
    {
        public int ShirtId { get; set; }
        public string? Brand { get; set; }
        public string? Color { get; set; }

        [Shirt_EnsureCorrectSizing]
        public int Size { get; set; }
        public string? Gender { get; set; }
        public double? price { get; set; }


    }
}
