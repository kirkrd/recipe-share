using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe_GraphQL_Client.Models;

namespace Recipe_GraphQL_Client.Data.ContextConfigurations
{
    public class AuthorContextConfiguration : IEntityTypeConfiguration<Author>
    {
        private Guid[] _ids;

        public AuthorContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(
            new Author
            {
                Id = _ids[0],
                Name = "Kristoffer Kirk",
            },
            new Author
            {
                Id = _ids[1],
                Name = "Gordon Ramsey"
            }
           );
        }
    }
}
