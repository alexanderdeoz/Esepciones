using System;

namespace esepciones.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio, total;
            int cantidad;
           
            // try catch

            try
            {
                Console.WriteLine("Consulta de esepciones ");
                Console.WriteLine("Ejemplo simple de try catch");
                Console.WriteLine("Cantidad : ");
                cantidad = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Precio : ");
                precio = Convert.ToDouble(Console.ReadLine());
                total = cantidad * precio;
                Console.WriteLine("el total es  : " + total);
            } catch (Exception error)
            {
                Console.WriteLine("ha ocurrido un error "+error.Message);
            
            }
            Console.ReadKey();

        }
    }
}
