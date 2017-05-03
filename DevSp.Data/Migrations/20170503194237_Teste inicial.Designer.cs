using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DevSp.Data.Configuration;

namespace DevSp.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20170503194237_Teste inicial")]
    partial class Testeinicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DevSp.Domain.Model.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Picture")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Resume")
                        .HasColumnType("varchar(5000)");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });
        }
    }
}
