using TheFirstPizza.Entities;
namespace TheFirstPizza.Services.Interfaces
{
    public interface IPizzaService
    {
        List<Pizza> AllPizzas(); // Esto es la firma
        Pizza OnePizza(int id);  //Firma
    }
    //Contrato
}
