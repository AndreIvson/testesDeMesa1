class Program
{
    static void Main()
    {
        int a = 7;
        int b = a - 6;
        int[] v = new int[6];

        while (b < a)
        {
            v[b] = b + a;
            b = b + 2;
            Console.WriteLine($"b: {b}, a: {a}, b+2:{b+2}");
        }
    }
};
//1.3