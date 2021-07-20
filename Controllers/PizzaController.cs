using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ContosoP.Models;
using ContosoPizza.Services;

namespace ContosoPizza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {
        }

        // GET all action
        //pizza/
        [HttpGet]
        public ActionResult <List<Pizza>> GetAll() => PizzaService.GetAll();

        // pizza / {id}
        [HttpGet("{id}")]
        public ActionResult <Pizza> Get(int id)
        {
            var pizza = PizzaService.Get(id);

            if(pizza == null)
            {
                return NotFound();
            }

            return pizza;
        }

        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
    }
}