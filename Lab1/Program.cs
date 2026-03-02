using System.Diagnostics;
using System.Dynamic;

namespace Lab1
{
    public class Logic
    {

        public static string Compare(int numb)
        {
            string outMessage = "";
            int s = 0;
            int f = 0;
            if ((1 <= numb) & (numb <= 9999))
            {
                s = numb / 100;
                f = numb % 100;
                outMessage = $"{s} rubles {f} kopecks";
            }
            else
            {
                outMessage = "Error";
            }
            return outMessage;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numb = int.Parse(name);
            var outMessage = Logic.Compare(numb);
            Console.WriteLine(outMessage);
        }
    }
}