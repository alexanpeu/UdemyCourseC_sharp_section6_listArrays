using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace Secao6_vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //create a vector example
            int number = int.Parse(Console.ReadLine());
            double[] vector = new double[number];
            for(int i = 0; i < number; i++)
            {
                vector[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for(int i = 0; i < number; i++)
            {
                sum += vector[i];
            }
            sum /= number; 
            Console.WriteLine("Average Height = " + sum.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            //exercise use vector with a class
            int number = int.Parse(Console.ReadLine());
            Product[] vector = new Product[number];

            for(int i =0; i < number; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vector[i] = new Product { Name = name, Price = price };
            }
            double avg = 0.0;
            for(int i = 0; i < number; i++)
            {
                avg += vector[i].Price;
            }
            avg /= number;
            Console.WriteLine("Average price: $ " + avg.ToString("F2",CultureInfo.InvariantCulture));
            */

            /*
            //exercise vectors - students rooms
            Console.Write("How many rooms will be rented? ");
            int numberRooms = int.Parse(Console.ReadLine());
            ExerciseVectorsStudents[] vector = new ExerciseVectorsStudents[10];

            for (int i = 0; i< numberRooms; i++)
            {
                Console.WriteLine("Rent #{0}", i+1);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vector[room] = new ExerciseVectorsStudents(name, email);


            }
            Console.WriteLine("Busy rooms: ");
            for(int i = 0; i<10; i++)
            {
                if (vector[i] != null)
                    Console.WriteLine(i + ": " + vector[i]);
            }
            */

            /*
            //creating a class using vectors and parameters
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(4, 5, 6);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            */

            //using a function ref
            int a = 10;
            Calculator.TripleRef(ref a);
            Console.WriteLine(a);

            //using a function out
            int b = 5;
            int triple ;
            Calculator.TripleOut(b,out triple);
            Console.WriteLine(triple);
        }
    }
}
