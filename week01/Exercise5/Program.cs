using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al programa!");

        Console.Write("Por favor, escribe tu nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Escribe tu número favorito: ");
        int numero = int.Parse(Console.ReadLine());

        int cuadrado = numero * numero;

        Console.WriteLine($"{nombre}, el cuadrado de tu número es {cuadrado}");
    }
}
