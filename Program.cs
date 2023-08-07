// + Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)

System.Console.WriteLine($"max number: {num1}");

else

System.Console.WriteLine($"max number: {num2}");   
*/
// + Задача 4: Напишите программу, которая принимает 
//на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
    max = num2;

if (num3 > max)
    max = num3;

Console.WriteLine("max number " + max);
*/
//+ Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 2) == 0)

Console.WriteLine("Even number");

else 

Console.WriteLine("Odd number");
*/
//+ Задача 8: Напишите программу, которая на вход 
//принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int even = 1;

while (even <= num)
{
    if ((even % 2) == 0)
    Console.Write(even + ",");
    even++;
}
*/
//+ Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}
Repeat:
int number = WriteWait("input three-digit number: ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("repeat input");
    goto Repeat;
}
Console.WriteLine($"In {number} second number {number / 10 % 10}");
*/
//+ Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).
/*
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetThirdRank (int number)
{
   while (number > 999)
   {
    number /= 10;
   } 
   return number % 10;
}
bool ValidateNumber (int number)
{
    if (number <100)
    {
        Console.WriteLine("No third number");
        return false;
    }
    return true;
}
int number = Prompt("Input a number > ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}
*/
//+ Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}
bool Weekend(int digit)
{
    if (digit < 6)
    {
        return false;
    }
    return true;
}
Repeat:
int day = WriteWait("Input the day of the week");
if (day < 1 || day > 7)
{
    Console.WriteLine("Input repeat");
    goto Repeat;
}
if (Weekend(day))
{
    Console.WriteLine("weekend");
}
else
{
    Console.WriteLine("go to work");
}
*/

//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//  является ли оно палиндромом.
/*
int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

bool Palin(int num)
{
    if (num < 10) return false;
    else
    {
        int cutNumber = num, flip = 0;

        while (cutNumber > 0)
        {
            flip *= 10;
            flip += cutNumber % 10;
            if (flip == 0) return false;
            cutNumber /= 10;
        }

        if (flip != num) return false;
    }

    return true;
}

Repeat:
int number = WriteWait("Input number: ");
if (number <= 0) goto Repeat; 
if (Palin(number)) Console.WriteLine($"number {number} – palidrome");
else Console.WriteLine($"number {number} – not a palidrome");
*/
//Задача 21 Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double deltaX = x2 - x1;
    double deltaY = y2 - y1;
    double deltaZ = z1 - z2;
    return Math.Round(Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ), 2);
}
Console.Write("Input x1 ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1 ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1 ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2 ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2 ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2 ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Distance {0:f2}", Distance (x1, y1, z1, x2, y2, z2));
*/
//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
int number = ReadInt("Input number N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
void GetDegree(int A, int B)
{
    int res = 1;
    for (int i = 0; i < B; i++)
    {
        res *= A;
    }
    Console.WriteLine($"{A}, {B} -> {res}");
}
Console.Write("base number ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("degree number ");
int B = Convert.ToInt32(Console.ReadLine());
GetDegree(A, B);
*/
//Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}
int Sum(int inNumber)
{
    int outSum = 0;
    for (int tempNumber = inNumber; tempNumber > 0; tempNumber /= 10)
        outSum += tempNumber % 10;
    return outSum;
}

int number=WriteWait("Input a number ");
Console.WriteLine($"sum of digits {number} = {Sum(number)}");
*/
//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateArr(int m, int valMin, int valMax)
{
    int[] arr = new int[m];
    for (int i = 0; i < m; i++)
    {
        arr[i] = new Random().Next(valMin, valMax + 1);
    }
    return arr;
}
void WriteArr(int[] arr)
{
    Console.Write(arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.Write($" - > [{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.Write("m ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("value min ");
int valMin = Convert.ToInt32(Console.ReadLine());
Console.Write("value max ");
int valMax = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArr(n, valMin, valMax);
WriteArr(myArray);
