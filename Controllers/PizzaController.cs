using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheFirstPizza.Services.Interfaces;
using TheFirstPizza.Entities;
namespace TheFirstPizza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        //PizzaService seria sin la interfaz
        private readonly IPizzaService _pizzaService;     //Inyeccion de dependencia. Le pasa a pizza service todos los metodos de la interfaz
        public PizzaController(IPizzaService pizzaService)  //Se declara un obj de tipo interfaz y usas todos sus metodos
        {
            _pizzaService = pizzaService;
        }

        //EndPoints

        [HttpGet]
        public IActionResult AllPizzas() 
        {
            return Ok(_pizzaService.AllPizzas());  //El ok 
        }
        [HttpGet("{id}")]
        public IActionResult OnePizza(int id) 
        {
            Pizza? pizza= _pizzaService.OnePizza(id);
            if (pizza  == null)
            {
                return BadRequest("No se encontro la pizza");
            }
            else
            { 
                return Ok(pizza);
    
            }
            //return Ok(_pizzaService.OnePizza(id));
        }
    }
}
