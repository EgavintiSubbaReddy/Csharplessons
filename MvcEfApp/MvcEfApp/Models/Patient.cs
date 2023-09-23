using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEfApp.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        [Column(TypeName = "numeric(18,0)")]
        public Decimal PhoneNumber { get; set; }
    }
}
