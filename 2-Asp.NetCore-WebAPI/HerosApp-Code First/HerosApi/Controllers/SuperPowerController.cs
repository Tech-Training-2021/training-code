using HerosLogic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerosApi.Controllers
{
    [Route("api/SuperPower")]
    public class SuperPowerController : Controller
    {
        private readonly ISuperPowerRepo repo;
        public SuperPowerController(ISuperPowerRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            try
            {
                // retruning status code 200
                return Ok(repo.GetAllSuperPowers());
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [HttpGet("get/{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            try
            {
                // retruning status code 200
                return Ok(repo.GetSuperPowerById(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] SuperPower power)
        {
            try
            {
                repo.AddSuperPower(power);
                return NoContent();// 204 status
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                repo.RemoveSuperPower(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}