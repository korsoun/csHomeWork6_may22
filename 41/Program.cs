// Задача 41
// ввести с клавиатуры M чисел. посчитать количество введенных положительных чисел

Console.Write("Введите числа, разделив их запятой: ");
int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

int GetCountOfPositiveNums (int[] array)
{
int count = 0;
for(int i = 0; i < array.Length; i++)
{
if (array[i] > 0) {count++;}
}
return count;
}

Console.WriteLine($"Среди этих чисел {GetCountOfPositiveNums(array)} положительных.");
