Console.WriteLine("Введіть число: ");
int numb = int.Parse(Console.ReadLine());
if (numb % 3 == 0)
{
    Console.WriteLine("Ділиться на 3");
}
if (numb % 3 != 0)
{
    Console.WriteLine("Не ділиться на 3");
}
if (numb % 2 == 0)
{
    Console.WriteLine("Парне");
}
if (numb % 2 != 0)
{
    Console.WriteLine("Непарне");
}
