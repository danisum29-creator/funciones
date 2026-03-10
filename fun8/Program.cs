namespace fun8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("ingrese un numero"); 
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero"); 
            b = int.Parse(Console.ReadLine());

            
        }

        static int SumarMostrar(int a, int b)
        {
            int suma = 0; 
            suma = a+ b;
            return suma;
        }
    }
}
