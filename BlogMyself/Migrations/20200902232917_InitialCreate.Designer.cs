﻿// <auto-generated />
using BlogMyself.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogMyself.Migrations
{
    [DbContext(typeof(BlogmyselfDBContext))]
    [Migration("20200902232917_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Scaffolding:ConnectionString", "Data Source=(local);Initial Catalog=BlogMyself.DB;Integrated Security=true");

            modelBuilder.Entity("BlogMyself.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });
#pragma warning restore 612, 618
        }
    }
}
