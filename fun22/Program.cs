namespace fun22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;
            int veces;
            Console.WriteLine("ingrese un texto"); 
            texto= Console.ReadLine();
            Console.WriteLine("cuantas veces desea repetirlo");
            veces = int.Parse(Console.ReadLine());
            Console.WriteLine(Repetir(texto, veces));
        }

        static string Repetir(string texto, int veces)
        {
            
            for (int i = 1; i < veces; i++)
            
                Console.WriteLine(texto); 
            return texto;

        }
    }
}
