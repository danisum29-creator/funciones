namespace fun21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;
            Console.WriteLine("ingrese un texto");
            texto = Console.ReadLine();
            Console.WriteLine("la cantidad de vocales es: "+ContarLetras(texto));
        }
        static int ContarLetras(string texto)
        {
            int contvocal = 0;
            texto.ToLower();

            foreach (char letra in texto)
            {
                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')

                { contvocal++; }
            }
            return contvocal;
        }
    }
}
