﻿// <auto-generated />
using BookList.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BookList.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180308001006_AddUsersTableModel")]
    partial class AddUsersTableModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookList.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookList.Models.Customers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerName");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BookList.Models.Users", b =>
                {
                    b.Property<int>("UsersID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UsersName");

                    b.HasKey("UsersID");

                    b.ToTable("Userss");
                });
#pragma warning restore 612, 618
        }
    }
}
