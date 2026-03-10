namespace fun9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num; 
            Console.WriteLine("ingrese un numero");
            num = int.Parse(Console.ReadLine());
            int total = MostrarCuadrado(num);
            Console.WriteLine("el cuadrado de " + num + " es: " + total);
        }
        static int MostrarCuadrado(int num)
        {
           
            int cuadrado = 0;
            cuadrado = num * num;
            return cuadrado;
        }
        
    }
}
