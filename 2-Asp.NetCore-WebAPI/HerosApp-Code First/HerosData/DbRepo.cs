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
    public class DbRepo: Logic.ISuperHeroRepo, Logic.ISuperPowerRepo
    {
        private readonly SuperHeroContext context=new SuperHeroContext();
        Mapper mapper = new Mapper();
        public DbRepo()
        {
            
        }
        public DbRepo(SuperHeroContext context, Mapper mapper)
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
        public void UpdateSuperHero(int id,Logic.SuperHero hero){
            var superHero=context.SuperHeros
                                 .Where(h=>h.Id==id)
                                 .FirstOrDefault();
            if (superHero != null)
            {
                superHero = mapper.Map(hero);
                context.SuperHeros.Update(superHero);
                context.SaveChanges();
            }
        }
        public void RemoveHero(int id){
            var superHero=context.SuperHeros
                                 .Where(h=>h.Id==id)
                                 .FirstOrDefault();
            //context.SuperHeros.Remove(superHero);
            context.Remove<SuperHero>(superHero);
            context.SaveChanges();                   
        }

        /// <summary>
        /// This repo Method will only return Superpowers
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Logic.SuperPower> GetAllSuperPowers()
        {
            var powers = context.SuperPowers
            .ToList();
            return mapper.Map(powers);
        }

        public Logic.SuperPower GetSuperPowerById(int id)
        {
            var superPower = context.SuperPowers
            .Where(x => x.Id == id)
            .FirstOrDefault();
            return mapper.Map(superPower);
        }

        public void AddSuperPower(Logic.SuperPower power)
        {
            context.SuperPowers.Add(mapper.Map(power));
            context.SaveChanges();
        }

        public void RemoveSuperPower(int id)
        {
            var superPower = context.SuperPowers
                                 .Where(p => p.Id == id)
                                 .FirstOrDefault();
            context.Remove<SuperPower>(superPower);
            context.SaveChanges();
        }
    }
}