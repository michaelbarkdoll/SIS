﻿// <auto-generated />
using SIS.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace SIS.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("SIS.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<string>("FilePath");

                    b.Property<string>("PublicId");

                    b.Property<string>("Url");

                    b.Property<int>("UserId");

                    b.Property<bool>("isMain");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("SIS.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("Advisor");

                    b.Property<string>("BachelorFacultyMentor");

                    b.Property<DateTime>("BachelorGraduationDate");

                    b.Property<DateTime>("BachelorStartDate");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<int>("DawgTag");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("Interests");

                    b.Property<string>("Introduction");

                    b.Property<string>("KnownAs");

                    b.Property<DateTime>("LastActive");

                    b.Property<string>("LastName");

                    b.Property<string>("LookingFor");

                    b.Property<string>("Notes");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("PhoneNumber1");

                    b.Property<string>("PhoneNumber2");

                    b.Property<string>("SeniorProjectAdvisor");

                    b.Property<string>("State");

                    b.Property<string>("UserLevel");

                    b.Property<string>("Username");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SIS.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("SIS.API.Models.Photo", b =>
                {
                    b.HasOne("SIS.API.Models.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}