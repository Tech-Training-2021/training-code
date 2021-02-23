namespace ConsumeSuperHeros_Server.Models
{
    public class SuperHero
    {
        public int id { get; set; }
        public string realName { get; set; }
        public string workName { get; set; }
        public string hideOut { get; set; }
        public SuperPower superPower { get; set; }

    }
}
