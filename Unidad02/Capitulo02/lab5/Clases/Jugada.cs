using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Jugada
    {
        private bool _adivino;
        private int _intentos;
        private int _numero;

        public bool Adivino { get { return _adivino; } }
        public int Intentos { get { return _intentos; } }
        public int Numero { get { return _numero; } }

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            _numero = rnd.Next(maxNumero);
        }

        public void Comparar(int numero)
        {
            _intentos++;
            if (numero == _numero)
            {
                Console.WriteLine($"¡Adivinaste en {_intentos} intentos!");
                _adivino = true;
            }
            else
            {
                Console.WriteLine("Intenta nuevamente.");
            }
        }
    }
}