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

            while (true) { 
            Console.WriteLine("Please, input you full name (Eng) :");
            name = Console.ReadLine();
                if (name == "") ;
                else break;
            };


            while (true) {
                Console.WriteLine("Plaese fill in your height(cm) : ");
                height = Convert.ToInt16(Console.ReadLine());
                if (height > 100); break; };
            

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
            Console.ReadKey();
        }
    }
}
