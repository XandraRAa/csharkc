/*Напишите программу, которая принимает по заданному номеру четверти, показывает диапозон возможных координат точек в этой четвертим (x и y).
*/

Console.Write("Введите номер четверти: ");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1:
        Console.WriteLine("Координата X > 0 и Y > 0");
        break;
    case 2:
        Console.WriteLine("Координата X > 0 и Y < 0");
        break;
    case 3:
        Console.WriteLine("Координата X < 0 и Y < 0");
        break;
    case 4:
        Console.WriteLine("Координата X < 0 и Y > 0");
        break;
    default:
        Console.WriteLine("Неверно указана четверть.");
        break;
}

