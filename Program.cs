//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
bool CheckPereverten(int number)
{
    int digital1, digital2, digital4, digital5;
    digital1 = number/10000;
    digital2 = number%10000/1000;
    digital4 = number%100/10;
    digital5 = number%10;
    if (digital1 == digital5 & digital2 == digital4) return true;
    else return false;
}

Console.Write("Введите пятизначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (CheckPereverten(Number)) Console.WriteLine("Введенное число является палиндромом");
else Console.WriteLine("Введенное число не является палиндромом");



//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*void DistanceCalc(int ax, int ay, int az, int bx, int by,  int bz)
{
        Console.WriteLine($"{Math.Sqrt((bx-ax)*(bx-ax) + (by-ay)*(by-ay) + (bz-az)*(bz-az))}"); 
}
Console.Write("Введите число координату X точки А: ");
int AX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число координату Y точки А: ");
int AY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число координату Z точки А: ");
int AZ = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число координату X точки B: ");
int BX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число координату Y точки B: ");
int BY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число координату Z точки B: ");
int BZ = Convert.ToInt32(Console.ReadLine());
DistanceCalc(AX, AY, AZ, BX, BY, BZ);*/



//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*void CubeCalc(int number)
{
    int i = 1;
    while (i <= number)
    {
        Console.WriteLine($"{i*i*i}");
        i++;
    }
}

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number>0) CubeCalc(Number);
else Console.Write("Введите число болше нуля!");*/
















/*
void FindSign(int quarter)
{
    switch (quarter)
    {
        case 1:
            Console.WriteLine("(+x,+y)");
            break;
        case 2:
            Console.WriteLine("(+x,-y)");
            break;
        case 3:
            Console.WriteLine("(-x,-y)");
            break;
        case 4:
            Console.WriteLine("(-x,+y)");
            break;
        default:
            Console.WriteLine("Такой четверти не существует");
            break;
    }
}
Console.Write("Введите номер четверти: ");
int Quarter = Convert.ToInt32(Console.ReadLine());
FindSign(Quarter);
*/


/*
void FindSign(int x, int y)
{
    string result = "Возможный диапазон чиел: ";
    if (x!=0 & y!=0)
    {
        if (x>0) result = result + $"X(0,{x})";
        else result = result + $"X({x},0)";

        if (y>0) result = result + $"; Y(0,{y})";
        else result = result + $"; Y({y},0)";
    }
    else 
    {
        result = "X или Y не может быть равен 0";
        Console.Write(result);
        result = "";
    }
    Console.Write(result);
}
Console.Write("Введите координату X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
FindSign(X,Y);
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*
void Findquater(int n)
{
    for (int i=1; i<=n; i++)
    {
        Console.Write($"{i*i} ");
    }        
}
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Findquater(N);
*/

// Напишите программу, 
//которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
//AB = √(xb - xa)^2 + (yb - ya)^2

/*void Test(double ax, double ay, double bx, double by)
{
        Console.WriteLine($"{Math.Sqrt((bx-ax)*(bx-ax) + (by-ay)*(by-ay))}"); 
}
Console.Write("Введите число координату X точки А: ");
double AX = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число координату Y точки А: ");
double AY = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число координату X точки B: ");
double BX = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число координату Y точки B: ");
double BY = Convert.ToDouble(Console.ReadLine());
Test(AX, AY, BX, BY);*/
