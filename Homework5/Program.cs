
// сразу добавим методы для создания массива случайных чисел, ручного ввода массива и вывода массива на экран, а в самих программах будем ими пользоваться

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}



// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

Console.WriteLine ("Программа покажет количество чётных чисел в массиве");
Console.WriteLine("Введите размер массива");   
int arrSize = Convert.ToInt32(Console.ReadLine());
int [] NewArray = CreateRandomArray(arrSize, 100, 1000);

ShowArray(NewArray);

int result = 0;
for (int i = 0; i < NewArray.Length; i++)
{
    if (NewArray[i] % 2 == 0) result = result + 1;       // проверяем чётность элементов массива путем проверки равности 0 остатка от деления на 2 
}

Console.WriteLine($"-> {result}");
Console.WriteLine (" ");

//////////////////////////////////////////


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях 
Console.WriteLine ("Программа покажет сумму элементов, стоящих на нечётных позициях");
Console.WriteLine("Введите размер массива");   
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива");   
int arrayMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива");   
int arrayMax = Convert.ToInt32(Console.ReadLine());
int [] BigArray = CreateRandomArray(arraySize, arrayMin, arrayMax);

ShowArray(BigArray);

int Sum = 0;
for (int i = 1; i < BigArray.Length; i+=2)              // перебираем массив, начиная с 1-го элемента с шагом в 2
{
    Sum = Sum + BigArray[i];
}

Console.WriteLine($"-> {Sum}");
Console.WriteLine (" ");

//////////////////////////////////////////

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива
// [3 7 22 2 78] -> 76
Console.WriteLine ("Программа покажет разницу между максимальным и минимальным элементом массива");
Console.WriteLine("Введите размер массива");                // узнаем у пользователя размер массива, чтобы он сам потом знал, сколько вводить элементов :)
int HMArraySize = Convert.ToInt32(Console.ReadLine());
int[] HandMadeArray = CreateArray(HMArraySize);
ShowArray(HandMadeArray);

int minimum = HandMadeArray[0];
for (int i = 0; i < HandMadeArray.Length; i++)
{
    if (HandMadeArray [i] < minimum) minimum = HandMadeArray[i];
}
int maximum = HandMadeArray[0];
for (int i = 0; i < HandMadeArray.Length; i++)
{
    if (HandMadeArray [i] > maximum) maximum = HandMadeArray[i];
}
int difference = maximum - minimum;

Console.WriteLine ("-> " + difference);