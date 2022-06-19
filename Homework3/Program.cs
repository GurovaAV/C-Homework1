// Программа, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N
void CubeCount (int N){
    int count = 1;
    Console.Write(N + " -> ");
    while (count <= N){
        Console.Write(count * count * count + " ");
        count++;
    }
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
CubeCount(number);


// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
void Palindrom (int number){
    if (9999 < number && number < 100000){
        int n1 = number % 10;
        int n2 = number / 10 % 10;
        int n3 = number / 100 % 10;
        int n4 = number / 1000 % 10;
        int n5 = number / 10000;
        if(n2 == n4 && n1 == n5){
            Console.WriteLine("Число " + number + " является палиндромом");
        }
        else {
            Console.WriteLine("Число " + number + " не является палиндромом");
        }
    }
    else {
        Console.WriteLine ("Ошибка ввода");
    }
}
Console.WriteLine ("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom (num);


// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
void Distance (double x1, double y1, double z1, double x2, double y2, double z2){
double distance3d = Math.Round(Math.Sqrt((Math.Abs(x2 - x1) * Math.Abs(x2 - x1)) + (Math.Abs(y2 - y1) * Math.Abs(y2 - y1)) + (Math.Abs(z2 - z1) * Math.Abs(z2 - z1))),2);
      Console.WriteLine("Расстояние между точками равно " + distance3d);
    }
Console.WriteLine("Введите координату X первой точки");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки");
int zb = Convert.ToInt32(Console.ReadLine());
Distance (xa, ya, za, xb, yb, zb);