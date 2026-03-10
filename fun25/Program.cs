namespace fun25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("ingrese un numero ");
            n = int.Parse(Console.ReadLine());

            if(EsPrimo(n)==true)
            {
                Console.WriteLine("el numero: " + n + " es primo "); 
            }
            else
            {
                Console.WriteLine("el numero: " + n + " no es primo ");
            }
        }
        static bool EsPrimo(int n)
        {
            bool primo = false;
            for (int i = 2; i < n; i++) { 
            if(i == 0)
                    primo = true;
                break;
            }
            return primo;
        }
    }
}
