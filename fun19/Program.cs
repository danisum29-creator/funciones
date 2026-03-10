namespace fun19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("ingrese un numero"); 
n= int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero");
            m= int.Parse(Console.ReadLine());

            if(EsMultiplo(n, m)==true)
            {
                Console.WriteLine("los numeros son multiplos ");
            }
            else
            {
                Console.WriteLine("los numeros no son multiplos");
            }
        }

        static bool EsMultiplo(int n, int m)
        {
            bool multiplo = false;
            if (n % m == 0||m%n==0)
            {
                multiplo = true;
            }
            return multiplo;
        }
    }
}
