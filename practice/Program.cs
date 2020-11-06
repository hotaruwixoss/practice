using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {


            static double cargar()
            {
                double[] salarios = new double[5];

                Console.WriteLine("Ingrese el salario 1:");
                salarios[0] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el salario 2:");
                salarios[1] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el salario 3:");
                salarios[2] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el salario 4:");
                salarios[3] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el salario 5:");
                salarios[4] = Convert.ToDouble(Console.ReadLine());

                return (cargar());

            }

            static double mostrar()
            {
                Console.WriteLine("Salario 1 = {0}", cargar());
                Console.WriteLine("Salario 2 = {1}", cargar());
                Console.WriteLine("Salario 3 = {2}", cargar());
                Console.WriteLine("Salario 4 = {3}", cargar());
                Console.WriteLine("Salario 5 = {4}", cargar());
                return (mostrar());
            }

            Console.ReadKey();

            Console.WriteLine(cargar());
            Console.WriteLine(mostrar());




        }
    }

    


}
