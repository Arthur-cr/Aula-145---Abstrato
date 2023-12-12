using Principal.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using Principal.Entities;
using Principal.Entities.Enums;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
             int n = int.Parse(Console.ReadLine());

            List<Shape> listShape = new List<Shape>();
              for (int i = 1; i <= n; i++)
              {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                 char rc = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                 Color color = Enum.Parse<Color>(Console.ReadLine());

                if (rc == 'r')
                {
                    Console.Write("Width: ");
                     double wid = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                     double hei = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listShape.Add(new Rectangle(wid, hei, color));
                }
                else
                {
                    Console.Write("Radius: ");
                     double rad = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listShape.Add(new Circle(rad, color));
                }

                Console.WriteLine();
                Console.WriteLine("SHAPE AREAS:");                
              }

            foreach (Shape shape in listShape)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
