//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введи число: ");
int x = Convert.ToInt32(Console.ReadLine());
string xT = Convert.ToString(x);

if (xT.Length > 2)
{
    Console.WriteLine("Третье число:" + xT[2]);
}
else 
{
    Console.WriteLine("Трентьего числа нет");
}
