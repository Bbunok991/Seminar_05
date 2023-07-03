/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

int InPut(string text) //Функция для ввода числа.
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int size = InPut("Enter the lenght of the array: "); // Длина массива.
int left = InPut("Enter the left side: "); // Минимальное число массива.
int right = InPut("Enter the right side: "); // Максимальное число массива.
double min = 0;
double max = 0; // Сумма элементов, стоящих на нечётных позициях.
double sum = 0;

double[] Array(int size, int left, int right) // Функция для заполнения массива и определения суммы элементов, стоящих на нечётных позициях.
{
    Random rand = new Random(); // Объект класса Random. 
    double[] array = new double[size]; // Объявление массива.
    min = array[0];
    max = array[0];
    for(int i = 0; i < array.Length; i++) // Цикл для заполнения массива
    {
        array[i] = Math.Round(rand.Next(left, right) + rand.NextDouble(), 3); // Инициализация элемента массива случайным числом.
        if(array[i] > max) // Сравнение элемента массива с максимальным числом, и заполнение переменной max.
        {
            max = array[i];
        } 
        if(array[i] < min) // Сравнение элемента массива с минимальным числом, и заполнение переменной min.
        {
            min = array[i];
        }
    }
    sum = max - min;
    return array; // Возвращение массива.
}

double[] array = Array(size, left, right+1); // Получение результата функции в переменную array.
System.Console.Write("[" + string.Join(", ", array) + $"] -> {max} - {min} = {sum}"); // Вывод массива и суммы элементов, стоящих на нечётных позициях.