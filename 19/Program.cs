// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет ; 12821 -> да;  23432 -> да

Console.Clear();
Console.Write ("Введите пятизначное число: ");
int number = int.Parse (Console.ReadLine());
int a = number /10000;
int b = number %10;

if( a == b ){
    Console.WriteLine ("Является палиндромом");
}
else
{
    Console.WriteLine ($"Не является палиндромом");
}

    







