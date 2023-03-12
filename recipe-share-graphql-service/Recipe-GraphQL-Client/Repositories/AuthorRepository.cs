using Recipe_GraphQL_Client.Data;
using Recipe_GraphQL_Client.Interfaces;

namespace Recipe_GraphQL_Client.Repositories
{
    public class AuthorRepository : IAuthorReposiitory
    {
        private readonly ApplicationDbContext _appDbContext;

        public AuthorRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
