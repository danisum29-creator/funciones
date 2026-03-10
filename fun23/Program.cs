namespace fun23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("ingrese un numero"); 
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("la suma de 1 hasta " + n + " es: " + Sumardel1alN(n));


        }

        static int Sumardel1alN(int n)
        {
            int suma = 0;

            for (int i = 1; i <= n; i++)
            {
                suma = suma + i; 
            }
            return suma;

        }
    }
}
