using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Eres elegible para votar.");
        }
        else
        {
            Console.WriteLine("No puedes votar, necesitas ser mayor de 18 años.");
        }
    }
}
