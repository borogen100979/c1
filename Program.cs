//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
 
        if (number % 7 == 0 && number % 23 == 0)
        {
            Console.WriteLine("Число кратно и 7, и 23.");
        }
        else if (number % 7 == 0)
        {
            Console.WriteLine("Число кратно только 7.");
        }
        else if (number % 23 == 0)
        {
            Console.WriteLine("Число кратно только 23.");
        }
        else
        {
            Console.WriteLine("Число не кратно ни 7, ни 23.");
        }
        
        Console.ReadLine();
    }

//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
{
int J=0;
    Console.Write("Введите x}: ");
        Double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y}: ");
        Double y = Convert.ToDouble(Console.ReadLine());
    if (x == 0 || y == 0) J = 0;
    else if (y > 0.0 && x > 0.0) J = 1;
    else if (y > 0.0 && x < 0.0) J = 2;
    else if (y < 0.0 && x < 0.0) J = 3;
    else if (y < 0.0 && x > 0.0) J = 4;
  
Console.WriteLine(J);
}

//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
{
Console.Write("Введите число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 10;
int secondDigit = number % 10;
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; 
Console.WriteLine(maxDigit);
}

//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
 Console.Write("Введите натуральное число N: ");
 int N = Convert.ToInt32(Console.ReadLine());
 if (N < 10)
 {
     Console.WriteLine(N);
 }
 else
 {
     while (N > 0)
     {
         int currentDigit = N % 10;
         N /= 10;
         if (N > 0)
         {
            Console.Write(currentDigit + ",");
         }
         else
        {
             Console.WriteLine(currentDigit);
        }
     }
}