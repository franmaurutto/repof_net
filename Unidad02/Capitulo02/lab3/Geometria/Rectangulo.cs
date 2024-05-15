using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        private double baseRectangulo;
        private double alturaRectangulo;
        public Rectangulo(double baseRectangulo, double alturaRectangulo)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
        }
        public override double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + alturaRectangulo);
        }
        public override double CalcularSuperficie()
        {
            return baseRectangulo * alturaRectangulo;
        }
    }

}