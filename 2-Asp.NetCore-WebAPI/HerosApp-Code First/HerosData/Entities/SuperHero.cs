using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks.Dataflow;

namespace HerosData.Entities
{
    [Table("superhero")]
    public class SuperHero
    {
        public SuperHero()
        {

        }
        public SuperHero(int id, string realName, string workName, string hideOut)
        {
            Id = id;
            RealName = realName;
            WorkName = workName;
            Hideout = hideOut;
        }
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
