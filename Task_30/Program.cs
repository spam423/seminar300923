/*Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/


int[] RandomArray (int min, int max, int length)
{
   сusing System;

public class Answer
{
  
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] array = RandomArray(0, 1, 8);

PrintArray(array);