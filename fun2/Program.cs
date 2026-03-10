using System;

class Program
{
    

    static void Main(string[] args)
    {
        

        MostrarNombre(" ");
        
    }

    static void MostrarNombre( string nombre)
    {
        
        Console.WriteLine("ingrese un nombre");
     nombre = Console.ReadLine();
        Console.WriteLine("el nombre ingresado es: " + nombre);

        
    }
}

