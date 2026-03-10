namespace fun13
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
            Sumar(a, b);
            Console.WriteLine("la suma es: " + Sumar(a, b));
        }
        static int Sumar(int a, int b)
        {
            int suma = a + b;
            return suma;
        }
    }
}
