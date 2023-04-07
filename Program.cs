/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. */

System.Console.Clear();

int NewMessage (string message)
{
    System.Console.Write(message);
    string answer = System.Console.ReadLine();
    int result = int.Parse(answer);
    return result;
}

string[] GenFirstArray (int size)
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

void PrintArray (string[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]} ");
    }

    System.Console.Write("]");
}

string[] GenSecondArray (string[] array)
{
    int size = new Random().Next(4);
    if (array.Length < 3) size = new Random().Next(array.Length + 1);
    string[] arr = new string[size];
    
    for (int i = 0; i < arr.Length; i++)
    {
        int number = new Random().Next(array.Length);
        
        arr[i] = array[number];
    }
    
    return arr;
}

int size = NewMessage ("Введите размер массива: ");
string[] firstArray = GenFirstArray (size);
PrintArray (firstArray);
string[] secondArray = GenSecondArray (firstArray);
System.Console.WriteLine();
PrintArray (secondArray); 


