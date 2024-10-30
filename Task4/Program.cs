Console.WriteLine("Введіть символ: ");
char inputChar = Console.ReadKey().KeyChar;
if (inputChar == 'a' | inputChar == 'e' | inputChar == 'i' | inputChar == 'o' | inputChar == 'u')
{
    Console.WriteLine("\nГолосна");
}
else
{
    Console.WriteLine("\nПриголосна");
}