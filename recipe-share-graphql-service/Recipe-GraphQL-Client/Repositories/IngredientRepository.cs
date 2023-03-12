using Recipe_GraphQL_Client.Data;
using Recipe_GraphQL_Client.Interfaces;

namespace Recipe_GraphQL_Client.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public IngredientRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
