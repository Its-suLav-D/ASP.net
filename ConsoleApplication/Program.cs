using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine($"The length of the wood is {woodLength} feet");
            Console.WriteLine($"The glass area of the wood is {glassArea} square meters");
        }
    }
}
