namespace fun14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("ingrese el primer numero"); 
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            b = double.Parse(Console.ReadLine());
            Dividir(a, b);
            Console.WriteLine("el resultado de la division es: "+Dividir(a,b));
        }
        static double Dividir(double a, double b)
        {
            double cociente=0; 
            if (b==0)
            {
                Console.WriteLine("resultado indefinido ");

            }
            else
            {
                cociente = a/b;
            }
            return cociente;
        }
    }
}
