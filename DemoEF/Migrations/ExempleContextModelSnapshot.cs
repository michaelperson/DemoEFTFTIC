﻿// <auto-generated />
using System;
using DemoEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoEF.Migrations
{
    [DbContext(typeof(ExempleContext))]
    partial class ExempleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoEF.Models.Course", b =>
                {
                    b.Property<string>("Course_ID")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<decimal>("Course_Ects")
                        .HasPrecision(3, 1)
                        .HasColumnType("decimal");

                    b.Property<string>("Course_Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Professor_ID")
                        .HasColumnType("int");

                    b.HasKey("Course_ID")
                        .HasName("PK_Course");

                    b.HasIndex("Professor_ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("DemoEF.Models.Personne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(175)
                        .HasColumnType("nvarchar(175)")
                        .HasColumnName("LastName");

                    b.HasKey("Id");

                    b.HasAlternateKey("Email")
                        .HasName("UK_Email");

                    b.ToTable("Personnes", t =>
                        {
                            t.HasCheckConstraint("CK_Email", "Email LIKE '___%@___%.___'");
                        });
                });

            modelBuilder.Entity("DemoEF.Models.Professor", b =>
                {
                    b.Property<int>("Professor_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Professor_ID"));

                    b.Property<string>("Professor_Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<DateTime?>("Professor_HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Professor_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Professor_Office")
                        .HasColumnType("int");

                    b.Property<string>("Professor_Surname")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Professor_Wage")
                        .HasColumnType("int");

                    b.Property<int>("Section_ID")
                        .HasColumnType("int");

                    b.HasKey("Professor_ID")
                        .HasName("PK_Prof");

                    b.ToTable("Professors", t =>
                        {
                            t.HasCheckConstraint("CK_Email", "Professor_Email LIKE '___%@___%.___'")
                                .HasName("CK_Email1");
                        });
                });

            modelBuilder.Entity("DemoEF.Models.Course", b =>
                {
                    b.HasOne("DemoEF.Models.Professor", "Professor")
                        .WithMany("Courses")
                        .HasForeignKey("Professor_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("DemoEF.Models.Professor", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
