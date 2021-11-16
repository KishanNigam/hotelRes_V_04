﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hotelRes_V_03.Data;

namespace hotelRes_V_03.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("hotelRes_V_03.Data.Models.Guest_Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Guest_contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guest_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guest_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Guest_Profiles");
                });

            modelBuilder.Entity("hotelRes_V_03.Data.Models.Hotel_Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hotel_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pin_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("hotel_Details");
                });

            modelBuilder.Entity("hotelRes_V_03.Data.Models.Invoice_Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Guest_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hotel_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("payment_method")
                        .HasColumnType("int");

                    b.Property<int>("room_service_charge")
                        .HasColumnType("int");

                    b.Property<int>("total_cost")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("invoice_Bills");
                });

            modelBuilder.Entity("hotelRes_V_03.Data.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CheckIn_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuestId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hotel_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("number_of_guest")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
