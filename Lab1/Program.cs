using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numb = int.Parse(name);
            string outMessage = "";

            if ((1 <= numb) & (numb <= 9999))
            {
                int s = numb / 100;
                int f = numb % 100;
                outMessage = $"{s} rubles {f} kopecks";
            }
            else
            {
                outMessage = "Error";
            }

            Console.WriteLine(outMessage);
        }
    }
}