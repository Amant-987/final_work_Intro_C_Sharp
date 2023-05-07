/* Final work for Intro to C-Sharp*/

/*Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа.

Примеры:
["hello", "2", "world', ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/


using System;
using static System.Console;


string[] textArray = FillArray();
string[] tempArray = GenerateNewArray(textArray);
string getArray = PrintArray(textArray);
string resultArray = PrintArray(tempArray);
WriteLine(getArray + " --> " + resultArray);

string[] FillArray()
{
    WriteLine("Enter the data separated by a space, and when you have finished, press Enter: ");
    string enterSymbols = ReadLine()!;
    if (enterSymbols == null) enterSymbols = "";
    char[] separators = new char[] { ',', ' ' };
    string[] textArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return textArray;
}

string PrintArray(string[] textArray)
{
    string stringArray = "[";
    for (int i = 0; i < textArray.Length; i++)
    {
        if (i == textArray.Length - 1)
        {
            stringArray += $"\"{textArray[i]}\"";
            break;
        }
        stringArray += ($"\"{textArray[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

int CountSymbols(string[] textArray)
{
    int counter = 0;
    foreach (string item in textArray)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] GenerateNewArray(string[] textArray)
{
    int tempArrayLength = CountSymbols(textArray);
    string[] tempArray = new string[tempArrayLength];
    int i = 0;
    foreach (string item in textArray)
    {
        if (item.Length <= 3)
        {
            tempArray[i] = item;
            i++;
        }
    }
    return tempArray;
}



/*
SECOND VARIANT

string[] textArray = new string[] { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan", "O_o" };
string[] result = new string[0];

foreach (var item in textArray)
{
    if (item.Length <= 3)
    {
        Array.Resize(ref result, result.Length + 1);
        result[result.Length - 1] = item;
    }
}

WriteLine($"[{String.Join("; ", result)}]");

*/