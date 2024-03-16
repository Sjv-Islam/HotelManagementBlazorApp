using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementBlazorApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HotelManagementBlazorApp.Info
{
    public class GuestDb: DbContext
    {
        public DbSet<Guest> Guests { get; set; } = default!;
        public DbSet<RoomType> RoomTypes { get; set; } = default!;
        public GuestDb(DbContextOptions opt) : base(opt)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server = .;Database= ResortDb; Trusted_Connection = true; trust server certificate= true;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomType>().HasData(new RoomType[]
            {
                new RoomType
                {
                    RoomTypeId = 1,
                    TypeName = "Standard",
                    PricePerNight = 1500
                },
                new RoomType
                {
                    RoomTypeId = 2,
                    TypeName = "Premium",
                    PricePerNight = 2500
                },
                new RoomType
                {
                    RoomTypeId = 3,
                    TypeName = "Deluxe",
                    PricePerNight = 3500
                }
            });

            modelBuilder.Entity<Guest>().HasData(new Guest[]
            {
                new Guest
                {
                    GuestId = 1,
                    FirstName = "Saidul",
                    LastName = "Islam",
                    Email = "SaidulIslam@gmail.com",
                    PhoneNumber = "1234567890",
                    DateOfBirth = new DateTime(1995,04,01),
                    CheckInDate = DateTime.Today.AddDays(-1),
                    CheckOutDate = DateTime.Today.AddDays(3),
                    TotalAmountPaid = 2500,
                    PaymentStatus = "Paid",
                    IsCheckedOut = true,
                    RoomTypeId = 2
                },
                new Guest
                {
                    GuestId = 2,
                    FirstName = "A.S.M",
                    LastName = "Sayem",
                    Email = "ASMSayem@gmail.com",
                    PhoneNumber = "1234567890",
                    DateOfBirth = new DateTime(1996,04,01),
                    CheckInDate = DateTime.Today.AddDays(-1),
                    CheckOutDate = DateTime.Today.AddDays(3),
                    TotalAmountPaid = 1500,
                    PaymentStatus = "Paid",
                    IsCheckedOut = false,
                    RoomTypeId = 1
                },
                new Guest
                {
                    GuestId = 3,
                    FirstName = "Mohammad",
                    LastName = "Maruf",
                    Email = "MohammadMaruf@gmail.com",
                    PhoneNumber = "1234567890",
                    DateOfBirth = new DateTime(1995,06,01),
                    CheckInDate = DateTime.Today.AddDays(-1),
                    CheckOutDate = DateTime.Today.AddDays(3),
                    TotalAmountPaid = 3500,
                    PaymentStatus = "Paid",
                    IsCheckedOut = true,
                    RoomTypeId = 3
                },
                new Guest
                {
                    GuestId = 4,
                    FirstName = "Abdullah",
                    LastName = "Toha",
                    Email = "AbdullahToha@gmail.com",
                    PhoneNumber = "1234567890",
                    DateOfBirth = new DateTime(1994,06,05),
                    CheckInDate = DateTime.Today.AddDays(-1),
                    CheckOutDate = DateTime.Today.AddDays(3),
                    TotalAmountPaid = 2500,
                    PaymentStatus = "Paid",
                    IsCheckedOut = false,
                    RoomTypeId = 2
                },
                new Guest
                {
                    GuestId = 5,
                    FirstName = "Minhaj",
                    LastName = "Chowdhury",
                    Email = "MinhajChowdhury@gmail.com",
                    PhoneNumber = "1234567890",
                    DateOfBirth = new DateTime(1995,06,05),
                    CheckInDate = DateTime.Today.AddDays(-1),
                    CheckOutDate = DateTime.Today.AddDays(3),
                    TotalAmountPaid = 3500,
                    PaymentStatus = "Paid",
                    IsCheckedOut = true,
                    RoomTypeId = 3
                }
            });
        }
    }
}
