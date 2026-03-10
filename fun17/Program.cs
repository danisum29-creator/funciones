namespace fun17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo nuemro")
            Console.WriteLine();
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("el mayor es: "+Mayor(n1,n2));
        }

        static int Mayor(int n1, int n2)
        {
            int mayor = 0;
            if (n1 == n2)
            {
                Console.WriteLine("los numeros son iguales");
            }

            else if (n2 > n1)
            {
                mayor = n2;
            }
            else if (n1 > n2)
            {
                mayor= n1;
            }
            return mayor;
         }       
    }
}
