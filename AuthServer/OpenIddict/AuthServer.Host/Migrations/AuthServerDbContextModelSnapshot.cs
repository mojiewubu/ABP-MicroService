﻿// <auto-generated />
using System;
using AuthServer.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace AuthServer.Migrations
{
    [DbContext(typeof(AuthServerDbContext))]
    partial class AuthServerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.PostgreSql)
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Volo.Abp.OpenIddict.Applications.OpenIddictApplication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ClientId")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ClientSecret")
                        .HasColumnType("text");

                    b.Property<string>("ClientUri")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<string>("ConsentType")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("uuid")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.Property<string>("DisplayNames")
                        .HasColumnType("text");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uuid")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("LogoUri")
                        .HasColumnType("text");

                    b.Property<string>("Permissions")
                        .HasColumnType("text");

                    b.Property<string>("PostLogoutRedirectUris")
                        .HasColumnType("text");

                    b.Property<string>("Properties")
                        .HasColumnType("text");

                    b.Property<string>("RedirectUris")
                        .HasColumnType("text");

                    b.Property<string>("Requirements")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("OpenIddictApplications", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Authorizations.OpenIddictAuthorization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ApplicationId")
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("uuid")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uuid")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Properties")
                        .HasColumnType("text");

                    b.Property<string>("Scopes")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Subject")
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId", "Status", "Subject", "Type");

                    b.ToTable("OpenIddictAuthorizations", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Scopes.OpenIddictScope", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("uuid")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Descriptions")
                        .HasColumnType("text");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.Property<string>("DisplayNames")
                        .HasColumnType("text");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uuid")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Properties")
                        .HasColumnType("text");

                    b.Property<string>("Resources")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("OpenIddictScopes", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Tokens.OpenIddictToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ApplicationId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AuthorizationId")
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("uuid")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DeletionTime");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uuid")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Payload")
                        .HasColumnType("text");

                    b.Property<string>("Properties")
                        .HasColumnType("text");

                    b.Property<DateTime?>("RedemptionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ReferenceId")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Subject")
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorizationId");

                    b.HasIndex("ReferenceId");

                    b.HasIndex("ApplicationId", "Status", "Subject", "Type");

                    b.ToTable("OpenIddictTokens", (string)null);
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Authorizations.OpenIddictAuthorization", b =>
                {
                    b.HasOne("Volo.Abp.OpenIddict.Applications.OpenIddictApplication", null)
                        .WithMany()
                        .HasForeignKey("ApplicationId");
                });

            modelBuilder.Entity("Volo.Abp.OpenIddict.Tokens.OpenIddictToken", b =>
                {
                    b.HasOne("Volo.Abp.OpenIddict.Applications.OpenIddictApplication", null)
                        .WithMany()
                        .HasForeignKey("ApplicationId");

                    b.HasOne("Volo.Abp.OpenIddict.Authorizations.OpenIddictAuthorization", null)
                        .WithMany()
                        .HasForeignKey("AuthorizationId");
                });
#pragma warning restore 612, 618
        }
    }
}
