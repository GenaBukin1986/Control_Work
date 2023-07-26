// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
using System;
using static System.Console;
// Метод, который строку преобразует в список строк
string[] Array(string s)
{
    return s.Split();
}
// Метод, который выводит спикок в консоль в установленном виде
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Write("[");
        Write($"\"{array[i]}\"");
        if (i != array.Length - 1) Write(", ");
        else Write("]");
    }
}
// Метод, который создает новый массив
// из строк, длина которых меньше, либо равна 3 символам
string[] NewArray(string[] array)
{
    string newstr = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        { 
        if (i != 0 && newstr.Length > 0) newstr += " "; 
        newstr += array[i];        
        }
    } 
    return newstr.Split();
}
// Метод, который преобразует строку в список строк;
// выводит этот список в консоль;
// формирует новый список из строк, длина, которых <= 3;
// выводит новый список в консоль; 
void PrintResult(string s)
{
    string[] str = Array(s);
    WriteLine("Список из строк введеных Вами: ");
    PrintArray(str);
    WriteLine();
    string[] newarray = NewArray(str);
    WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам: ");
    PrintArray(newarray);
}

Clear();
Write("Введите произвольное количество строк через пробел (для окончания ввода нажмите Enter): ");
string s = ReadLine()!;
PrintResult(s);