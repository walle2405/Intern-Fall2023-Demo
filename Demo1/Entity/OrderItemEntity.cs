using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo1.Entity
{
    public class OrderItemEntity : Entity
    {

        [ForeignKey("CoffeeId")]
        public string CoffeeId { get; set; }
        [ForeignKey("OrderId")]
        public string OrderId { get; set; }
        public string UserId { get; set; }
        public string CoffeeName { get; set; }
        public int Volume { get; set; }
        public double UnitPrice { get; set; }
        public double ItemPrice { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public virtual CafeEntity? Coffee { get; set; }
        public virtual OrderEntity? Order { get; set; }
    }
}
