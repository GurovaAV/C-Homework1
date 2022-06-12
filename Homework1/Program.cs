// Задача 2 Программа выбирает, какое из двух чисел большее, а какое меньшее
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < number2)
{
    Console.Write ("Большее число - " + number2 + ", меньшее число - " + number1);
}
else
{
    Console.Write ("Большее число - " + number1 + ", меньшее число - " + number2);
}



// Задача 4 Программа принимает на вход три числа и выдает максимальное из этих чисел
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
        {
            Console.Write ("Максимальное число - " + number1);
        }
else if (number2 > number1 && number2 > number3)
        {
            Console.Write ("Максимальное число - " + number2);
        }
else
    {
           Console.Write ("Максимальное число - " + number3);
    }



// Задача 6 Программа на вход принимает число и выдает, является ли число четным
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
double ostatok = number % 2;
if (ostatok == 0)
{
    Console.WriteLine("Число " + number + " является четным");
}
else
{
    Console.WriteLine("Число " + number + " является нечетным");
}



//Задача 8 Программа принимает на вход число N, а на выходе показывает все четные числа от 1 до N
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current <= N)
{
   Console.Write(current + " ");
    current = current + 2;
}