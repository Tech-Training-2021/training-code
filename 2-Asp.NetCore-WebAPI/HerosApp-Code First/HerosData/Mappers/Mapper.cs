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
        public Logic.SuperPower Map(SuperPower power)
        {
            return new Logic.SuperPower()
            {
                id = power.Id,
                name = power.Name,
                description = power.Description,
                ownerId = power.Ownerid
            };
        }
        public SuperPower Map(Logic.SuperPower power)
        {
            return new SuperPower()
            {
                Id = power.id,
                Name = power.name,
                Description = power.description,
                Ownerid = power.ownerId
            };
        }
        public List<Logic.SuperPower> Map(List<SuperPower> powers)
        {
            List<Logic.SuperPower> allheros = new List<Logic.SuperPower>();
            foreach (var p in powers)
            {
                allheros.Add(Map(p));
            }
            return allheros;
        }
    }
}