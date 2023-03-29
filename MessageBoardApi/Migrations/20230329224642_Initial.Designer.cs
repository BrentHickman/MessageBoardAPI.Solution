﻿// <auto-generated />
using System;
using MessageBoardApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MessageBoardApi.Migrations
{
    [DbContext(typeof(MessageBoardApiContext))]
    [Migration("20230329224642_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessageBoardApi.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .HasColumnType("longtext");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("MessageBoardApi.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("MessageText")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("MessageId");

                    b.HasIndex("GroupId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("MessageBoardApi.Models.Message", b =>
                {
                    b.HasOne("MessageBoardApi.Models.Group", null)
                        .WithMany("Messages")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MessageBoardApi.Models.Group", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
