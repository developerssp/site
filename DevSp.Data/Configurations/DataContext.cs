using DevSp.Data.Mapping;
using DevSp.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace DevSp.Data.Configurations
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option): base(option)
        { }        

        public DbSet<Author> Author { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ForSqlServerUseIdentityColumns(); // para incrementar as chaves primarias
            modelBuilder.HasDefaultSchema("DevSpCore");

            modelBuilder.AddConfiguration(new AuthorMap());

            base.OnModelCreating(modelBuilder);
        }       
    }
}
