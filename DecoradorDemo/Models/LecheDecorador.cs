namespace DecoradorDemo.Models
{
    public class LecheDecorador : IngredienteDecorador
    {
        public LecheDecorador(ICafe cafe) : base(cafe)
        {
            _nombre = "Leche";
            _precio = 0.25;
        }
    }
}