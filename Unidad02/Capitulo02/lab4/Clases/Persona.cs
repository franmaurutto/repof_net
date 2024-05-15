namespace Clases
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string dni;
        public Persona(string nombre, string apellido, int edad, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
            Console.WriteLine("Se ha creado una nueva instancia de Persona.");
        }
        ~Persona()
        {
            Console.WriteLine("Se ha destruido la instancia de Persona.");
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        public string GetFullName()
        {
            return nombre + " " + apellido;
        }
        public int GetAge()
        {
            return edad;
        }
    }

