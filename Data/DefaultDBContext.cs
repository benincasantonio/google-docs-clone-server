using GoogleDocsCloneServer.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoogleDocsCloneServer.Data
{
    public class DefaultDBContext : DbContext
    {

        public DefaultDBContext(DbContextOptions<DefaultDBContext> options) : base(options) { }

        public DbSet<Document> Documents { get; set; }
    }
}
