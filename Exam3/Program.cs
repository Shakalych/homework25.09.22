//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void Check (int day)
{
    if ( day == 6 || day ==7)
    {
        Console.WriteLine("Это выходной");
    }
    else if (day < 1 || day > 7)
    {
        Console.WriteLine("Введите число от одгого 1 до 7");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    } 
}
Check(day);