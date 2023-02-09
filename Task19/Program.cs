// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


System.Console.WriteLine("Введите пятизначное число: ");
string? num = Console.ReadLine();
int size = num!.Length;

if (size > 5 || size < 5)
{
    System.Console.WriteLine("Число не пятизначное");
}
else
{
    for (int i = 0; i < num.Length; i++)
{
    if (num[0] == num[4] || num[1] == num[3])
    {
        System.Console.WriteLine("Число - палиндром");
    }
    else 
    {
        System.Console.WriteLine("Число не является палиндромом");
    }
}
}
