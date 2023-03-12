using System.ComponentModel.DataAnnotations;

namespace Recipe_GraphQL_Client.Models
{
    public class Author
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required for author")]
        public string Name { get; set; }

    }
}
