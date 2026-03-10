namespace fun18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c; 

            Console.WriteLine("ingrese 3 numeros");
            a = int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            c= int.Parse(Console.ReadLine());
            MenorDeTres(a, b, c);


            Console.WriteLine("el menor es: " + MenorDeTres(a, b, c));
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
            else if(a==b&&a<c)
            {
                menor = a; 
            }
            else if(a==c&& a<b )
            {
                menor = a;
            }
            else if(b==c&&b<a)
            {
                menor = b;
            }
            return menor;
        }
    }
}
