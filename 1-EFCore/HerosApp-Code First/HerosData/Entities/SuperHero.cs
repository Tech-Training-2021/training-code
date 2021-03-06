using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HerosData.Entities
{
    [Table("superhero")]
    public class SuperHero
    {
        // An entity which has int type property as Id/ClassnameId is automatically presumed as PK in EFCore
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string RealName { get; set; }
        [StringLength(30)]
        public string WorkName { get; set; }
        [StringLength(50)]
        public string Hideout { get; set; }
        public virtual SuperPower SuperPower { get; set; }
    } 
}
