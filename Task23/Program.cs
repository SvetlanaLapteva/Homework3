// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine ("ВВедите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i <= n; i++)
{
    for(int j = 0; j <=n; j++)
    {
        Console.Write(Math.Pow(i * 10 + j, 3));
        Console.Write(" ");
    }
    Console.WriteLine();
} 
