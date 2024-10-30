using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть ціле число: ");
        int num = int.Parse(Console.ReadLine());
        if (num == 0)
        {
            Console.WriteLine("Дорівнює нулю");
        }
        else if (num > 0)
        {
            Console.WriteLine("Число додатнє");
        }
        else
        {
            Console.WriteLine("Число від'ємне");
        }
