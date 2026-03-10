namespace fun16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("ingrese un numero ");
            n = int.Parse(Console.ReadLine());
            EsPositivo(n);
            if (EsPositivo(n) == true)
            {
                Console.WriteLine("el numero " +n + " es positivo");
            }
            else
            {
                Console.WriteLine("el numero " + n + " no es positivo");
            }
        }

        static bool EsPositivo(int n)
        {
            bool positivo = false;
            if (n >= 1)
            {
                positivo = true;
            }
            else
            {
                positivo= false;
            }
            return positivo;
        }
    }
}
