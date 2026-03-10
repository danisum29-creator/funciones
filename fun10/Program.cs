namespace fun10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad; 
            string texto;
            Console.WriteLine("ingrese un texto"); 
            texto = Console.ReadLine();
            Console.WriteLine("ingrese la cantidad de veces para repetirlo");
            cantidad = int.Parse(Console.ReadLine());
            ImprimirRepetido(cantidad, texto);
        }

        static void ImprimirRepetido(int cantidad, string texto)
        {
            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine(texto);
            }


        }
    }
}
