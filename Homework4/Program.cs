// Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.WriteLine("Эта программа позволяет возвести число в степень");
double Power (double num, double pow){
    double result = Math.Pow(num, pow);
    return result;
}
Console.WriteLine("Введите число");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень");
double power = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(number + " в степени " + power + " равно " + Power(number, power));


// Программа, которая принимает на вход число и выдаёт сумму цифр в числе
int NumCount(int number)
{
    int count = 0;
    int ost = 0;
    int current = number / 10;
    int result = 0;
    while (number > 0)
    {
        ost = number % 10;
        number = number / 10;
        result = result + ost; 
        count++;
    }
    return result;
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма цифр в числе " + num + " равна " + NumCount(num));


// Программа, которая задаёт массив из 8 элементов и выводит их на экран
int[] CreateArray(int ArraySize)
{
    int[] NewArray = new int[ArraySize];
    for(int i = 0; i < ArraySize; i++)
    {
        Console.Write("Введите " + i + " элемент: ");
        NewArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return NewArray;
}

void ShowArray(int[] NewArray)
{
    for (int i = 0; i < NewArray.Length; i++)
        Console.Write(NewArray[i] + " " );
}

int[] myArray = CreateArray(8);
ShowArray(myArray);

