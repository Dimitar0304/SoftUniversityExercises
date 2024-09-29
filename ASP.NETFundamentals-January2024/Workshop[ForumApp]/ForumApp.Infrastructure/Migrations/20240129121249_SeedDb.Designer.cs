﻿// <auto-generated />
using ForumApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForumApp.Infrastructure.Migrations
{
    [DbContext(typeof(ForumAppDbContext))]
    [Migration("20240129121249_SeedDb")]
    partial class SeedDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ForumApp.Infrastructure.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Post Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)")
                        .HasComment("Post content");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Post Title");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasComment("Post entity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "My first post will be for CRUD operations in MVC.It's so much fun!",
                            Title = "My first post"
                        },
                        new
                        {
                            Id = 2,
                            Content = "This is my second post in this MVC app and It's more creatifully",
                            Title = "My second post"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Hello with my third post in this platform I hope to become a better in writing post!",
                            Title = "My third post"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
