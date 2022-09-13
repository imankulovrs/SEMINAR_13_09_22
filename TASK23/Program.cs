/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Console.WriteLine("Таблица кубов от 1 до числа N");
Console.Write("Введите число N ");
int NumberN = Convert.ToInt32(Console.ReadLine());

CubeNumber(NumberN);

void CubeNumber(int NumberN)
{
    int index = 1;
    while(index<NumberN+1)
    Console.WriteLine(index + "-" + Math.Pow(index, 3));
    index ++;
}
