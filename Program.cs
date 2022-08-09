// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//задача 2 Написать программу ,которая на вход принимает два числа и выдаёт,какое число большее , а какое меньшее.

Console.Clear();
Console.Write("Введите число: ");
int number_A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int number_B = Convert.ToInt32(Console.ReadLine());
if (number_A == number_B)
    Console.WriteLine("Вы ввели равные числа");
if (number_A < number_B)

    Console.WriteLine("Максимальное число: " + number_B + " ; минимальное число: " + number_A);
else

    Console.WriteLine("Максимальное число: " + number_A + " ; минимальное число: " + number_B);


// Задача 4  Написать программу ,которая на вход принимает числа и выдает ,максимальное  из этих чисел
Console.Clear();

Console.WriteLine("Введите  первое число: ");
int number_C = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number_D = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number_E = Convert.ToInt32(Console.ReadLine());
int max = number_C;
if (number_D > max) max = number_D;
if (number_E > max) max = number_E;

Console.WriteLine("Максимальное значение: + max");


// Задача 6 Написать программу,которая на вход принимает число  и выдаёт является ли число чётным (делится ли оно на два без остатка)

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0)
    Console.WriteLine("Вы ввели 0, оно не может быть ни четным ни не четным");
else
    if (number % 2 == 0)
    Console.WriteLine("Число четное!");
else
    Console.WriteLine("Число нечетное!");


    //  Задача 7 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Clear();
Console.Write("Введите трехзначное число и я покажу вам последнюю цифру этого числа: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>=0)
{
    if (number<100||number>999)
        Console.WriteLine("Вы ввели не трехзначное число!");
    else
    {
        int rez = number%10;
        Console.WriteLine(rez);
    }
}
if (number<0)
{
    if (number>-100||number<-999)
        Console.WriteLine("Вы ввели не трехзначное число!");
    else
    {
        int rez = number%10;
        Console.WriteLine(-rez);
    }
}


// Задача 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число и я покажу все четные числа от 1 до вашего числа: ");
int N = Convert.ToInt32(Console.ReadLine());
int chet = 1;

if (chet==N||N==0||-chet==N)
{
    Console.WriteLine("Нет четных чисел.");
}
if (N>0)
{
    while (chet<=N)
    {
        while (chet%2==0)
        {
            Console.WriteLine(chet);
            chet = chet + 1;
        }
        chet = chet + 1;
    }
}
if (N<=-0)
{
      while (-chet>=N)
    {
        while (N%2==0)
        {
            Console.WriteLine(N);
            N=N+1;
        }
        N=N+1;
    }  
}
