internal class Program
{
    private static void Main(string[] args)
    {
        int Square(int x) => x * x;

        int Factorial(int x)
        {
            if (x < 0)
                return -1;
            if (x <= 1)
                return 1;
            return x * Factorial(x - 1);
        }

        int Module(int x)
        {
            if (x > 0)
                return x;
            return -x;
        }

        Math element = Square;
        Console.WriteLine(element(5));
        element += Factorial;
        Console.WriteLine(element(5));
        element += Module;
        Console.WriteLine(element(-5));

        Math[] operations = {Square, Factorial, Module};

        Console.WriteLine("Вывод массива делегат:");

        foreach (Math operation in operations)
        {
            Console.WriteLine(operation(5));
        }

        void Method(Math item, int number)
        {
            item = operations[number];
            Console.WriteLine(item(5));
        }

        Console.WriteLine("Вызов массива делегат черрез метод:");

        for (int number = 0; number < operations.Length; number++)
        {
            Method(element, number);
        }
    }
}

public delegate int Math(int x); 
