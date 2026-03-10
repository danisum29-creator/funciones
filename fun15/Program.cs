namespace fun15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ingrese un numero");
            num = int.Parse(Console.ReadLine());
            EsPar(num);
            if (EsPar(num) == true)
            {
                Console.WriteLine("el numero es par");

            }
            else
            {
                Console.WriteLine("el numero es impar ");
            }
        }
        static bool EsPar(int num)
        {
        bool par = false;
            if ( num%2==0)
            {
                par = true;
            }
            else
            {
                par = false;
            }
            return par;
        }
    }
}
