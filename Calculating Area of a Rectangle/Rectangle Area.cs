using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's calculate the area of a rectangle!");
            Console.Write("Enter a number to determine the length: ");
            string length = Console.ReadLine();
            Console.Write("Enter a number to determine the width: ");
            string width = Console.ReadLine();

            int lengthnumber = int.Parse(length);
            int widthnumber = int.Parse(width);

            int area = lengthnumber * widthnumber;
            Console.WriteLine("The area of your rectangle is: " + area);
            Console.ReadLine();

        }
    }
}
