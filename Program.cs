//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

void task10()
{
    int number = 187;
    Console.WriteLine(number);
    if(number > 99 && number < 1000)
    {
        Console.WriteLine("Вторая цифра числа: " + (number / 10 % 10));
    }
    else
    {
        Console.WriteLine("Введено не трёхзначное число");
    }
}
task10();

//Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//326791 -> 6

void task13()
{
    int number = 1235;
    number = Math.Abs(number);
    if (number < 100)
    {
        Console.WriteLine("В числе менее трёх символов");
    }
    else
    {
        while (number > 999)
        {
            number /= 10;
        }
        Console.WriteLine(number % 10);
    }
}
task13();

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

void task15()
{
    int day = 5;
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Выходной");
    }
    else if (day >= 1 && day <= 5)
    {
        Console.WriteLine("Будни");
    }
    else
    {
        Console.WriteLine("Некорректный ввод");
    }
}
task15();