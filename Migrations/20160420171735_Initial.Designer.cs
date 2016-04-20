using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using TravelBlog.Models;

namespace TravelBlog.Migrations
{
    [DbContext(typeof(TravelBlogDbContext))]
    [Migration("20160420171735_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TravelBlog.Models.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ExperienceName");

                    b.Property<int>("LocationId");

                    b.HasKey("ExperienceId");

                    b.HasAnnotation("Relational:TableName", "Experiences");
                });

            modelBuilder.Entity("TravelBlog.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LocationName");

                    b.HasKey("LocationId");

                    b.HasAnnotation("Relational:TableName", "Locations");
                });

            modelBuilder.Entity("TravelBlog.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExperienceId");

                    b.Property<int>("LocationId");

                    b.Property<string>("PersonName");

                    b.HasKey("PersonId");

                    b.HasAnnotation("Relational:TableName", "Persons");
                });

            modelBuilder.Entity("TravelBlog.Models.Experience", b =>
                {
                    b.HasOne("TravelBlog.Models.Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("TravelBlog.Models.Person", b =>
                {
                    b.HasOne("TravelBlog.Models.Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId");

                    b.HasOne("TravelBlog.Models.Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });
        }
    }
}
