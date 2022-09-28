/*Напишите программу,
которая принимает на вход два числа
и проверяет, является ли одно число квадратом другого.
5, 25  → да
-4, 16  →  да
25, 5  →  да
8, 9  →  нет*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите первое число");
        int first = int.Parse(Console.ReadLine()!);

        Console.WriteLine("введите второе число");
        int second = int.Parse(Console.ReadLine()!);

        int square1 = first * first;
        int square2 = second * second;
        
        if (square1 == second)
            Console.WriteLine
            ($"второе число является квадратом певого и = {second}");
        {
            if (square1 != second)
                Console.WriteLine
                ("второе число не квадрат певого числа ");
                
        }
        
        {
            if (square2 == first)
                Console.WriteLine
                ($"первое число является квадратом второго и = {first}");
        }
        {
            if (square2 != first)
                Console.WriteLine("первое число не квадрат второго числа");
        }
        
    }
}