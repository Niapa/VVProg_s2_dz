/*


___Задача 13__: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

___Задача 15__: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет


___Задача 10__: Напишите программу, которая принимает на вход трёхзначное число и на выходе
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int num = -1;
int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int DelSecond(int number)
{
    int remainder = number % 100;
    int remainder1 = (remainder-remainder % 10)/10;
    return remainder1;
}
int input = InputNum("Введите трехзначное число");

int result = DelSecond(input);
Console.WriteLine($"Вторая цифра введенного числа — {result}");