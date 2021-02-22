using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HerosData.Entities
{
   public class SuperPower
    {
        public SuperPower()
        {

        }
        public SuperPower(int id,string name, string description, int? ownerId)
        {
            Id = id;
            Name = name;
            Description = description;
            Ownerid = ownerId;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        public int? Ownerid { get; set; }
        public virtual SuperHero Owner { get; set; }
    }
}