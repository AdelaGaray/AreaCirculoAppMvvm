namespace AreaCirculoAppMvvm.Models
{
    public class Circulo
    {
        public const double PI = 3.1415926535897931;
        public double Radio { get; set; }

        public double CalcularArea()
        {
            return PI * Radio * Radio;
        }
    }
}
