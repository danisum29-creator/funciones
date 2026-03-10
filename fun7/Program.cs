namespace fun7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; 
            Console.WriteLine("ingrese un numero");
            n = int.Parse(Console.ReadLine());
           int resultado =  MostrarDoble(n);
            Console.WriteLine("el resultado es: " + resultado);
           
        }

        static int MostrarDoble(int n)
        {
            int doble = 2 * n;
            return doble;
        }
    }
}
