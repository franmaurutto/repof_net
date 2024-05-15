namespace Geometria
{
    public class Circulo
    {
        private double m_radio;

        public double Radio
        {
            get { return m_radio; }
            set
            {
                m_radio = value;
            }
        }
        public Circulo(double radio)
        {
            Radio = radio; 
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public double CalcularSuperficie()
        {
            return Math.PI * Radio * Radio;
        }
    }
}

