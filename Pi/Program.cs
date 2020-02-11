using System;

namespace Pi
{
    class Program
    {
        static void Pi(long n)
        {
            Random rnd = new Random();
            double circle = 0;
            double total = 0;
            double x = 0;
            double y = 0;
            double dist = 0;

            for (int i = 0; i < n; i++)
            {
                x = rnd.NextDouble();
                y = rnd.NextDouble();
                dist = x*x + y*y;

                if (dist<=1)
                {
                    circle += 1;
                }
                total +=1;
               
           
            }
            double pi = (4 * circle / total);
            Console.WriteLine(pi);
        }




        static void Main(string[] args)
        {
            Pi(10000000); //The higher the number, the more exact PI you will get.
            Console.ReadLine();
        }
    }
}
