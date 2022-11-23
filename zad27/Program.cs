// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int temp = num;
if (num < -9 || num > 9)
{
    for (int i = 1; i < 99999999999; i++)
    {
        sum = sum + Math.Abs(temp % 10);
        temp = temp / 10;
        if (temp > -9 && temp < 9)
        {
            sum = Math.Abs(temp) + sum;
            break;
        }
    }
}
else sum = Math.Abs(num);
Console.WriteLine($"Сумма цифр числа {num} равна: {sum}");