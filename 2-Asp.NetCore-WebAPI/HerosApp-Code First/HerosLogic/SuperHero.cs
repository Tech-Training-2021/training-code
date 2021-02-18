using System;
using System.ComponentModel.DataAnnotations;

namespace HerosLogic
{
    public class SuperHero
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Real name cannot be left blank")]
        [StringLength(25,ErrorMessage ="Not accepting more than 25 characters")]
        public string realName { get; set; }
        [Required(ErrorMessage ="work name cannot be left blank")]
        public string workName { get; set; }
        public string hideOut { get; set; }
        public SuperPower superPower { get; set; }

    }
}
