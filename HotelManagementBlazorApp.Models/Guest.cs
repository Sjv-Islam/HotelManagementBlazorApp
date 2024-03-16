using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementBlazorApp.Models
{
    [Table(nameof(Guest))]
    public class Guest
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GuestId { get; set; }
        [Required]
        public string FirstName { get; set; } = default!;
        [Required]
        public string LastName { get; set; } = default!;
        public string FullName => $"{FirstName} {LastName}";
        [Required]
        public string Email { get; set; } = default!;
        [Required]
        public string PhoneNumber { get; set; } = default!;
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public DateTime CheckInDate { get; set; } = DateTime.Now;
        [Required]
        public DateTime CheckOutDate { get; set; } = DateTime.Now;
        [Required]
        public decimal TotalAmountPaid { get; set; }
        [Required]
        public string PaymentStatus { get; set; } = default!;
        [Required]
        public bool IsCheckedOut { get; set; }

        [ForeignKey(nameof(RoomType.RoomTypeId))]
        public int RoomTypeId { get; set; }
        public RoomType? RoomType { get; set; }
    }

}
