﻿using HerosLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerosApi.Controllers
{
    [Route("api/[controller]")]
    public class SuperHeroesController : MyControllerBase
    {
        private readonly ISuperHeroRepo repo;
        public SuperHeroesController(ISuperHeroRepo repo)
        {
            this.repo = repo;
        }
        /// <summary>
        /// Returns all superheroes
        /// </summary>
        /// <returns>List of SuperHeros</returns>
        [HttpGet("get")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type=typeof(IEnumerable<SuperHero>)]// only use typeof if return type is IActionResult
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        /*public ActionResult<SuperHero> Get()
        {
            //return Content("Hello Asp.Net Core Web API");
            return new SuperHero() { id = 10, realName = "Tony Stark", hideOut = "Garage", workName = "Iron man" };
        }*/
        public ActionResult<IEnumerable<SuperHero>> Get()
        {
            //return repo.GetAllHeros();
            try
            {
                // returning status code 200
                return Ok(repo.GetAllHeros());
            }
            catch(Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
        /// <summary>
        /// Get SuperHero by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>SuperHero</returns>
        [HttpGet("get/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<SuperHero> GetById([FromRoute]int id)  
        {
            try
            {
                // retruning status code 200
                return  Ok(repo.GetSuperHeroById(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        /// <summary>
        /// Get SuperHero by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("get/{name}")]
        public IActionResult GetByName([FromRoute]string name)
        {
            try
            {
                // retruning status code 200
                return Ok(repo.GetSuperHeroByName(name));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        /// <summary>
        /// Add a SuperHero in the Azure Sql Db
        /// </summary>
        /// <param name="hero"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(SuperHero hero)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    repo.AddSuperHero(hero);
                    return NoContent();// 204 status
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Update the SuperHero
        /// </summary>
        /// <param name="id"></param>
        /// <param name="superHero"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put([FromRoute]int id,[FromBody]SuperHero superHero)
        {
            try
            {
                repo.UpdateSuperHero(id,superHero);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        /// <summary>
        /// Deletes a SuperHero from Specific Location
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete([FromRoute]int id)
        {
            try
            {
                repo.RemoveHero(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

    }
}
