/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
14212 -> нет, 12821 -> да, 23432 -> да*/
Console.WriteLine("Введите пятизначное число");
int chislo = Convert.ToInt32(Console.ReadLine());

while (chislo >= 100000 || chislo < 10000)
{
    Console.Write("Оно должно быть пятизначным! Введите заново: ");
}

int A = chislo / 10000; 
int B = chislo % 10;
int C = (chislo / 1000) % 10;
int D = (chislo / 10) % 10;
if (A == B && C == D)
Console.WriteLine("это палиндром");
else
Console.WriteLine("это не палиндром");