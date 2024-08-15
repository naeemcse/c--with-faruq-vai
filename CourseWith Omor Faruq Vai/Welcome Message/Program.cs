namespace Welcome_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please write you name: ");

            name = Console.ReadLine();

            Console.WriteLine($" Wellcome  {name} to our C# Course"); 
        }
    }
}
