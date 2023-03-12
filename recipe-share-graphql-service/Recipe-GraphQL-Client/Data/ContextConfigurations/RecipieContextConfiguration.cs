using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe_GraphQL_Client.Models;

namespace Recipe_GraphQL_Client.Data.ContextConfigurations
{
    public class RecipieContextConfiguration : IEntityTypeConfiguration<Recipe>
    {
        private Guid[] _ids;

        public RecipieContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasData(
             new Recipe
             {
                 Id = _ids[0],
                 Title = "Spaghetti Carbonara",
                 Description = "A common classic from Italy!",
                 Ingredients = new List<Ingredient> { },
                 Steps = new List<string> { "Cook the pasta according to instructions on packaging" },
                 AuthorId = _ids[0],

             },
             new Recipe
             {
                 Id = _ids[1],
                 Title = "Panncakes",
                 Description = "A perfect treat in the morning!",
                 Ingredients = new List<Ingredient> { },
                 Steps = new List<string> { "Mix flour and eggs with a whisker" },
                 AuthorId = _ids[1]
             }
            );
        }
    }
}
