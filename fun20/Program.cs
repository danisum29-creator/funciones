namespace fun20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;
            Console.WriteLine("ingrese una cadena de texto");
            texto = Console.ReadLine();
            ContarLetras(texto);
            Console.WriteLine("la cantidad de caracteres es: " + ContarLetras(texto));
        }
        static int ContarLetras(string texto)
        {
            int cont = 1;
            cont = texto.Length;
            return cont;

        }
    }
}
