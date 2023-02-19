//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int D(string message)
{
    Console.Write(message);
    string m = Console.ReadLine();
    int result = Convert.ToInt32(m);
    return result;
}

int number = D("Введите трёхзначное число: ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Это не трёхзначное число");
    return;
}

Console.WriteLine(number);
int second = number / 10 % 10;
Console.WriteLine(second);