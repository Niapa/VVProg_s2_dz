/*

___Задача 10__: Напишите программу, которая принимает на вход трёхзначное число и на выходе
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
____________________________________________________________________________________________
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
int input = InputNum("Введите трехзначное число: ");

int result = DelSecond(input);
Console.WriteLine($"Вторая цифра введенного числа — {result}");


___Задача 13__: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
___________________________________________________________________________________
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int DelThird(int e)
{
    if(e < 100)
    {
        e=0;
        return e;
    }
    else
    {
        while(e >= 100)
        {
            int res = 0;
            res = e / 10;
            e=res;
        }
        e =  (e / 10) % 10;
        return e;
    }
}
int num = 0;
num = InputNum("Введите целое число: ");
int MainRes = 0;
MainRes = DelThird(num);
if(MainRes == 0)
        Console.WriteLine("Третьей цифры нет ");
else
        Console.WriteLine($"Третья цифра: {MainRes}");
    


/*

______________________________________________________________________________________________

___Задача 15__: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет



int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
string Holiday(int num)
{   
    string res = "нет";
    if (num==6 || num==7)
    {
        res = "да";
        }
    else
    {
        res = "нет";        
    }
    return res;
}
int number = InputNum("Введите целое число от 1 до 7, обозначающее день недели: ");
string resday = Holiday(number);
Console.WriteLine(resday);
*/
