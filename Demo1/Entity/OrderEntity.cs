using Demo1.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo1.Entity
{
    public class OrderEntity : Entity
    {
        public string Id { get; set; }
        public double TotalPrice { get; set; }
        public StatusOrder Status { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public virtual UserEntity? User { get; set; }

    }
}
