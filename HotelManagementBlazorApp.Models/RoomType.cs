using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementBlazorApp.Models
{
    [Table(nameof(RoomType))]
    public class RoomType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomTypeId { get; set; }
        [Required, NotNull]
        public string TypeName { get; set; } = default!;
        [Required]
        public decimal PricePerNight { get; set; }

        public ICollection<Guest> Guests { get; set; } = [];

    }
}
