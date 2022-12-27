
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int SecondNumber(int number)
{
    int result = number / 10 % 10;
    return result;
}

Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int newNumber = SecondNumber(num);
if (num / 100 != 0 && num / 1000 == 0) Console.WriteLine($"Second namber {newNumber}");
else Console.WriteLine("Please enter a valid number");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int ThirdNumber(int number)
{
        while (number >= 1000)
        {
            number = number / 10;
        }
        return number % 10;
}

Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int newNumber = ThirdNumber(num);
if (num / 100 != 0) Console.WriteLine($"Third namber {newNumber}");
else Console.WriteLine("Third number not");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool DayNumber(int num)
{
    if (num == 6 || num == 7) return true;
    else return false;
}
Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
if (DayNumber(number)) Console.WriteLine("This day is day off ");
else if (number >= 1 && number <= 5) Console.WriteLine("The day is working");
else Console.Write("Enter a valid number ");
*/