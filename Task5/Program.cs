Console.WriteLine("Введіть перше число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть друге число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть третє число: ");
int number3 = int.Parse(Console.ReadLine());

int max = FindMax(number1, number2, number3);
Console.WriteLine($"Найбільше число: {max}");

static int FindMax(int a, int b, int c)
{
    int max = a;
    if (b > max)
    {
        max = b;
    }
    if (c > max)
    {
        max = c;
    }
    return max;
}