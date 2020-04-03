namespace DecoradorDemo.Models
{
    public class CafeExpreso : ICafe
    {
        public double ObtenerCosto()
        {
            return 3.0;
        }

        public string ObtenerDescripcion()
        {
            return "CafeExpreso";
        }
    }
}