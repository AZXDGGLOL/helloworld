using Microsoft.VisualBasic;

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
            Console.WriteLine("Please, input you full name (Eng) :");
            name = Console.ReadLine();

            Console.WriteLine("Hello, Welcome "+name);
            Console.WriteLine("Pleese tell us your gender f/m");
            gender = Console.ReadLine();


            Console.WriteLine("Plaese fill in your height(cm) : ");
            height = Convert.ToInt16(Console.ReadLine());
            if (gender == "f")
            {
                 weight = height -= 110;
            }
            else
            {
                 weight = height -= 100;
            }

            Console.WriteLine("Your ideal weight is : " + weight.ToString());

            Console.WriteLine();
            Console.WriteLine("press any key to end program");
            Console.ReadKey();
        }
    }
}
