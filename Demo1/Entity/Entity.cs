using System.ComponentModel.DataAnnotations;

namespace Demo1.Entity
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid().ToString("N");
            CreateTimes = DateTime.Now;
            LastUpdateTimes = DateTime.Now;
        }
        

        [Key]
        public string Id { get; set; }
        public DateTime CreateTimes { get; set; }
        public DateTime LastUpdateTimes { get; set; }

    }



}
