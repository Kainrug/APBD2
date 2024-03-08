// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!!!, WOOOOOW");

int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAverage(arr));
Console.WriteLine(maxValue(arr));

String mama = "Bozena";
String Tata = "Piotr";
String siostra = "Paulina";

static double GetAverage(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum / arr.Length;
}

static int maxValue(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    return max;
}