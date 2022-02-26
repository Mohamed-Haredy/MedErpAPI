﻿// <auto-generated />
using System;
using MedErp.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedErp.Infrastructure.Migrations
{
    [DbContext(typeof(MedErpDBContext))]
    partial class MedErpDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MedErp.Domain.Entities.Inventory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long?>("AisleId")
                        .HasColumnType("bigint")
                        .HasColumnName("aisleid");

                    b.Property<long>("ClientId")
                        .HasColumnType("bigint")
                        .HasColumnName("clientid");

                    b.Property<long>("CreateBy")
                        .HasColumnType("bigint")
                        .HasColumnName("createby");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("createdate");

                    b.Property<bool?>("Fulfill")
                        .HasColumnType("bit")
                        .HasColumnName("fulfill");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit")
                        .HasColumnName("isremoved");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("note");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<string>("RequestBy")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("requestby");

                    b.Property<DateTime?>("RequestDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("requestdate");

                    b.Property<long?>("SupplyerId")
                        .HasColumnType("bigint")
                        .HasColumnName("supplyerid");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint")
                        .HasColumnName("updatedby");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("updateddate");

                    b.HasKey("Id")
                        .HasName("pk_inventories");

                    b.ToTable("Inventories", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
