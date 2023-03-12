using Recipe_GraphQL_Client.Data;
using Recipe_GraphQL_Client.Interfaces;

namespace Recipe_GraphQL_Client.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public RecipeRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
