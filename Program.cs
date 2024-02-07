namespace FechaEjercicio7
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca su fecha de nacimiento:");
            string fecha1 = Console.ReadLine();
            Console.WriteLine("Introduzca dias para sumar:");
            int dias = Convert.ToInt32(Console.ReadLine());

            DateTime fechaNacimiento2 = DateTime.Parse(fecha1);

            Console.WriteLine(fechaNacimiento2.AddDays(dias));

            Console.WriteLine(fechaNacimiento2.AddDays(-dias));
        }

    }

}