namespace EjerciciosTema8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            persona.Edad = 33;
            persona.Nombre = "Ricardo";
            persona.NumTelefono = "+330611883311";

            Console.WriteLine("Nombre: " + persona.Nombre + ", Edad: " + persona.Edad + ", Número de teléfono: " + persona.NumTelefono);
        }
    }

    public class Persona
    {
        private int edad;
        private string nombre;
        private string numTelefono;


        public string NumTelefono
        {
            get { return numTelefono; }
            set { numTelefono = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }


    }
}