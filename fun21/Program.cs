namespace fun21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;
            Console.WriteLine("ingrese un texto");
            texto = Console.ReadLine();
        }
        static int ContarLetras(string texto)
        {
            int contvocal = 0;
            texto.ToLower();

            foreach (char letra in texto)
            {
                contvocal++;
            }
        }
    }
}
