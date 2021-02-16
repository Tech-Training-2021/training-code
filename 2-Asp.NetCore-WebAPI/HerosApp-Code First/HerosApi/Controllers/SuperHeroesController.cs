using HerosLogic;
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
    [ApiController]
    public class SuperHeroesController : ControllerBase
    {
        private readonly ISuperHeroRepo repo;
        public SuperHeroesController(ISuperHeroRepo repo)
        {
            this.repo = repo;
        }
        [HttpGet("get")]
        public IActionResult Get()
        {
            try
            {
                // retruning status code 200
                return Ok(repo.GetAllHeros());
            }
            catch(Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
        [HttpGet("get/{id}")]
        public IActionResult Get([FromRoute]int id)
        {
            try
            {
                // retruning status code 200
                return Ok(repo.GetSuperHeroById(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet("get/{name}")]
        public IActionResult Get([FromQuery]string name)
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
        [HttpPost]
        public IActionResult Post([FromBody]SuperHero hero)
        {
            try
            {
                repo.AddSuperHero(hero);
                return NoContent();// 204 status
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Put([FromBody]SuperHero superHero)
        {
            try
            {
                return Ok(repo.UpdateSuperHero(superHero));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
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
