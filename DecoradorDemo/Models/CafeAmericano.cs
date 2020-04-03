namespace DecoradorDemo.Models
{
    public class CafeAmericano : ICafe
    {
        public double ObtenerCosto()
        {
            return 4.00;
        }

        public string ObtenerDescripcion()
        {
            return "Cafe Americano";
        }
    }
}