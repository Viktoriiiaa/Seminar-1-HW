﻿//Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Please do not enter the same number.Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2){
    Console.WriteLine($"max={num1}");
}
else{
    Console.WriteLine($"max={num2}");
}
*/

/*
max=num1;
if (num2>max){
    Console.WriteLine($"max={num2}");
}
if (num3>max){
    Console.WriteLine($"max={num3}")";
}
else{ 
    Console.WtiteLine($"max={num1}");
}
*/
/*
//Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Please do not enter the same number.Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third int number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num2 > max){
    max = num2;
    }
if (num3>max){
    max = num3;
    }

Console.WriteLine($"{max} number max");
*/

//Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*

Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine( "да");
}
else
{
    Console.WriteLine( "нет");
}

*/
//Задача 4.  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*

Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    if (i % 2 == 0)
{
    Console.Write( i + " ");
}}

*/