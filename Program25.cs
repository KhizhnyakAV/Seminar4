// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B");

System.Console.WriteLine("Введите число А:");
string input = Console.ReadLine();
int A = int.Parse(input);

System.Console.WriteLine("Введите число В:");
input = Console.ReadLine();
int B = int.Parse(input);

int itog = 1;

for (int i = 0; i < B; i++)
{
    itog = itog * A;
}

System.Console.WriteLine($"A^B = {itog}");