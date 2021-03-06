﻿// <auto-generated />
using BgShop.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BgShop.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20180810131744_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BgShop.Domen.Entities.Games", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("duration")
                        .HasColumnName("duration");

                    b.Property<bool>("featured")
                        .HasColumnName("featured");

                    b.Property<string>("players")
                        .IsRequired()
                        .HasColumnName("players")
                        .HasMaxLength(10);

                    b.Property<int>("price")
                        .HasColumnName("price");

                    b.Property<int>("publisher")
                        .HasColumnName("publisher");

                    b.Property<int>("publisherid");

                    b.Property<string>("thumbnail")
                        .IsRequired()
                        .HasColumnName("thumbnail")
                        .HasMaxLength(600);

                    b.HasKey("id");

                    b.HasIndex("publisherid");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("BgShop.Domen.Entities.Publishers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("BgShop.Domen.Entities.Games", b =>
                {
                    b.HasOne("BgShop.Domen.Entities.Publishers", "publishers")
                        .WithMany("games")
                        .HasForeignKey("publisherid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
