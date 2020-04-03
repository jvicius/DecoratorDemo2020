namespace DecoradorDemo.Models
{
    public class ChocolateDecorador : IngredienteDecorador
    {
        public ChocolateDecorador(ICafe cafe) : base(cafe)
        {
            _nombre = "Chocolate";
            _precio = 0.30;
        }
    }
}
