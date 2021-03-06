// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuiviClientCovid.ORM;

namespace SuiviClientCovid.ORM.Migrations
{
    [DbContext(typeof(Contexte))]
    [Migration("20210109143957_MAJ_Update_BDD_Injection")]
    partial class MAJ_Update_BDD_Injection
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("SuiviClientCovid.ORM.Injection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateRappel")
                        .HasColumnType("TEXT");

                    b.Property<string>("Marque")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("NuméroDuLot")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PersonneId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypesVaccinId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PersonneId");

                    b.HasIndex("TypesVaccinId");

                    b.ToTable("Injections");
                });

            modelBuilder.Entity("SuiviClientCovid.ORM.Personne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateDeNaissance")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Prenom")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Résident_Ou_Personnel")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Sexe")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Personnes");
                });

            modelBuilder.Entity("SuiviClientCovid.ORM.TypesVaccin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TypesVaccins");
                });

            modelBuilder.Entity("SuiviClientCovid.ORM.Injection", b =>
                {
                    b.HasOne("SuiviClientCovid.ORM.Personne", null)
                        .WithMany("Injections")
                        .HasForeignKey("PersonneId");

                    b.HasOne("SuiviClientCovid.ORM.TypesVaccin", "TypesVaccins")
                        .WithMany("Injections")
                        .HasForeignKey("TypesVaccinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypesVaccins");
                });

            modelBuilder.Entity("SuiviClientCovid.ORM.Personne", b =>
                {
                    b.Navigation("Injections");
                });

            modelBuilder.Entity("SuiviClientCovid.ORM.TypesVaccin", b =>
                {
                    b.Navigation("Injections");
                });
#pragma warning restore 612, 618
        }
    }
}
