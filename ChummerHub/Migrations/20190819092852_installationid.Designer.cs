﻿// <auto-generated />
using System;
using ChummerHub.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChummerHub.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190819092852_installationid")]
    partial class installationid
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'installationid.BuildTargetModel(ModelBuilder)'
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'installationid.BuildTargetModel(ModelBuilder)'
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChummerHub.Data.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("MyRole");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("ChummerHub.Data.ApplicationUserFavoriteGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ApplicationUserId");

                    b.Property<Guid>("FavoriteGuid");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("FavoriteGuid");

                    b.ToTable("ApplicationUserFavoriteGroup");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINner", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alias")
                        .HasMaxLength(64);

                    b.Property<string>("DownloadUrl");

                    b.Property<string>("EditionNumber")
                        .HasMaxLength(2);

                    b.Property<string>("GoogleDriveFileId");

                    b.Property<string>("Hash")
                        .HasMaxLength(8);

                    b.Property<string>("Language")
                        .HasMaxLength(6);

                    b.Property<DateTime>("LastChange");

                    b.Property<DateTime?>("LastDownload");

                    b.Property<Guid?>("MyGroupId");

                    b.Property<Guid?>("SINnerMetaDataId");

                    b.Property<Guid>("UploadClientId");

                    b.Property<DateTime?>("UploadDateTime");

                    b.HasKey("Id");

                    b.HasIndex("Alias");

                    b.HasIndex("EditionNumber");

                    b.HasIndex("Hash");

                    b.HasIndex("MyGroupId");

                    b.HasIndex("SINnerMetaDataId");

                    b.ToTable("SINners");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINnerComment", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<int>("Downloads");

                    b.Property<string>("Email");

                    b.Property<Guid?>("SINnerId");

                    b.HasKey("Id");

                    b.ToTable("SINnerComments");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINnerGroup", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("GroupCreatorUserName");

                    b.Property<string>("Groupname")
                        .HasMaxLength(64);

                    b.Property<bool>("IsPublic");

                    b.Property<string>("Language")
                        .HasMaxLength(6);

                    b.Property<string>("MyAdminIdentityRole")
                        .HasMaxLength(64);

                    b.Property<Guid?>("MyParentGroupId");

                    b.Property<Guid?>("MySettingsId");

                    b.Property<string>("PasswordHash");

                    b.HasKey("Id");

                    b.HasIndex("Groupname");

                    b.HasIndex("Language");

                    b.HasIndex("MyParentGroupId");

                    b.HasIndex("MySettingsId");

                    b.ToTable("SINnerGroups");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINnerGroupSetting", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DownloadUrl");

                    b.Property<string>("GoogleDriveFileId");

                    b.Property<DateTime>("LastChange");

                    b.Property<Guid>("MyGroupId");

                    b.Property<DateTime?>("UploadDateTime");

                    b.HasKey("Id");

                    b.ToTable("SINnerGroupSettings");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINnerMetaData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("VisibilityId");

                    b.HasKey("Id");

                    b.HasIndex("VisibilityId");

                    b.ToTable("SINnerMetaData");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINnerUserRight", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CanEdit");

                    b.Property<string>("EMail")
                        .HasMaxLength(64);

                    b.Property<Guid?>("SINnerId");

                    b.Property<Guid?>("SINnerVisibilityId");

                    b.HasKey("Id");

                    b.HasIndex("EMail");

                    b.HasIndex("SINnerId");

                    b.HasIndex("SINnerVisibilityId");

                    b.ToTable("UserRights");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINnerVisibility", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsGroupVisible");

                    b.Property<bool>("IsPublic");

                    b.HasKey("Id");

                    b.ToTable("SINnerVisibility");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsUserGenerated");

                    b.Property<Guid?>("ParentTagId");

                    b.Property<Guid?>("SINnerId");

                    b.Property<Guid?>("SINnerMetaDataId");

                    b.Property<string>("TagComment")
                        .HasMaxLength(64);

                    b.Property<Guid?>("TagId");

                    b.Property<string>("TagName")
                        .HasMaxLength(64);

                    b.Property<int>("TagType");

                    b.Property<string>("TagValue")
                        .HasMaxLength(64);

                    b.Property<double?>("TagValueDouble");

                    b.HasKey("Id");

                    b.HasIndex("SINnerId");

                    b.HasIndex("SINnerMetaDataId");

                    b.HasIndex("TagId");

                    b.HasIndex("TagValueDouble");

                    b.HasIndex("TagName", "TagValue");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.UploadClient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChummerVersion");

                    b.Property<string>("ClientSecret");

                    b.Property<Guid?>("InstallationId");

                    b.Property<string>("UserEmail");

                    b.HasKey("Id");

                    b.ToTable("UploadClients");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Groupname");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ChummerHub.Data.ApplicationUserFavoriteGroup", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser")
                        .WithMany("FavoriteGroups")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINner", b =>
                {
                    b.HasOne("ChummerHub.Models.V1.SINnerGroup", "MyGroup")
                        .WithMany()
                        .HasForeignKey("MyGroupId");

                    b.HasOne("ChummerHub.Models.V1.SINnerMetaData", "SINnerMetaData")
                        .WithMany()
                        .HasForeignKey("SINnerMetaDataId");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINnerGroup", b =>
                {
                    b.HasOne("ChummerHub.Models.V1.SINnerGroup", "MyParentGroup")
                        .WithMany("MyGroups")
                        .HasForeignKey("MyParentGroupId");

                    b.HasOne("ChummerHub.Models.V1.SINnerGroupSetting", "MySettings")
                        .WithMany()
                        .HasForeignKey("MySettingsId");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINnerMetaData", b =>
                {
                    b.HasOne("ChummerHub.Models.V1.SINnerVisibility", "Visibility")
                        .WithMany()
                        .HasForeignKey("VisibilityId");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.SINnerUserRight", b =>
                {
                    b.HasOne("ChummerHub.Models.V1.SINnerVisibility")
                        .WithMany("UserRights")
                        .HasForeignKey("SINnerVisibilityId");
                });

            modelBuilder.Entity("ChummerHub.Models.V1.Tag", b =>
                {
                    b.HasOne("ChummerHub.Models.V1.SINnerMetaData")
                        .WithMany("Tags")
                        .HasForeignKey("SINnerMetaDataId");

                    b.HasOne("ChummerHub.Models.V1.Tag")
                        .WithMany("Tags")
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("ChummerHub.Data.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("ChummerHub.Data.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
