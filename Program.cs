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