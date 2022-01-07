﻿int[] CreateArray(int count) 
{
    return new int[count];
}
void FillArray(int[] array, int minValue, int maxValue) 
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
}
string PrintArray(int[] array) 
{
    int count = array.Length;
    string res = String.Empty;
    for (int i = 0; i < count; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}

