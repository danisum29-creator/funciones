namespace fun12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("ingrese el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            b = int.Parse(Console.ReadLine());
            Restar(a, b);
            Console.WriteLine("la resta es: " + Restar(a, b));
        }
        static int Restar(int a, int b)
        {
            int resta = a - b;
            return resta;
        }
    }
}
