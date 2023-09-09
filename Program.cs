Console.WriteLine("Задание 34"); // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int count = 0;
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    count++;
}

Console.WriteLine($"количество чётных чисел в массиве -> {count} ");
void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();



Console.WriteLine("Задание 36"); // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int width = InputNum("Введите размер массива: ");
int[] number = new int[width];
FillArrayRandomNumber(number);
PrintArrayy(number);
int sumNumbersEvenIndex = 0;


for (int i = 1; i < number.Length; i += 2)
{
    sumNumbersEvenIndex += number[i];
}
Console.Write($"Cумма элементов ,стоящих на нечетных позициях равна : {sumNumbersEvenIndex} ");



void FillArrayRandomNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}


void PrintArrayy(int[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
Console.WriteLine();
Console.WriteLine();



Console.WriteLine("Задание 38"); // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a)
{
    Random rand = new Random();
    System.Console.Write("[ ");
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = rand.NextDouble() * 100;
        Console.Write($"{randomArray[i]:F2} ");
    }
    Console.Write("]");
}

double raz(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (max < randomArray[i])
            max = randomArray[i];
        if (min > randomArray[i])
            min = randomArray[i];
        i = i + 1;
    }
    return max - min;
}

mas(a);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {raz(randomArray):F2}");