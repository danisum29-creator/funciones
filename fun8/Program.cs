namespace fun8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("ingrese el primer numero"); 
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero"); 
            b = int.Parse(Console.ReadLine());
            int total = SumarMostrar(a, b);
            Console.WriteLine("la suma es: " + total);
            
        }

        static int SumarMostrar(int a, int b)
        {
            int suma = 0; 
            suma = a+ b;
            return suma;
        }
    }
}
