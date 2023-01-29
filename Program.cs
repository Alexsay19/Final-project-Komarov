// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше или равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. Сделать работу исключительно массивами. 
//Пример: "Hello" "24" "for" "1" --> "24" "for" "1"


Console.Clear();

Console.WriteLine("Напишите элементы массива (Строки должны быть меньше 3 символов) :") ;

int i = 5;
string[] array = new string[i];

FillArray(array); 
PrintArray(array);

void PrintArray(string[] Array)
{
    int a = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        
        if (Array[i].Length <= 3)
        {
                Console.Write($"{Array[i]}\t");
        } 
        else a = a+1; 
    
      if ( a >= 5)
    {
        Console.WriteLine("------------");
        Console.WriteLine("Элементов не найдено!");
    }
    }
}

void FillArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
            Array[i] = Console.ReadLine();
    }
}