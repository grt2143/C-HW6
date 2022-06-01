// Программа принимает с клавиатуры M чисел.
// И считает сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа через пробел: ");
int [] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}

Console.WriteLine($"Количество введенных чисел больше 0 -> {count}");