namespace Thermometer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double c;
            c=Convert.ToDouble(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine(f);
        }
    }
}
