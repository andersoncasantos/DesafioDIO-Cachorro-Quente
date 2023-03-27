using System;
public class Program

{
    static void Main()

    {
        string[] entrada = Console.ReadLine().Split();
        int participantes = int.Parse(entrada[0]);
        double cachorrosQuentes = int.Parse(entrada[1]);
        Console.WriteLine($"{(participantes / cachorrosQuentes):F2}");
    }

}