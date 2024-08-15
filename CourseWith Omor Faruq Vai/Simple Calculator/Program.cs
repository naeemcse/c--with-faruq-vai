namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, ans = 0 ;
            Console.WriteLine("Please Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Please Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            char op = Convert.ToChar(Console.ReadLine());
          
            switch (op)
            {
                case '+':
                    ans = a + b;
                    break;
                case '-':
                    ans = a - b;
                    break;
                    case '*':
                    ans = a * b;
                    break;
                    case '/':
                    ans = a / b;
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    break;

            }
            Console.WriteLine("Answer is :"+ ans);  

        }
    }
}
