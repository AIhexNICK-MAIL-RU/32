/* Задача 32: Напишите программу замена элементов 
массива: положительные элементы замените на 
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

int[] numbers = new int[10];

FillArray(numbers);
PrintArray(numbers);
ChangeNumbers(numbers);
PrintArray(numbers);

void PrintArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }
}
void ChangeNumbers(int[] array)
{
    for (int i = 0; i <  array.Length; i++)
    {
        array[i] *= -1;
    }

}