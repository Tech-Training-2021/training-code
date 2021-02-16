using System;
using HerosData.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Logic=HerosLogic;
using HerosData.Mappers;

namespace HerosData
{
    // This is the class which has all the CRUD operations related to Super Hero and their powers
    public class SuperHeroRepo: Logic.ISuperHeroRepo
    {
        private readonly SuperHeroContext context=new SuperHeroContext();
        Mapper mapper = new Mapper();
        public SuperHeroRepo()
        {
            
        }
        public SuperHeroRepo(SuperHeroContext context, Mapper mapper)
        {
            this.context=context;
            this.mapper = mapper;
        }
        public void AddSuperHero(Logic.SuperHero hero){
            context.SuperHeros.Add(mapper.Map(hero));
            context.SaveChanges();
        }
        /*public void AddSuperPower(SuperPower power){
            context.SuperPowers.Add(power);
            context.SaveChanges();
        }*/
        /// <summary>
        /// This repo Method will only return Superheroes
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Logic.SuperHero> GetAllHeros(){
            var heroes= context.SuperHeros
            .ToList();
            return mapper.Map(heroes);
        }
        public Logic.SuperHero GetSuperHeroById(int id){
            var superHero=context.SuperHeros
            .Where(x=>x.Id==id)
            .Include("SuperPower")
            .FirstOrDefault();
            return mapper.Map(superHero);
        }
        public Logic.SuperHero GetSuperHeroByName(String name){
            var superHero=context.SuperHeros
            .Where(x=>x.WorkName==name)
            .Include("SuperPower")
            .FirstOrDefault();
            return mapper.Map(superHero);
        }
        public Logic.SuperHero UpdateSuperHero(Logic.SuperHero hero){
            var superHero=context.SuperHeros
                                 .Where(h=>h.Id==hero.id)
                                 .FirstOrDefault();
            superHero=mapper.Map(hero);
            context.SaveChanges();
            return mapper.Map(superHero);
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
