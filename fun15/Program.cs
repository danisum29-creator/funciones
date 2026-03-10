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


        }
        static int EsPar(int num)
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
