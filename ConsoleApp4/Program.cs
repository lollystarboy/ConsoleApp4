
using System.Drawing;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("мишкинс", 22);
            Console.WriteLine("имя {0}", name);
            Console.WriteLine("", age);

            var favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            { favcolors[i] = ShowColor(name); }

            Console.WriteLine("{0} ваши любимые цвета", name);
            foreach (var color in favcolors)
            { Console.WriteLine(color); }
            ShowColor(name);
        }

        private static string ShowColor(string name)
        {
            
                Console.WriteLine("напишите свой любимый цвет на англ с маленькой буквы");
                var color = Console.ReadLine();


                switch (color)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
                return color;
            
        }
    }
}
