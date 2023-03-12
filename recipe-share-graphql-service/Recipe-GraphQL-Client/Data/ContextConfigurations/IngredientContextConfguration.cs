using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Recipe_GraphQL_Client.Models;

namespace Recipe_GraphQL_Client.Data.ContextConfigurations
{
    public class IngredientContextConfguration : IEntityTypeConfiguration<Ingredient>
    {

        private Guid[] _ids;

        public IngredientContextConfguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasData(
             new Ingredient
             {
                 Id = _ids[0],
                 Name = "Egg",
                 Unit = ""
             },
             new Ingredient
             {
                 Id = _ids[1],
                 Name = "Spaghetti",
                 Unit = "dl"
             }
            );
        }

    }
}
