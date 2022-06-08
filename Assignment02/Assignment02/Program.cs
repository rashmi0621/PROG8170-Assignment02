using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Program
    {
        public static void Main()
        {
            int length = 0, width = 0;
            Rectangle r;
            // string customRectangle;


            Console.Write("\n\n");
            Console.Write("Please enter the length and width of the rectangle \n");
            Console.Write("--------------------------------------------------------\n");
            Console.Write("This program only takes in positive integers greater than 0");
            Console.Write("\n\n");

            Console.WriteLine("Please Enter the length of the rectangle : ");
            while (!int.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Please Enter a valid integer value!");

            }

            Console.WriteLine("Please Enter the width of the rectangle: ");
            while (!int.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Please Enter a valid integer value!");

            }
            r = new Rectangle(length, width);
            Console.WriteLine("1.Get Rectangle Length  \n");
            Console.WriteLine("2.Change Rectangle Length \n");
            Console.WriteLine("3.Get Rectangle Width \n");
            Console.WriteLine("4.Change Rectangle Width \n");
            Console.WriteLine("5.Get Rectangle Perimeter \n");
            Console.WriteLine("6.Get Rectangle Area \n");
            Console.WriteLine("7.Exit \n");

            Console.WriteLine("Please choose from the options 1 to 7 : ");

            int val = Convert.ToInt32(Console.ReadLine());
            while (val != 7)
            {
                Console.WriteLine("1.Get Rectangle Length  \n");
                Console.WriteLine("2.Change Rectangle Length \n");
                Console.WriteLine("3.Get Rectangle Width \n");
                Console.WriteLine("4.Change Rectangle Width \n");
                Console.WriteLine("5.Get Rectangle Perimeter \n");
                Console.WriteLine("6.Get Rectangle Area \n");
                Console.WriteLine("7.Exit \n");
                Console.WriteLine("Please choose from the options 1 to 7 : ");
                val = Convert.ToInt32(Console.ReadLine());
                if (val == 1)
                {
                    Console.WriteLine("Length of the Rectangle =  " + r.GetLength());

                }
                else if (val == 2)
                {
                    Console.WriteLine("Please Enter the new length of the rectangle : ");
                    while (!int.TryParse(Console.ReadLine(), out length))
                    {
                        Console.WriteLine("Please Enter a valid integer value!");
                    }
                    r.SetLength(length);
                    Console.WriteLine("New Length of Rectangle =  " + length);

                }
                else if (val == 3)
                {
                    Console.WriteLine("Width of the Rectangle =  " + r.GetWidth());

                }
                else if (val == 4)
                {
                    Console.WriteLine("Please Enter the new width of the rectangle : ");
                    while (!int.TryParse(Console.ReadLine(), out width))
                    {
                        Console.WriteLine("Please Enter a valid integer value!");
                    }
                    r.SetLength(width);
                    Console.WriteLine("New Length of Rectangle =  " + width);

                }
                else if (val == 5)
                {
                    Console.WriteLine("Perimeter of the Rectangle =  " + r.GetPerimeter());

                }
                else if (val == 6)
                {
                    Console.WriteLine("Area of the Rectangle =  " + r.GetArea());

                }
                else
                {
                    break;
                }

            }
        }
    }
}
