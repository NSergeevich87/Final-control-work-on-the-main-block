﻿/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. 
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

System.Console.Clear();

int NewMessage(string message)
{
    System.Console.Write(message);
    string answer = System.Console.ReadLine();
    int result = int.Parse(answer);
    return result;
}

string[] GenFirstArray(int size)
{
    if (size <= 0)
    {
        System.Console.WriteLine("! Размер массива должен быть > 0 - поэтому он был увеличен до минимально возможного значения !");
        size = 1;
    }

    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"Введите символ/ы {i + 1}ого элемента массива: ");
        string answer = System.Console.ReadLine();
        array[i] = answer;
    }

    return array;
}

void PrintArray(string[] array)
{
    System.Console.Write("Условие: ");
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]} ");
    }

    System.Console.Write("]");
}

void PrintArray2(string[] array)
{
    System.Console.Write("Решение: ");
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]} ");
    }

    System.Console.Write("]");
}

string[] GenSecondArray(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }

    string[] newArr = new string[count];
    int indexNewArray = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArr[indexNewArray] = array[i];
            indexNewArray++;
        }
    }
    return newArr;
}

int size = NewMessage("Введите размер массива: ");
string[] firstArray = GenFirstArray(size);
PrintArray(firstArray);
string[] secondArray = GenSecondArray(firstArray);
System.Console.WriteLine();
PrintArray2(secondArray);


