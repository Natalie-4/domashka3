/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

for (int a = 1; a <= N; a++)
{
    int b = a*a*a;
    if (a < N)
    Console.Write(b + "  ");

    else
    Console.Write(b);

}