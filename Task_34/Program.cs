/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

int InPut(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int size = InPut("Enter the lenght of the array: ");
int left = InPut("Enter the left side: ");
int right = InPut("Enter the right side: ");

int[] Array(int size, int left, int right)
{
    Random rand = new Random();
    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(left, right);
    }
    return array;

}
int[] array = Array(size, left, right+1);
System.Console.Write("[" + string.Join(", ", array) + "]");