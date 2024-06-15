namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Summ(int x, int y)
            {
                Console.WriteLine($"Сумма: {x + y}");
            }

            static void Difference(int x, int y)
            {
                Console.WriteLine($"Разность: {x - y}");
            }

            static void Composition(int x, int y)
            {
                Console.WriteLine($"Произведение: {x * y}");
            }

            static void Division(int x, int y)
            {
                if (y != 0)
                    Console.WriteLine($"Частное: {x / y}");
                else
                Console.WriteLine("На ноль делить нельзя!");
            }

            Math operation = new Math(Summ);
            operation += Difference;
            operation += Composition;
            operation += Division;
            operation?.Invoke(54, 0);
        }
    }
}
public delegate void Math(int x, int y);
