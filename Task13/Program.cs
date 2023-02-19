//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Ввод
int D(string arg)
{
    Console.Write(arg);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

//Проверка на трехзначность и более
bool Correct(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

//Возврат нужной цифры
int ThirdN(int number)
{
    while (number > 1000)
    {
        number /= 10;
    }
    return number % 10;
}

//Вывод
int N = D("Введите число: ");
{
    if (Correct(N))
    {
        Console.WriteLine(ThirdN(N));
    }
}