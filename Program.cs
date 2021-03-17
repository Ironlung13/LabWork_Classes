using System;

namespace LabWork_Classes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Create 2 hexagons.");
            Console.Write("Enter first hexagon side value\n=> ");
            double size;
            Hexagon hex1, hex2;
            while (!double.TryParse(Console.ReadLine(), out size))
            {
                Console.Write("Invalid Input. Try again\n=> ");
            }

            try
            {
                hex1 = new Hexagon(size);
                Console.WriteLine($"Can hex1 exist? => {Hexagon.CanExist(hex1)}");
                Console.WriteLine($"hex1 Perimeter using method => {hex1.GetPerimeter():F2}");
                Console.WriteLine($"hex1 Area using property => {hex1.Area:F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Hex1 can't exist with given parameters. Exception message:");
                Console.WriteLine(ex.Message);
            }


            Console.Write("Enter second hexagon side value\n=> ");
            while (!double.TryParse(Console.ReadLine(), out size))
            {
                Console.Write("Invalid Input. Try again\n=> ");
            }

            try
            {
                hex2 = new Hexagon(size);
                Console.WriteLine($"Can hex2 exist? => {Hexagon.CanExist(hex2)}");
                Console.WriteLine($"hex2 Perimeter using method => {hex2.GetPerimeter():F2}");
                Console.WriteLine($"hex2 Area using property => {hex2.Area:F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Hex2 can't exist with given parameters. Exception message:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("To quit program, enter \"q\".");
            Console.WriteLine("To restart, enter anything else.");
            switch (Console.ReadLine())
            {
                case "q":
                case "Q":
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Main();
                    return;
            }
        }
    }
}
