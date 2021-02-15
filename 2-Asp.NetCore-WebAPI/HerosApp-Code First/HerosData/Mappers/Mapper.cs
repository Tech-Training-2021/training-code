using HerosData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic=HerosLogic;

namespace HerosData.Mappers
{
    public class Mapper
    {
        public Logic.SuperHero Map(SuperHero hero)
        {
            return new Logic.SuperHero()
            {
                id = hero.Id,
                realName = hero.RealName,
                workName = hero.WorkName,
                hideOut = hero.Hideout
            };
        }
        public SuperHero Map(Logic.SuperHero hero)
        {
            return new SuperHero()
            {
                Id = hero.id,
                RealName = hero.realName,
                WorkName = hero.workName,
                Hideout = hero.hideOut
            };
        }
        public List<Logic.SuperHero> Map(List<SuperHero> heros)
        {
            List<Logic.SuperHero> allheros = new List<Logic.SuperHero>();
            foreach (var h in heros)
            {
                allheros.Add(Map(h));
            }
            return allheros;
        }
        public List<SuperHero> Map(List<Logic.SuperHero> heros)
        {
            {
                List<SuperHero> allheros = new List<SuperHero>();
                foreach (var h in heros)
                {
                    allheros.Add(Map(h));
                }
                return allheros;
            }
        }
    }
}
