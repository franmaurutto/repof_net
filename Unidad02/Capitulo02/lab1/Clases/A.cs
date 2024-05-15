namespace Clases
{
    public class A
    {
        string NombreInstancia;
        public void asignodefault()
        {
            this.NombreInstancia = "Instancia sin nombre";
        }
        public void asigno(string nom)
        {
            this.NombreInstancia = nom;
        }
        public string MostrarNombre()
        {
            return this.NombreInstancia;
        }
        public void M1()
        {
            Console.WriteLine("El método M1 fue invocado.");
        }
        public void M2()
        {
            Console.WriteLine("El método M2 fue invocado.");
        }
        public void M3()
        {
            Console.WriteLine("El método M3 fue invocado.");
        }
    }
}
