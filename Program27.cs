// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе");

System.Console.Write("Введите число:");
string input = Console.ReadLine();
int stop = input.Length;
int digit = int.Parse(input);
int result = 0;

for (int i = 1; i <= stop; i++)
{
    result = result + (digit%10);
    digit = digit / 10;
}


System.Console.WriteLine($"Сумма цифр числа = {result}");