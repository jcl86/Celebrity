﻿// <auto-generated />
using System;
using Celebrity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Celebrity.Data.Migrations
{
    [DbContext(typeof(CelebrityContext))]
    partial class CelebrityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Celebrity.Domain.Concept", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Difficulty")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Concepts");
                });

            modelBuilder.Entity("Celebrity.Domain.DeckConcept", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Difficulty")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("GameId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsGuessed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Subcategories")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("DeckConcepts");
                });

            modelBuilder.Entity("Celebrity.Domain.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CurrentTurn")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Celebrity.Domain.Point", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Round")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("TeamId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("Celebrity.Domain.Subcategory", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Subcategories");
                });

            modelBuilder.Entity("Celebrity.Domain.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Color")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fails")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("GameId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("ConceptSubcategory", b =>
                {
                    b.Property<Guid>("ConceptsId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SubcategoriesId")
                        .HasColumnType("TEXT");

                    b.HasKey("ConceptsId", "SubcategoriesId");

                    b.HasIndex("SubcategoriesId");

                    b.ToTable("ConceptSubcategory");
                });

            modelBuilder.Entity("Celebrity.Domain.Concept", b =>
                {
                    b.OwnsOne("Celebrity.ConceptName", "Name", b1 =>
                        {
                            b1.Property<Guid>("ConceptId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("value")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("TEXT")
                                .HasColumnName("ConceptName");

                            b1.HasKey("ConceptId");

                            b1.ToTable("Concepts");

                            b1.WithOwner()
                                .HasForeignKey("ConceptId");
                        });

                    b.Navigation("Name");
                });

            modelBuilder.Entity("Celebrity.Domain.DeckConcept", b =>
                {
                    b.HasOne("Celebrity.Domain.Game", "Game")
                        .WithMany("DeckConcepts")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("Celebrity.ConceptId", "ConceptId", b1 =>
                        {
                            b1.Property<Guid>("DeckConceptId")
                                .HasColumnType("TEXT");

                            b1.Property<Guid>("identificator")
                                .HasColumnType("TEXT")
                                .HasColumnName("ConceptId");

                            b1.HasKey("DeckConceptId");

                            b1.ToTable("DeckConcepts");

                            b1.WithOwner()
                                .HasForeignKey("DeckConceptId");
                        });

                    b.OwnsOne("Celebrity.ConceptName", "Name", b1 =>
                        {
                            b1.Property<Guid>("DeckConceptId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("value")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("TEXT")
                                .HasColumnName("ConceptName");

                            b1.HasKey("DeckConceptId");

                            b1.ToTable("DeckConcepts");

                            b1.WithOwner()
                                .HasForeignKey("DeckConceptId");
                        });

                    b.Navigation("ConceptId");

                    b.Navigation("Game");

                    b.Navigation("Name");
                });

            modelBuilder.Entity("Celebrity.Domain.Game", b =>
                {
                    b.OwnsOne("Celebrity.Domain.RoundContext", "RoundContext", b1 =>
                        {
                            b1.Property<Guid>("GameId")
                                .HasColumnType("TEXT");

                            b1.Property<int>("CurrentRoundIndex")
                                .HasColumnType("INTEGER");

                            b1.HasKey("GameId");

                            b1.ToTable("Games");

                            b1.WithOwner()
                                .HasForeignKey("GameId");
                        });

                    b.Navigation("RoundContext");
                });

            modelBuilder.Entity("Celebrity.Domain.Point", b =>
                {
                    b.HasOne("Celebrity.Domain.Team", "Team")
                        .WithMany("Points")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("Celebrity.ConceptId", "ConceptId", b1 =>
                        {
                            b1.Property<Guid>("PointId")
                                .HasColumnType("TEXT");

                            b1.Property<Guid>("identificator")
                                .HasColumnType("TEXT")
                                .HasColumnName("ConceptId");

                            b1.HasKey("PointId");

                            b1.ToTable("Points");

                            b1.WithOwner()
                                .HasForeignKey("PointId");
                        });

                    b.OwnsOne("Celebrity.ConceptName", "Name", b1 =>
                        {
                            b1.Property<Guid>("PointId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("value")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("TEXT")
                                .HasColumnName("ConceptName");

                            b1.HasKey("PointId");

                            b1.ToTable("Points");

                            b1.WithOwner()
                                .HasForeignKey("PointId");
                        });

                    b.Navigation("ConceptId");

                    b.Navigation("Name");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Celebrity.Domain.Subcategory", b =>
                {
                    b.OwnsOne("Celebrity.Domain.SubcategoryName", "Name", b1 =>
                        {
                            b1.Property<Guid>("SubcategoryId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("TEXT")
                                .HasColumnName("SubcategoryName");

                            b1.HasKey("SubcategoryId");

                            b1.ToTable("Subcategories");

                            b1.WithOwner()
                                .HasForeignKey("SubcategoryId");
                        });

                    b.Navigation("Name");
                });

            modelBuilder.Entity("Celebrity.Domain.Team", b =>
                {
                    b.HasOne("Celebrity.Domain.Game", "Game")
                        .WithMany("Teams")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("Celebrity.Domain.TeamName", "Name", b1 =>
                        {
                            b1.Property<Guid>("TeamId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("value")
                                .IsRequired()
                                .HasMaxLength(25)
                                .HasColumnType("TEXT")
                                .HasColumnName("TeamName");

                            b1.HasKey("TeamId");

                            b1.ToTable("Teams");

                            b1.WithOwner()
                                .HasForeignKey("TeamId");
                        });

                    b.Navigation("Game");

                    b.Navigation("Name");
                });

            modelBuilder.Entity("ConceptSubcategory", b =>
                {
                    b.HasOne("Celebrity.Domain.Concept", null)
                        .WithMany()
                        .HasForeignKey("ConceptsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Celebrity.Domain.Subcategory", null)
                        .WithMany()
                        .HasForeignKey("SubcategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Celebrity.Domain.Game", b =>
                {
                    b.Navigation("DeckConcepts");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Celebrity.Domain.Team", b =>
                {
                    b.Navigation("Points");
                });
#pragma warning restore 612, 618
        }
    }
}
