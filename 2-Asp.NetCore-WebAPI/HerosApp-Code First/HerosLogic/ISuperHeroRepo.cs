using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosLogic
{
    public interface ISuperHeroRepo
    {
        void AddSuperHero(SuperHero superHero);
       // void AddSuperPower(SuperPower superPower);// to be added in another repo file
        IEnumerable<SuperHero> GetAllHeros();
        SuperHero GetSuperHeroById(int id);
        SuperHero GetSuperHeroByName(string name);
        void UpdateSuperHero(int id,SuperHero superHero);
        void RemoveHero(int id);
    }
}
