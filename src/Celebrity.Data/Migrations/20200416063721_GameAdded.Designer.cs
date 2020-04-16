﻿// <auto-generated />
using System;
using Celebrity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Celebrity.Data.Migrations
{
    [DbContext(typeof(CelebrityContext))]
    [Migration("20200416063721_GameAdded")]
    partial class GameAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("Celebrity.Categories", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8fec642b-e94e-4c8c-b4bd-ac650261c1fa"),
                            Name = "Personajes famosos"
                        },
                        new
                        {
                            Id = new Guid("141bb062-409d-4589-bb38-f746e62e4c7b"),
                            Name = "Personajes de ficción famosos"
                        },
                        new
                        {
                            Id = new Guid("ea6e084a-150f-47e1-8d81-9dfce02f082f"),
                            Name = "Cultura"
                        },
                        new
                        {
                            Id = new Guid("635fb9eb-3385-4b74-ad8c-f098b8877ab8"),
                            Name = "Lugares"
                        },
                        new
                        {
                            Id = new Guid("0374db75-45cc-4ebc-9ecc-b319b56d00ab"),
                            Name = "Citas"
                        },
                        new
                        {
                            Id = new Guid("03e283aa-2ac7-4767-be33-99150d0b85f0"),
                            Name = "Universos de ficción"
                        },
                        new
                        {
                            Id = new Guid("85a77535-2e87-4982-941f-81822e61b8a1"),
                            Name = "Nacionalidades"
                        },
                        new
                        {
                            Id = new Guid("1333d339-022f-4350-adc4-68d069016762"),
                            Name = "Tecnología"
                        },
                        new
                        {
                            Id = new Guid("306c1ad7-5b61-4822-a02b-fb6fee5a872a"),
                            Name = "Ciencia"
                        },
                        new
                        {
                            Id = new Guid("46e5f000-515c-436f-98ba-131aba56c887"),
                            Name = "Deporte"
                        });
                });

            modelBuilder.Entity("Celebrity.Concepts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Difficulty")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCustomized")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Concepts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("35716d31-8c92-4673-8b03-ca4aabbd7083"),
                            Difficulty = 0,
                            IsCustomized = false,
                            Name = "Alejandro Magno",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("6c8d35d7-0f05-41c9-bbf1-ec34a85f9932"),
                            Difficulty = 0,
                            IsCustomized = false,
                            Name = "Hércules",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("0a46e7bb-fa18-4d91-a3b8-53be3250c50b"),
                            Difficulty = 1,
                            IsCustomized = false,
                            Name = "Amilcar Barca",
                            Type = 0
                        });
                });

            modelBuilder.Entity("Celebrity.Data.DeckConcepts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Concept")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("GameId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsGuessed")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("DeckConcepts");
                });

            modelBuilder.Entity("Celebrity.Data.Games", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CurrentRound")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrentTeam")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OwnerId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Percentage")
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalRounds")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Celebrity.Data.LoadedGames", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientInfo")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<Guid>("GameId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LoadedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("User")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("LoadedGames");
                });

            modelBuilder.Entity("Celebrity.Data.TeamPoints", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Concept")
                        .HasColumnType("TEXT");

                    b.Property<int>("Round")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamPoints");
                });

            modelBuilder.Entity("Celebrity.Data.TeamsInGame", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Color")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fails")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("GameId")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("TeamsInGame");
                });

            modelBuilder.Entity("Celebrity.Data.Users", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Celebrity.Subcategories", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IdCategory")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCustomized")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("IdCategory");

                    b.ToTable("Subcategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("018b5aa8-b2da-423a-ad29-e3b05f64042c"),
                            IdCategory = new Guid("8fec642b-e94e-4c8c-b4bd-ac650261c1fa"),
                            IsCustomized = false,
                            Name = "Antigüedad"
                        },
                        new
                        {
                            Id = new Guid("189cf44c-6775-438a-bc3e-75dee172a8e6"),
                            IdCategory = new Guid("8fec642b-e94e-4c8c-b4bd-ac650261c1fa"),
                            IsCustomized = false,
                            Name = "Medieval"
                        },
                        new
                        {
                            Id = new Guid("9b68c070-98d1-4427-bb62-741c78dd6257"),
                            IdCategory = new Guid("8fec642b-e94e-4c8c-b4bd-ac650261c1fa"),
                            IsCustomized = false,
                            Name = "Moderno"
                        },
                        new
                        {
                            Id = new Guid("f3964be4-4c57-4be5-b160-9bf211683249"),
                            IdCategory = new Guid("8fec642b-e94e-4c8c-b4bd-ac650261c1fa"),
                            IsCustomized = false,
                            Name = "Contemporáneo"
                        },
                        new
                        {
                            Id = new Guid("eece8141-fccb-4aa5-9777-1752733ad7eb"),
                            IdCategory = new Guid("141bb062-409d-4589-bb38-f746e62e4c7b"),
                            IsCustomized = false,
                            Name = "Personaje de ficción"
                        },
                        new
                        {
                            Id = new Guid("5cc9fd6f-42e5-443d-bcec-d69ef115b4cc"),
                            IdCategory = new Guid("ea6e084a-150f-47e1-8d81-9dfce02f082f"),
                            IsCustomized = false,
                            Name = "Películas"
                        },
                        new
                        {
                            Id = new Guid("8fb94b91-f784-4059-a95a-81a4bd6ff8d5"),
                            IdCategory = new Guid("ea6e084a-150f-47e1-8d81-9dfce02f082f"),
                            IsCustomized = false,
                            Name = "Series"
                        },
                        new
                        {
                            Id = new Guid("d872c3f3-7492-49b7-a91c-6da427709a1e"),
                            IdCategory = new Guid("ea6e084a-150f-47e1-8d81-9dfce02f082f"),
                            IsCustomized = false,
                            Name = "Literatura"
                        },
                        new
                        {
                            Id = new Guid("353b6f56-8ed9-4d60-9ba1-b9a424f929a8"),
                            IdCategory = new Guid("ea6e084a-150f-47e1-8d81-9dfce02f082f"),
                            IsCustomized = false,
                            Name = "Teatro"
                        },
                        new
                        {
                            Id = new Guid("fbbc4fb3-af2d-49c3-bcc9-9c5d032c2d3b"),
                            IdCategory = new Guid("ea6e084a-150f-47e1-8d81-9dfce02f082f"),
                            IsCustomized = false,
                            Name = "Cómic"
                        },
                        new
                        {
                            Id = new Guid("d4699859-a05a-4220-91d6-e14a45805189"),
                            IdCategory = new Guid("ea6e084a-150f-47e1-8d81-9dfce02f082f"),
                            IsCustomized = false,
                            Name = "Música"
                        },
                        new
                        {
                            Id = new Guid("ab693379-4570-4559-8a6b-e6353b487505"),
                            IdCategory = new Guid("ea6e084a-150f-47e1-8d81-9dfce02f082f"),
                            IsCustomized = false,
                            Name = "Videojuegos"
                        },
                        new
                        {
                            Id = new Guid("d675bba9-2f85-4084-96e2-1aedb45c0694"),
                            IdCategory = new Guid("ea6e084a-150f-47e1-8d81-9dfce02f082f"),
                            IsCustomized = false,
                            Name = "Juegos de mesa"
                        },
                        new
                        {
                            Id = new Guid("1ac1ba30-049d-4589-bce5-29faea1bee4e"),
                            IdCategory = new Guid("635fb9eb-3385-4b74-ad8c-f098b8877ab8"),
                            IsCustomized = false,
                            Name = "Paises"
                        },
                        new
                        {
                            Id = new Guid("7888608e-34fa-4225-8c8c-3bd152b60c34"),
                            IdCategory = new Guid("635fb9eb-3385-4b74-ad8c-f098b8877ab8"),
                            IsCustomized = false,
                            Name = "Ciudades"
                        },
                        new
                        {
                            Id = new Guid("82be5539-4745-4e4c-965a-d100cdf3dc8e"),
                            IdCategory = new Guid("635fb9eb-3385-4b74-ad8c-f098b8877ab8"),
                            IsCustomized = false,
                            Name = "Ríos"
                        },
                        new
                        {
                            Id = new Guid("9bd4b40c-a840-464a-ad89-473da45a138f"),
                            IdCategory = new Guid("635fb9eb-3385-4b74-ad8c-f098b8877ab8"),
                            IsCustomized = false,
                            Name = "Montañas"
                        },
                        new
                        {
                            Id = new Guid("0c4fbee3-eb8b-48e6-ab83-c10aeadf7e1f"),
                            IdCategory = new Guid("635fb9eb-3385-4b74-ad8c-f098b8877ab8"),
                            IsCustomized = false,
                            Name = "Mares y lagos"
                        },
                        new
                        {
                            Id = new Guid("516e06ce-fd2d-4401-9e94-9d3b660c8149"),
                            IdCategory = new Guid("0374db75-45cc-4ebc-9ecc-b319b56d00ab"),
                            IsCustomized = false,
                            Name = "Citas históricas"
                        },
                        new
                        {
                            Id = new Guid("ed6cfc09-f7f8-4688-a152-74c63b82dd12"),
                            IdCategory = new Guid("0374db75-45cc-4ebc-9ecc-b319b56d00ab"),
                            IsCustomized = false,
                            Name = "Proverbios y refranes"
                        },
                        new
                        {
                            Id = new Guid("deea56fa-b209-498f-b91b-b01d7b8199bc"),
                            IdCategory = new Guid("0374db75-45cc-4ebc-9ecc-b319b56d00ab"),
                            IsCustomized = false,
                            Name = "Frases de la tele"
                        },
                        new
                        {
                            Id = new Guid("3a79c132-3df7-4ffc-8113-85816925761b"),
                            IdCategory = new Guid("03e283aa-2ac7-4767-be33-99150d0b85f0"),
                            IsCustomized = false,
                            Name = "Star Wars"
                        },
                        new
                        {
                            Id = new Guid("888def87-8f63-4958-91f7-9abafffe0719"),
                            IdCategory = new Guid("03e283aa-2ac7-4767-be33-99150d0b85f0"),
                            IsCustomized = false,
                            Name = "Harry Potter"
                        },
                        new
                        {
                            Id = new Guid("5025bdeb-c297-49c3-92a0-e99088d05b2e"),
                            IdCategory = new Guid("03e283aa-2ac7-4767-be33-99150d0b85f0"),
                            IsCustomized = false,
                            Name = "Los Simpsons"
                        },
                        new
                        {
                            Id = new Guid("bc93e21c-8bce-4536-baf0-789b2462d9c3"),
                            IdCategory = new Guid("03e283aa-2ac7-4767-be33-99150d0b85f0"),
                            IsCustomized = false,
                            Name = "Marvel"
                        },
                        new
                        {
                            Id = new Guid("886fb310-430d-4685-86e2-edfb84d343d9"),
                            IdCategory = new Guid("03e283aa-2ac7-4767-be33-99150d0b85f0"),
                            IsCustomized = false,
                            Name = "Disney"
                        },
                        new
                        {
                            Id = new Guid("3e6c4935-b100-4d09-a1c9-03a993e44db0"),
                            IdCategory = new Guid("85a77535-2e87-4982-941f-81822e61b8a1"),
                            IsCustomized = false,
                            Name = "España"
                        },
                        new
                        {
                            Id = new Guid("6b899254-4b2d-4e54-ac56-23c9f034bed3"),
                            IdCategory = new Guid("85a77535-2e87-4982-941f-81822e61b8a1"),
                            IsCustomized = false,
                            Name = "USA"
                        },
                        new
                        {
                            Id = new Guid("b8d55bb4-664b-49ee-a3bc-52dad017adb4"),
                            IdCategory = new Guid("85a77535-2e87-4982-941f-81822e61b8a1"),
                            IsCustomized = false,
                            Name = "Reino Unido"
                        },
                        new
                        {
                            Id = new Guid("5c92f839-73fd-4ebe-b005-0583af8765cb"),
                            IdCategory = new Guid("85a77535-2e87-4982-941f-81822e61b8a1"),
                            IsCustomized = false,
                            Name = "Italia"
                        },
                        new
                        {
                            Id = new Guid("9fce529e-e864-4cd5-8a52-312fe6782204"),
                            IdCategory = new Guid("85a77535-2e87-4982-941f-81822e61b8a1"),
                            IsCustomized = false,
                            Name = "Francia"
                        });
                });

            modelBuilder.Entity("Celebrity.SubcategoriesInConcepts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ConceptId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SubcategoryId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ConceptId");

                    b.HasIndex("SubcategoryId");

                    b.ToTable("SubcategoriesInConcepts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bc4bbb2b-c21b-4f04-a9d4-87fb560eb3c8"),
                            ConceptId = new Guid("35716d31-8c92-4673-8b03-ca4aabbd7083"),
                            SubcategoryId = new Guid("018b5aa8-b2da-423a-ad29-e3b05f64042c")
                        },
                        new
                        {
                            Id = new Guid("d55ac907-2b76-42ef-8062-860f2e0af8c7"),
                            ConceptId = new Guid("6c8d35d7-0f05-41c9-bbf1-ec34a85f9932"),
                            SubcategoryId = new Guid("018b5aa8-b2da-423a-ad29-e3b05f64042c")
                        },
                        new
                        {
                            Id = new Guid("15447a43-8516-4b39-906e-ecad6a3c7cb7"),
                            ConceptId = new Guid("0a46e7bb-fa18-4d91-a3b8-53be3250c50b"),
                            SubcategoryId = new Guid("018b5aa8-b2da-423a-ad29-e3b05f64042c")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Celebrity.Data.DeckConcepts", b =>
                {
                    b.HasOne("Celebrity.Data.Games", "Game")
                        .WithMany("Concepts")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Celebrity.Data.Games", b =>
                {
                    b.HasOne("Celebrity.Data.Users", "Owner")
                        .WithMany("Games")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Celebrity.Data.LoadedGames", b =>
                {
                    b.HasOne("Celebrity.Data.Games", "Game")
                        .WithMany("LoadedGames")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Celebrity.Data.TeamPoints", b =>
                {
                    b.HasOne("Celebrity.Data.TeamsInGame", "Team")
                        .WithMany("Points")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Celebrity.Data.TeamsInGame", b =>
                {
                    b.HasOne("Celebrity.Data.Games", "Game")
                        .WithMany("Teams")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Celebrity.Subcategories", b =>
                {
                    b.HasOne("Celebrity.Categories", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("IdCategory")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Celebrity.SubcategoriesInConcepts", b =>
                {
                    b.HasOne("Celebrity.Concepts", "Concepts")
                        .WithMany("SubcategoriesInconcepts")
                        .HasForeignKey("ConceptId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Celebrity.Subcategories", "Subcategories")
                        .WithMany("SubcategoriesInconcepts")
                        .HasForeignKey("SubcategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Celebrity.Data.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Celebrity.Data.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Celebrity.Data.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Celebrity.Data.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
