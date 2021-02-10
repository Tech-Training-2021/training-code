using System;
using HerosData;
using HerosData.Entities;

namespace HerosConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHeroRepo repo=new SuperHeroRepo();
            // SuperHero hero=new SuperHero();
            // hero.Hideout="His Bedroom";
           // repo.AddSuperHero(hero);
           // var superHero=repo.GetSuperHeroById(3);
           // Console.WriteLine($"{superHero.Id} {superHero.RealName} {superHero.WorkName} {superHero.Hideout}");
           /* SuperPower power=new SuperPower(){
                Name="Hammer",
                Description="Magical Hammer that can take Thor to Asgard and break anything",
                Ownerid=1
            };*/
           //repo.AddSuperPower(power);
           //superHero.Hideout="His Bedroom";
          // var SuperHero=repo.UpdateSuperHero(superHero);
          // Console.Write("Update changes");
          // Console.WriteLine($"{SuperHero.Id} {SuperHero.RealName} {SuperHero.WorkName} {SuperHero.Hideout}");
          repo.RemoveHero(3);
        }
    }
}
