﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PulseConnect.Data;

#nullable disable

namespace PulseConnect.Migrations
{
    [DbContext(typeof(APIDbContext))]
    partial class APIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

<<<<<<< HEAD
<<<<<<< HEAD
            modelBuilder.Entity("PulseConnect.Models.PasswordReset", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("id");

                    b.Property<string>("ConfirmNewPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Expire_Date");

                    b.Property<string>("NewPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Token");
=======
            modelBuilder.Entity("PulseConnect.Models.Session", b =>
                {
                    b.Property<string>("SessionID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Session ID");

                    b.Property<DateTime?>("SessionEndTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("Session End Time");

                    b.Property<DateTime>("SessionStartTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("Session Start Time");

                    b.Property<string>("SessionToken")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Session Token");
>>>>>>> 146-user-session-management

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
<<<<<<< HEAD
                        .HasColumnName("user_id");

                    b.Property<string>("currentPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("PasswordReset");
=======
            modelBuilder.Entity("PulseConnect.Models.Connections", b =>
                {
                    b.Property<string>("ID_Connection")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("id_connection");

                    b.Property<DateTime>("Connection_Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("connection_date");

                    b.Property<int>("Connection_Status")
                        .HasColumnType("int")
                        .HasColumnName("connection_status");

                    b.Property<string>("ID_User_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("id_user_1");

                    b.Property<string>("ID_User_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("id_user_2");

                    b.HasKey("ID_Connection");

                    b.ToTable("Connections");
>>>>>>> 47fdeff0e519e238bb4737fa2097eeb4863eb5b8
=======
                        .HasColumnName("User ID");

                    b.HasKey("SessionID");

                    b.HasIndex("UserID");

                    b.ToTable("Sessions");
>>>>>>> 146-user-session-management
                });

            modelBuilder.Entity("PulseConnect.Models.Users", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("id");

                    b.Property<string>("BIO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BIO");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Country");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date_Created");

                    b.Property<int>("Gender")
                        .HasColumnType("int")
                        .HasColumnName("Gender");

                    b.Property<DateTime>("Last_Active")
                        .HasColumnType("datetime2")
                        .HasColumnName("Last_Active");

                    b.Property<string>("Multi_FactorCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Multi_FactorCode");

                    b.Property<bool>("Multi_FactorEnable")
                        .HasColumnType("bit")
                        .HasColumnName("Multi_FactorEnable");

                    b.Property<DateTime>("Multi_FactorExpired")
                        .HasColumnType("datetime2")
                        .HasColumnName("Multi_FactorExpired");

                    b.Property<int>("Multi_FactorType")
                        .HasColumnType("int")
                        .HasColumnName("Multi_FactorType");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Password");

                    b.Property<string>("Profile_Picture_URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Profile_Picture_URL");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserEmail");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserName");

                    b.HasKey("ID");

                    b.ToTable("Users");
<<<<<<< HEAD
<<<<<<< HEAD
                });

            modelBuilder.Entity("PulseConnect.Models.PasswordReset", b =>
=======
                });

            modelBuilder.Entity("PulseConnect.Models.Session", b =>
>>>>>>> 146-user-session-management
                {
                    b.HasOne("PulseConnect.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
<<<<<<< HEAD
=======
>>>>>>> 47fdeff0e519e238bb4737fa2097eeb4863eb5b8
=======
>>>>>>> 146-user-session-management
                });
#pragma warning restore 612, 618
        }
    }
}
