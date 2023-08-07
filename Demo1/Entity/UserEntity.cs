using Demo1.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo1.Entity
{
    [Table("User")]
    public class UserEntity : Entity
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }
        public Roles Role { get; set; }

    }
}
