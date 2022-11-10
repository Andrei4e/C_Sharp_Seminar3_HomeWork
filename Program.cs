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