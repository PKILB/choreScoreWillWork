using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace choreScoreWillWork.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BurgersController : ControllerBase
    {
        private readonly BurgersService _burgersService;

        public BurgersController(BurgersService burgersService)
        {
            _burgersService = burgersService;
        }

        [HttpGet]
        public ActionResult<List<Burger>> GetAll()
        {
            try
            {
                return Ok(_burgersService.GetAllBurgers());
            }   
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Burger> GetOneBurger(int id)
        {
            try
            {
                Burger burger = _burgersService.GetOneBurger(id);
                return Ok(burger);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Burger> CreateBurger([FromBody] Burger burgerData)
        {
            try
            {
                Burger burger = _burgersService.CreateBurger(burgerData);
                return Ok(burger);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{burgerId}")]
        public ActionResult<string> RemoveBurger(int burgerId)
        {
            try
            {
                string message = _burgersService.RemoveBurger(burgerId);
                return Ok(message);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        }
    }
