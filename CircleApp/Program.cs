using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle = new Circle();

            Console.Write("Enter Your Redious : ");
            aCircle.radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Diameter is: "+ aCircle.GetDiameter());
            Console.WriteLine("Perimeter is: "+aCircle.GetPerimeter());
            Console.WriteLine("Area is: "+ aCircle.GetArea());
            Console.ReadKey();

        }
    }
}
