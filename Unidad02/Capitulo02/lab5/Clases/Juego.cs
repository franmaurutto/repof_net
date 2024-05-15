namespace Clases
{
    public class Juego
    {
        private int _record = int.MaxValue;

        public void ComenzarJuego()
        {
            int maxNumero = PreguntarMaximo();
            Jugada jugada = new Jugada(maxNumero);

            while (!jugada.Adivino)
            {
                int numero = PreguntarNumero();
                jugada.Comparar(numero);
            }

            CompararRecord(jugada.Intentos);
            Continuar();
        }

        private int PreguntarMaximo()
        {
            Console.WriteLine("Ingrese el número máximo para adivinar:");
            int maxNumero = int.Parse(Console.ReadLine());
            return maxNumero;
        }

        private int PreguntarNumero()
        {
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }

        private void CompararRecord(int intentos)
        {
            if (intentos < _record)
            {
                _record = intentos;
                Console.WriteLine("¡Nuevo récord!");
            }
        }

        private void Continuar()
        {
            Console.WriteLine("¿Desea jugar otra partida? (s/n)");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "s")
            {
                ComenzarJuego();
            }
        }
    }
}
