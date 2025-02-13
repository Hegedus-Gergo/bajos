﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetGameAPI.Data;

#nullable disable

namespace PetGameAPI.Migrations
{
    [DbContext(typeof(PetGameDbContext))]
    [Migration("20250213123051_sqlite.local_migration_592")]
    partial class sqlitelocal_migration_592
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("Inventory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PetID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ToolID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("PetID");

                    b.HasIndex("ToolID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Pet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Energy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Happiness")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hunger")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PetName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("PetType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayerID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("PlayerID");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("InGameCurrency")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Tool", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Energy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Happiness")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hunger")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("Inventory", b =>
                {
                    b.HasOne("Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tool", "Tool")
                        .WithMany()
                        .HasForeignKey("ToolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");

                    b.Navigation("Tool");
                });

            modelBuilder.Entity("Pet", b =>
                {
                    b.HasOne("Player", "Player")
                        .WithMany("Pets")
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Player", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
