using System;
using HerosData.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace  HerosData
{
    // This is the class which has all the CRUD operations related to Super Hero and their powers
    public class SuperHeroRepo
    {
        SuperHeroContext context=new SuperHeroContext();
        public SuperHeroRepo()
        {
            
        }
        public SuperHeroRepo(SuperHeroContext context)
        {
            this.context=context;
        }
        public void AddSuperHero(SuperHero hero){
            context.SuperHeros.Add(hero);
            context.SaveChanges();
        }
        public void AddSuperPower(SuperPower power){
            context.SuperPowers.Add(power);
            context.SaveChanges();
        }
        public IEnumerable<SuperHero> GetAllHeros(){
            var query= context.SuperHeros
            .Include("superpower");
            return query;
        }
        public SuperHero GetSuperHeroById(int id){
            var superHero=context.SuperHeros
            .Where(x=>x.Id==id)
            .Include("SuperPower")
            .FirstOrDefault();
            return superHero;
        }
        public SuperHero GetSuperHeroByName(String name){
            var superHero=context.SuperHeros
            .Where(x=>x.WorkName==name)
            .Include("SuperPower")
            .FirstOrDefault();
            return superHero;
        }
        public SuperHero UpdateSuperHero(SuperHero hero){
            var superHero=context.SuperHeros
                                 .Where(h=>h.Id==hero.Id)
                                 .FirstOrDefault();
            superHero=hero;
            context.SaveChanges();
            return superHero;
        }
        public void RemoveHero(int id){
            var superHero=context.SuperHeros
                                 .Where(h=>h.Id==id)
                                 .FirstOrDefault();
            //context.SuperHeros.Remove(superHero);
            context.Remove<SuperHero>(superHero);
            context.SaveChanges();                   
        }
    }
}
