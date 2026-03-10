namespace fun24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("ingrese un numero"); 
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("el factorial de: " + n + " es: " + Factorial(n));
        }

        static int Factorial(int n)
        {
            int factorial = 1; 
            for(int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;

        }
    }
}
