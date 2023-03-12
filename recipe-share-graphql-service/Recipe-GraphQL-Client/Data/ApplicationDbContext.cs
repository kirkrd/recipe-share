using Microsoft.EntityFrameworkCore;
using Recipe_GraphQL_Client.Data.ContextConfigurations;
using Recipe_GraphQL_Client.Models;

namespace Recipe_GraphQL_Client.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var ids = new Guid[] {Guid.NewGuid(), Guid.NewGuid() };

            builder.ApplyConfiguration(new AuthorContextConfiguration(ids));
            builder.Ignore<List<string>>();
            builder.ApplyConfiguration(new RecipieContextConfiguration(ids));
            builder.ApplyConfiguration(new IngredientContextConfguration(ids));
            
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
