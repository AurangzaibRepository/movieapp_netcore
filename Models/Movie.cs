using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        public string? Genre { get; set; }

        [Required(ErrorMessage ="Price is required")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage ="Invalid value")]
        public decimal Price { get; set; }

    }
}
