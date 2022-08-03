﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vudu.com_Back_End.DAL;

namespace Vudu.com_Back_End.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220803213506_AddColumnActors")]
    partial class AddColumnActors
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vudu.com_Back_End.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.ActorMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("ActorMovies");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Advertising", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Advertisings");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Filter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Filters");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FilterId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilterId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.IndexOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IndexOptions");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.MainOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MainOptions");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BackImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InfoMovie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Length")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MainOptionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RatingId")
                        .HasColumnType("int");

                    b.Property<int>("RottenTomatoes")
                        .HasColumnType("int");

                    b.Property<int?>("StudioId")
                        .HasColumnType("int");

                    b.Property<string>("Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("YearId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MainOptionId");

                    b.HasIndex("RatingId");

                    b.HasIndex("StudioId");

                    b.HasIndex("YearId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.MovieGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieGenres");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.MovieIndexOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IndexOptionId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IndexOptionId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieIndexOptions");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.MovieSubOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<int?>("SubOptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("SubOptionId");

                    b.ToTable("MovieSubOptions");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.MovieSubOptionImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<int?>("SubOptionImageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("SubOptionImageId");

                    b.ToTable("MovieSubOptionImages");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.MovieSubOptionSubTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<int?>("SubOptionSubTitleId")
                        .HasColumnType("int");

                    b.Property<int?>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("SubOptionSubTitleId");

                    b.ToTable("MovieSubOptionSubTitles");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.MovieSubOptionTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<int?>("SubOptionTitleId")
                        .HasColumnType("int");

                    b.Property<int?>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("SubOptionTitleId");

                    b.ToTable("MovieSubOptionTitles");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FilterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilterId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IconUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Studio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FilterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilterId");

                    b.ToTable("Studios");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.SubOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MainOptionId")
                        .HasColumnType("int");

                    b.Property<string>("SubTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainOptionId");

                    b.ToTable("SubOptions");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.SubOptionImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MainOptionId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainOptionId");

                    b.ToTable("SubOptionImages");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.SubOptionSubTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MainOptionId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainOptionId");

                    b.ToTable("SubOptionSubTitles");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.SubOptionTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MainOptionId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainOptionId");

                    b.ToTable("SubOptionTitles");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Tomatometer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FilterId")
                        .HasColumnType("int");

                    b.Property<int>("Title")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilterId");

                    b.ToTable("Tomatometers");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Year", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FilterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilterId");

                    b.ToTable("Years");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.ActorMovie", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.Actor", "Actor")
                        .WithMany("ActorMovies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vudu.com_Back_End.Models.Movie", "Movie")
                        .WithMany("ActorMovies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Genre", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.Filter", "Filter")
                        .WithMany("Genres")
                        .HasForeignKey("FilterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Movie", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.MainOption", "MainOption")
                        .WithMany("Movies")
                        .HasForeignKey("MainOptionId");

                    b.HasOne("Vudu.com_Back_End.Models.Rating", "Rating")
                        .WithMany("Movies")
                        .HasForeignKey("RatingId");

                    b.HasOne("Vudu.com_Back_End.Models.Studio", "Studio")
                        .WithMany("Movies")
                        .HasForeignKey("StudioId");

                    b.HasOne("Vudu.com_Back_End.Models.Year", "Year")
                        .WithMany("Movies")
                        .HasForeignKey("YearId");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.MovieGenre", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.Genre", "Genre")
                        .WithMany("MovieGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vudu.com_Back_End.Models.Movie", "Movie")
                        .WithMany("MovieGenres")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.MovieIndexOption", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.IndexOption", "IndexOption")
                        .WithMany("MovieIndexOptions")
                        .HasForeignKey("IndexOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vudu.com_Back_End.Models.Movie", "Movie")
                        .WithMany("MovieIndexOptions")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.MovieSubOption", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.Movie", "Movie")
                        .WithMany("MovieSubOptions")
                        .HasForeignKey("MovieId");

                    b.HasOne("Vudu.com_Back_End.Models.SubOption", "SubOption")
                        .WithMany("MovieSubOptions")
                        .HasForeignKey("SubOptionId");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.MovieSubOptionImage", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.Movie", "Movie")
                        .WithMany("MovieSubOptionImages")
                        .HasForeignKey("MovieId");

                    b.HasOne("Vudu.com_Back_End.Models.SubOptionImage", "SubOptionImage")
                        .WithMany("MovieSubOptionImages")
                        .HasForeignKey("SubOptionImageId");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.MovieSubOptionSubTitle", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.Movie", "Movie")
                        .WithMany("MovieSubOptionSubTitles")
                        .HasForeignKey("MovieId");

                    b.HasOne("Vudu.com_Back_End.Models.SubOptionSubTitle", "SubOptionSubTitle")
                        .WithMany("MovieSubOptionSubTitles")
                        .HasForeignKey("SubOptionSubTitleId");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.MovieSubOptionTitle", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.Movie", "Movie")
                        .WithMany("MovieSubOptionTitles")
                        .HasForeignKey("MovieId");

                    b.HasOne("Vudu.com_Back_End.Models.SubOptionTitle", "SubOptionTitle")
                        .WithMany("MovieSubOptionTitles")
                        .HasForeignKey("SubOptionTitleId");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Rating", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.Filter", "Filter")
                        .WithMany("Ratings")
                        .HasForeignKey("FilterId");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Studio", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.Filter", "Filter")
                        .WithMany("Studios")
                        .HasForeignKey("FilterId");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.SubOption", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.MainOption", "MainOption")
                        .WithMany("SubOptions")
                        .HasForeignKey("MainOptionId");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.SubOptionImage", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.MainOption", "MainOption")
                        .WithMany("SubOptionImages")
                        .HasForeignKey("MainOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.SubOptionSubTitle", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.MainOption", "MainOption")
                        .WithMany("SubOptionSubTitles")
                        .HasForeignKey("MainOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.SubOptionTitle", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.MainOption", "MainOption")
                        .WithMany("SubOptionTitles")
                        .HasForeignKey("MainOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Tomatometer", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.Filter", "Filter")
                        .WithMany("Tomatometers")
                        .HasForeignKey("FilterId");
                });

            modelBuilder.Entity("Vudu.com_Back_End.Models.Year", b =>
                {
                    b.HasOne("Vudu.com_Back_End.Models.Filter", "Filter")
                        .WithMany("Years")
                        .HasForeignKey("FilterId");
                });
#pragma warning restore 612, 618
        }
    }
}
