// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] masive = new int[8];
void createArray(int[] array)
{
    int dlina = array.Length;
    for (int i = 0; i < dlina; i++) array[i] = new Random().Next(0, 100);
}
void writeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.WriteLine(array[i]);
}
Console.Write("Введите 1 - Если хотите самостоятельно ввести массив. Или любой другое значение: ");
int choice = Convert.ToInt32(Console.ReadLine());
if (choice == 1) for (int i = 0; i < masive.Length; i++)
    {
        Console.Write("Введите число: ");
        masive[i] = Convert.ToInt32(Console.ReadLine());
    }
else createArray(masive);
writeArray(masive);
