using TheFirstPizza.Entities;
using TheFirstPizza.Services.Interfaces;

namespace TheFirstPizza.Services.Implementations
{
    public class PizzaService : IPizzaService  //Implementacion de la interfaz
    {
        static List<Pizza> Pizzas { get; set; } //Una propiedad estatica que genera una lista de objetos de tipo pizza
        static PizzaService()
        {
            Pizzas = new List<Pizza>
            {
              new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
              new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true }
            };
        }
        public List<Pizza> AllPizzas()
        { 
          return Pizzas;
        }

        public  Pizza? OnePizza(int id)  //Funciones de tipo linq
        {
            return Pizzas.FirstOrDefault(pizza => pizza.Id == id);   //Si no lo encuentra te devuelve un null

        }
    }
    //Logica de negocio
}
