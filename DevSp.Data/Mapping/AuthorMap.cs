using DevSp.Data.Configuration ;
using DevSp.Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DevSp.Data.Mapping
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public override void Map(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Author");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasColumnType("varchar(100)")                
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Picture)
                .HasColumnType("varchar(100)");


            builder.Property(x => x.Resume)
               .HasColumnType("varchar(5000)");               
        }
    }
}
