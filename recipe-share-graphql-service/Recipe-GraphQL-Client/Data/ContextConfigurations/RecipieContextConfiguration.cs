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
                 AuthorId = _ids[0]
             },
             new Recipe
             {
                 Id = _ids[1],
                 Title = "Panncakes",
                 Description = "A perfect treat in the morning!",
                 AuthorId = _ids[1]
             }
            );
        }
    }
}
