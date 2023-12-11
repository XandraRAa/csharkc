/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления. 

34,5 -> не кратно, остаток 4
16,4 -> кратно
*/

Console.WriteLine("Пожалуйста, введите два числа, ");
Console.WriteLine("чтобы выяснить является ли второе число кратным первому.");

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");

int result = num1 % num2;

if (result == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine($"Не кратно, остаток {result} ");
}