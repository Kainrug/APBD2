﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!!!, WOOOOOW");

int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAvg(arr));

String mama = "Bozena";
String Tata = "Piotr";
String siostra = "Paulina";

static double GetAvg(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum / arr.Length;
}