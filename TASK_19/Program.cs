/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Является число палиндромом?");
Console.Write("Введите пятизначное число ");
string NumberN = Console.ReadLine();
Console.WriteLine(CheckPalindrome(NumberN));

string CheckPalindrome(string str)
{
    int len = str.Length;
    if (len == 5)
    {
        if(str[0] == str[4] && str[1] == str[3])
        return("Это палиндром");
        else 
        return("Это не палиндром");
    }
    return("Введенное число не пятизначное");
}