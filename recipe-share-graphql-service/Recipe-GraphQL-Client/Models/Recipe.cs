using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipe_GraphQL_Client.Models
{
    public class Recipe
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The recipe title is required!")]
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }

        public ICollection<string> Steps { get; set; }

        [ForeignKey("AuthorId")]
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
