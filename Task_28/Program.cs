﻿/*Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120*/

int SumNumbers (int num)
{
    
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        checked
        {
            sum = sum + i;
        }
        
    }
    return sum;
}




Console.WriteLine("введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if  (number < 1)
{ 
    Console.WriteLine("Некорректный ввод");
    return;
}

int result = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} -> {result}");