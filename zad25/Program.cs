// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int result = numA;
for (int i = 2; i <= numB; i++)
    result = result * numA;
Console.WriteLine($"Значение {numA} в {numB} степени равно: {result}");