﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechChallenge.Data.Context;

#nullable disable

namespace TechChallenge.Data.Migrations
{
    [DbContext(typeof(techchallengeDbContext))]
    [Migration("20240616205651_TechChallenge")]
    partial class TechChallenge
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechChallenge.Domain.Models.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<Guid>("StateId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Contact", "TechChallenge");
                });

            modelBuilder.Entity("TechChallenge.Domain.Models.State", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DDD")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("State", "TechChallenge");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3bf9db6c-9c38-4eea-9223-2476276ac1b6"),
                            DDD = 11,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("e3f40438-de17-4a92-b89d-c14f4caf46c6"),
                            DDD = 12,
                            Name = "Santos"
                        },
                        new
                        {
                            Id = new Guid("dd5f54b0-9b77-4c2f-9bd2-b6f1169bc6ab"),
                            DDD = 13,
                            Name = "Campinas"
                        },
                        new
                        {
                            Id = new Guid("24f07ea5-9a36-46e2-ae6c-7f7d273bb7aa"),
                            DDD = 14,
                            Name = "Bauru"
                        },
                        new
                        {
                            Id = new Guid("be5ae194-f1df-41e5-a5ed-8b274bddace8"),
                            DDD = 15,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("9a377066-cb29-4806-8a59-6835d49618a8"),
                            DDD = 16,
                            Name = "São Carlos"
                        },
                        new
                        {
                            Id = new Guid("83970506-ef79-4d3a-b36a-a03471537257"),
                            DDD = 17,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("cb934fbb-d2bd-4860-8546-cc84c960b54d"),
                            DDD = 18,
                            Name = "Presidente Prudente"
                        },
                        new
                        {
                            Id = new Guid("18729586-fd1e-4613-b5a5-b27d80171322"),
                            DDD = 19,
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("914de0b0-209c-4ad9-8d8a-8723b72a2c79"),
                            DDD = 21,
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = new Guid("e7a398bb-06ee-4218-9a68-687d6614babf"),
                            DDD = 22,
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = new Guid("2a98b12d-e0b5-4e63-9be4-888540a43545"),
                            DDD = 24,
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = new Guid("d3521ac6-e2ce-4cfa-b122-fc1a84ae4f34"),
                            DDD = 27,
                            Name = "Espírito Santo"
                        },
                        new
                        {
                            Id = new Guid("10e26e10-331a-43b0-8312-16e85f013820"),
                            DDD = 28,
                            Name = "Espírito Santo"
                        },
                        new
                        {
                            Id = new Guid("b82bb752-0fb4-43f2-ba47-775579312ea8"),
                            DDD = 31,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("4af95538-6ca3-454e-b899-3aea7ad90b47"),
                            DDD = 32,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("1f6e436c-04e9-42b6-91e2-aebe8773b4ef"),
                            DDD = 33,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("26495868-993e-44b8-b7eb-1d636783a61d"),
                            DDD = 34,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("c4247d1c-4375-48a2-a639-5adfea74d299"),
                            DDD = 35,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("3a209058-3fa6-491c-918e-5ea0eb359824"),
                            DDD = 37,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("f6fc5b3b-94cc-4519-8d33-5173b07fbe76"),
                            DDD = 38,
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("3bcb5933-e8b4-47fe-ac09-556386d90df8"),
                            DDD = 41,
                            Name = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("a423e610-41f2-415d-8443-1aa414c01905"),
                            DDD = 42,
                            Name = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("9979754d-9509-4da9-977e-a131d1ac0eaf"),
                            DDD = 43,
                            Name = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("3c42154c-abd4-49a1-b4ee-0a29a181b4da"),
                            DDD = 44,
                            Name = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("da92e583-4501-4518-b24e-bd2f2d0b09b5"),
                            DDD = 45,
                            Name = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("e60e40ac-5c8c-4107-a9c6-28a49102ae0b"),
                            DDD = 46,
                            Name = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("5cfa9857-5e67-460f-a093-b4366cea3398"),
                            DDD = 47,
                            Name = "Santa Catarina"
                        },
                        new
                        {
                            Id = new Guid("7fdc504e-73fd-4781-99cc-d1bb9169e70e"),
                            DDD = 48,
                            Name = "Santa Catarina"
                        },
                        new
                        {
                            Id = new Guid("8c9b87f6-91a0-4593-896f-0240b25231b1"),
                            DDD = 49,
                            Name = "Santa Catarina"
                        },
                        new
                        {
                            Id = new Guid("78b528e2-5f03-436c-b5e8-a5b019c5337e"),
                            DDD = 51,
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = new Guid("ef06c558-740a-4e80-8769-ad18b7aa575b"),
                            DDD = 53,
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = new Guid("5e9d31b6-ac64-4f70-bda2-f7ef1333a0b5"),
                            DDD = 54,
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = new Guid("890f1d75-a389-4487-860f-a7e0db004d48"),
                            DDD = 55,
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = new Guid("633f319b-ddc3-48ae-ae40-7412c3e9f872"),
                            DDD = 61,
                            Name = "Distrito Federal"
                        },
                        new
                        {
                            Id = new Guid("88d05483-e490-4e6e-b62e-bf9c07719933"),
                            DDD = 62,
                            Name = "Goiás"
                        },
                        new
                        {
                            Id = new Guid("fa0a3181-090e-4add-b7af-be8cd3819b73"),
                            DDD = 64,
                            Name = "Goiás"
                        },
                        new
                        {
                            Id = new Guid("32d395d8-0bd3-4938-bd50-02debc7aa493"),
                            DDD = 63,
                            Name = "Tocantins"
                        },
                        new
                        {
                            Id = new Guid("206b5235-9768-4268-8fc2-22d804cf5d53"),
                            DDD = 65,
                            Name = "Mato Grosso"
                        },
                        new
                        {
                            Id = new Guid("748d975f-cf68-4d65-a961-6b8e95e9e096"),
                            DDD = 66,
                            Name = "Mato Grosso"
                        },
                        new
                        {
                            Id = new Guid("c3a4ffb2-efb5-41d3-838f-10364c3a64cd"),
                            DDD = 67,
                            Name = "Mato Grosso do Sul"
                        },
                        new
                        {
                            Id = new Guid("e7f1b8ff-affb-4c95-9447-bf389eb8fdd1"),
                            DDD = 68,
                            Name = "Acre"
                        },
                        new
                        {
                            Id = new Guid("c56b895d-0e4b-4955-b167-936df8e35d8c"),
                            DDD = 69,
                            Name = "Rondônia"
                        },
                        new
                        {
                            Id = new Guid("ba26ed12-76f0-4093-96d2-3ff478eef6e4"),
                            DDD = 71,
                            Name = "Bahia"
                        },
                        new
                        {
                            Id = new Guid("7703675a-aebd-402e-8a73-0377e918825f"),
                            DDD = 73,
                            Name = "Bahia"
                        },
                        new
                        {
                            Id = new Guid("dd032727-ecf1-4010-8104-667c965dea11"),
                            DDD = 74,
                            Name = "Bahia"
                        },
                        new
                        {
                            Id = new Guid("1d94638e-b1b9-4f32-a052-c0a2f4297c12"),
                            DDD = 75,
                            Name = "Bahia"
                        },
                        new
                        {
                            Id = new Guid("2b692122-aede-477a-afad-3cf346d5935a"),
                            DDD = 77,
                            Name = "Bahia"
                        },
                        new
                        {
                            Id = new Guid("41334dfa-e03a-4c82-a8f8-f2a3318da710"),
                            DDD = 79,
                            Name = "Sergipe"
                        },
                        new
                        {
                            Id = new Guid("2d2c8946-b2b1-4a9d-bdbd-1499f9876d01"),
                            DDD = 81,
                            Name = "Pernambuco"
                        },
                        new
                        {
                            Id = new Guid("79a7e486-7cf1-4626-9161-5ca80a28763c"),
                            DDD = 87,
                            Name = "Pernambuco"
                        },
                        new
                        {
                            Id = new Guid("801c43e2-248d-428e-88b0-eb57ae565a9e"),
                            DDD = 86,
                            Name = "Piauí"
                        },
                        new
                        {
                            Id = new Guid("f199d964-f43a-4d78-a59a-6364ecfddca1"),
                            DDD = 89,
                            Name = "Piauí"
                        },
                        new
                        {
                            Id = new Guid("93c134a8-51ee-4d40-a39a-8ef437fd1ebd"),
                            DDD = 82,
                            Name = "Alagoas"
                        },
                        new
                        {
                            Id = new Guid("c490578b-040c-49f3-8759-fe98e9d94589"),
                            DDD = 83,
                            Name = "Paraíba"
                        },
                        new
                        {
                            Id = new Guid("9371cedd-97d4-4d4e-b398-82a7b1b337a2"),
                            DDD = 84,
                            Name = "Rio Grande do Norte"
                        },
                        new
                        {
                            Id = new Guid("cdccbf39-6484-4460-b47c-a47b7e97f44d"),
                            DDD = 85,
                            Name = "Ceará"
                        },
                        new
                        {
                            Id = new Guid("2d591927-758d-4868-be77-9566d3a12728"),
                            DDD = 88,
                            Name = "Ceará"
                        },
                        new
                        {
                            Id = new Guid("1b7193d5-a83a-4ab5-b2cf-7d07c75416b8"),
                            DDD = 96,
                            Name = "Amapá"
                        },
                        new
                        {
                            Id = new Guid("7274da2e-9841-46de-b2cd-50b84079727c"),
                            DDD = 92,
                            Name = "Amazonas"
                        },
                        new
                        {
                            Id = new Guid("17753136-39e0-4592-aca5-93f2d536f767"),
                            DDD = 97,
                            Name = "Amazonas"
                        },
                        new
                        {
                            Id = new Guid("9afb4914-428e-4655-bd53-bc2340c958d9"),
                            DDD = 91,
                            Name = "Pará"
                        },
                        new
                        {
                            Id = new Guid("31ab3648-7e72-4fdc-81f0-6b1f71d6c834"),
                            DDD = 93,
                            Name = "Pará"
                        },
                        new
                        {
                            Id = new Guid("2c3bcd63-f6dc-44e3-94e7-fbf7c811fc1c"),
                            DDD = 94,
                            Name = "Pará"
                        },
                        new
                        {
                            Id = new Guid("246bb6d9-f67e-42a5-ad35-f03f062e12a6"),
                            DDD = 95,
                            Name = "Roraima"
                        },
                        new
                        {
                            Id = new Guid("5ca01f72-70b2-4c6a-9c54-140024a17af1"),
                            DDD = 98,
                            Name = "Maranhão"
                        },
                        new
                        {
                            Id = new Guid("424f5729-f346-42ef-a4d3-74534d15beef"),
                            DDD = 99,
                            Name = "Maranhão"
                        });
                });

            modelBuilder.Entity("TechChallenge.Domain.Models.Contact", b =>
                {
                    b.HasOne("TechChallenge.Domain.Models.State", "State")
                        .WithMany("Contacts")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("TechChallenge.Domain.Models.State", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
