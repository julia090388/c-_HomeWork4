//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//  в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int a = InputNumber("введите число A");
int b = InputNumber("введите число B");

int num(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;     //result=result*a
    }

    return result;
}
Console.WriteLine($"Степень числа {a} = {num(a, b)}");


//  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int N = InputNumber("введите число ");

int CountNumbers(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}
Console.WriteLine($"Число {N} = {CountNumbers(N)}");

//  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int[] Array()
{
    int[] array = new int [8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void PrintArray(int[] tooArray)
{
    for (int i = 0; i < tooArray.Length; i++)

    Console.Write($"{tooArray[i]} ");   
}
int[] array = Array(); 
PrintArray(array);


