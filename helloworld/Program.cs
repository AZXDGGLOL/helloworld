using Microsoft.VisualBasic;
using System.ComponentModel.Design;

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int height = 0;
            int weight = 1;
            String gender = "";
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            while (true) { 
            Console.WriteLine("Please, input you full name (Eng) :");
            name = Console.ReadLine();
                if (name == "")
                Console.WriteLine("Please enter something"); 
                else break;
            };


            while (true)
            {
                Console.Write("Please fill in your height (cm): ");
                string input = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Empty input.");
                    continue;
                }
                if (!int.TryParse(input, out height))
                {
                    Console.WriteLine("Invalid number.");
                    continue;
                }
                if (height <= 100)
                {
                    Console.WriteLine("Height must be greater than 100 cm.");
                    continue;
                }
                break;
            }


            while (true)
            {
                if (gender == "f")
                {
                    weight = height -= 110; break;
                }
                else if (gender == "m")
                {
                    weight = height -= 100; break;
                }
                else Console.WriteLine("Pleese tell us your gender f/m");
                gender = Console.ReadLine();
            };

            Console.WriteLine("Hello, Welcome " + name);
            Console.WriteLine("Your ideal weight is : " + weight.ToString());

            Console.WriteLine();
            Console.WriteLine("press any key to end program");
            
        }
    }
}
