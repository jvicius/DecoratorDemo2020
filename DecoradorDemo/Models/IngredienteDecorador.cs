namespace DecoradorDemo.Models
{
    public abstract class IngredienteDecorador : ICafe
    {
        private ICafe _cafe;
        protected string _nombre = "Sin Definir";
        protected double _precio = 0.0;

        public IngredienteDecorador(ICafe cafe)
        {
            _cafe = cafe;
        }
        public double ObtenerCosto()
        {
            return _cafe.ObtenerCosto() + _precio;
        }

        public string ObtenerDescripcion()
        {
            return $"{_cafe.ObtenerDescripcion()}, {_nombre}";
        }
    }
}
