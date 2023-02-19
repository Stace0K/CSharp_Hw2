//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//Строка ввода
int D(string arg)
{
    Console.Write(arg);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

//Разбивка
int number = D("Введите число: ");
if (number == 6)
{
    Console.Write("Выходной день");
}
if (number == 7)
{
    Console.Write("Выходной день");
}
if (number <= 5)
{
    Console.Write("Будний день");
}
if (number > 7)
{
    Console.Write("Нет такого дня недели!");
}
