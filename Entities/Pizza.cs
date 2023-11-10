namespace TheFirstPizza.Entities
{
    public class Pizza
    {
         public int Id { get; set; }
        public string? Name { get; set; } //Signo de pregunta para qu acepte un vacio
        public bool IsGlutenFree { get; set; }
    }
    //Objeto
}
