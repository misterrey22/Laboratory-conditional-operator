Console.WriteLine("Введіть рік: ");
int year = int.Parse(Console.ReadLine());
if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
{
    Console.WriteLine("Високосний рік");
}
else
{
    Console.WriteLine("Невисокосний рік");
}