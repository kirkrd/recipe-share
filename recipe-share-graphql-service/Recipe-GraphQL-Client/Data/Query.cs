using Recipe_GraphQL_Client.Models;

namespace Recipe_GraphQL_Client.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Recipe> GetRecipes([Service] ApplicationDbContext context) =>
             context.Recipes;
    }
}
