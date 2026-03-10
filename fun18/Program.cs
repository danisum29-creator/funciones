namespace fun18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[2];

            Console.WriteLine("ingrese 3 numeros");

            numeros.Reverse();
            int menor = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (menor < numeros[i])
                {
                    menor = numeros[i];
                }
            }

        }
    }
}
