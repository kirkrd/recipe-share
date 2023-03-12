using System.ComponentModel.DataAnnotations;

namespace Recipe_GraphQL_Client.Models
{
    public class Ingredient
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Ingredient name is required")]
        
        public string Name { get; set; }
        public string Unit { get; set; }
    }
}
