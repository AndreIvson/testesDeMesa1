class Program
{
    static void Main()
    {
        int[] v = new int[4];
        int a = 10;
        int b = 20;
        int c = (a + b) / 2;
        c = c - 40;
        v[3] = a + b + c;

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
            Console.WriteLine($"v[{i}]: {v[i]}");
        }

        Console.ReadLine();
    }
}

// 1.1