namespace fun18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c; 

            Console.WriteLine("ingrese 3 numeros");
           MenorDeTres(a, b, c);

          

        }
        static int MenorDeTres(int a, int b, int c)
        {
            int menor = 0; 
            if (a == b && a == c)
            {
                Console.WriteLine("los numeros son iguales");
            }

            else if(a<b && a<c)
            {
                menor = a; 
            }
            else if (b<c&& b<a)

            {
                menor = b; 
            }
            else if(c<a && c<b)
            {
                menor = c;
            }


        }
    }
}
