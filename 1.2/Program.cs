﻿class Program
{
    static void Main()
    {
        int[] v = new int[7];
        int a = 2;

        while (a < 6)
        {
            v[a] = 10 * a;
            a += 1;
        };
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"Posição: {i} o resultado é {v[i]}");
        }
    }
}

//1.2