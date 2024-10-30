Console.Write("Введіть річний дохід: ");
double income = double.Parse(Console.ReadLine());
if (income <= 10000)
{
    Console.WriteLine($"Податок складає " + (income * 0.1));
}
else if (income > 10000 && income < 50000)
{
    Console.WriteLine($"Податок складає " + (income * 0.15));
}
else
{
    Console.WriteLine($"Податок складає " + (income * 0.20));
}