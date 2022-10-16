// See https://aka.ms/new-console-template for more information
Console.WriteLine("Пользователь вводит 8 чисел. Поместите их в массив и распечатайте. Введите число и нажмите ВВОД:");

int[] array = new int[8];

for (int i=0; i<8; i++)
{
array[i] = int.Parse(Console.ReadLine());
}

System.Console.Write("Введен массив [");
for (int i=0; i<8; i++)
{
System.Console.Write(array[i]);  
System.Console.Write(" ");  
}
System.Console.Write("]");
