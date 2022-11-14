// See https://aka.ms/new-console-template for more information
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*int[] CreateRandom()
{
  int[] array = new int[4];
  for(int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
  }
  return array;
}
void ShowArray(int[] array)
{
  int count = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if(array[i] % 2 == 0)
     count++;
  }
  Console.WriteLine($"Четные числа:{count}");
}
int[] myArray = CreateRandom();
ShowArray(myArray);

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
/*int[] CreateRandom()
{
  int[] array = new int[4];
  for(int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
  }
  return array;
}
void ShowArray(int[] array)
{
  int even_sum = 0;

  for(int i = 1; i < array.Length; i+=2)
  {
    even_sum += array[i];
  }
  Console.WriteLine($"сумма элементов стоящих на нечетных позициях {even_sum}");
}
int[] myArray = CreateRandom();
ShowArray(myArray);*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*double[] ArrayNum()
{
  double[] array = new double[4];
  for(int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().NextDouble();
    Console.WriteLine(array[i] + " ");
  }
  return array;
}
void ShowArray(double[] array)
{
  double max = array[0];double min = array[0];double result = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if(array[i] > max)
      max = array[i];
    else if(array[i] < min)
      min = array[i];
      result = max - min;
  }
  Console.WriteLine();
  Console.WriteLine($"Разница {max} и {min} = {result}");
}
double[] myArray = ArrayNum();
ShowArray(myArray);

/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2*/

//1, -7, 567, 89, 223-> 4

/*void Counter()
{ 
  Console.Write("Введите элементы(через пробел): ");
  
  int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);// не знаю почему подчеркивает

  int count = 0;

  for(int i = 0; i < arr.Length; i++)
  {
    if(arr[i] > 0)
    
      count++;  
  }
  Console.WriteLine($"Чисел больше 0: {count}");  
}
Counter();

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

/*void intersection(double b1, double k1, double b2, double k2)
{
  double x = -(b1 - b2) / (k1 - k2);
  double y = k1 * x + b1;
 
  Console.WriteLine($"Пересечение двух прямых в точке: (x = {x};y = {y})");
}
  Console.Write("Введите b1: ");
  double b1 = Convert.ToDouble(Console.ReadLine());
  Console.Write("Введите k1: ");
  double k1 = Convert.ToDouble(Console.ReadLine());
  Console.Write("Введите b2: ");
  double b2 = Convert.ToDouble(Console.ReadLine());
  Console.Write("Введите k2: ");
  double k2 = Convert.ToDouble(Console.ReadLine());

intersection(b1, k1, b2, k2);*/

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

/*Console.WriteLine("Задайте размерность матрицы m x n");
Console.Write("Введите m ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double [m, n];
//int sum = 0;
for(int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().NextDouble();
        //if(i == j)
        //sum = sum + matrix[i, i];
        Console.Write(matrix[i, j] + " ");
    }

    Console.WriteLine();
}*/

/*double[,] CreateRandom()
{
  Console.Write("Input a number of m: ");
  int m = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of n: ");
  int n = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min posible value: ");
  int minValue = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a max posible value: ");
  int maxValue = Convert.ToInt32(Console.ReadLine());
  double[,] array = new double[m, n];
  for(int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
      array[i, j] = new Random().Next(minValue, maxValue);
  return array;
}
void ShowArray(double[,]array)
{
  for(int i = 0;i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j]+ " ");
    } 
    Console.WriteLine();
  }
}
double[,] myArray = CreateRandom();
ShowArray(myArray);*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4
/*Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine());
int n = 4;
int m = 3;
//Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Исходный массив: ");
for(int i = 0; i< arr.GetLength(0);i++)
{
    for(int j = 0; j< arr.GetLength(1); j++)
    {
        //arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j]+ " ");
    }
    Console.WriteLine();
}
if(pos1<0 | pos1 > arr.GetLength(0) - 1 | pos2<0 | pos2 > arr.GetLength(1) - 1)
{
    Console.WriteLine("Такого элемента не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
}

//1 7 -> числа с такими индексами в массиве нет

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for(int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j]+ " ");
    }
    Console.WriteLine();
} 
Console.WriteLine("____________");
Console.WriteLine(arr.GetLength(0));
for(int j=0; j<arr.GetLength(1); j++)
{
    double sum = 0;
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{sum/arr.GetLength(0)}");
}
Console.ReadLine();*/

/*int[,] FindelementNum()
{
  int[,] array = new int[3,4]; 
  for(int i = 0; i < array.GetLength(0); i++)
    { 
        Console.WriteLine();
        for(int j = 0; j < array.GetLength(1); j++)
        { 
          array[i, j] = new Random().Next(1, 10);
          Console.Write(array[i, j] + " | ");
        }        
    }
    Console.WriteLine();
    return array;
}
void NewFind(int[,] array)
{
  Console.WriteLine("Find element");
  Console.Write("Input a number of row: ");
  int row = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of colums: ");
  int column = Convert.ToInt32(Console.ReadLine());
  
    if(row < array.GetLength(0) && column < array.GetLength(1))
        Console.WriteLine($"Значение элемента {row} и {column} в массиве {array[row-1, column-1]}");
    else
        Console.WriteLine("Такого элемента не существует");
}
int[,] newFind = FindelementNum();
NewFind(newFind);*/

double[,] Num2DArray()
{
  double[,] array = new double[3,4];
  for(int i = 0; i < array.GetLength(0); i++)
  { 
    Console.WriteLine();
    for(int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next(1, 10);
      Console.Write(array[i,j] + " ");
    } 
  }
  Console.WriteLine();
  return array;
}
void Getsum(double[,] array)
{ 
  Console.WriteLine("___________");
  for(int j=0; j<array.GetLength(1); j++)
  {
    double sum = 0;
    for(int i = 0; i<array.GetLength(0); i++)
      sum += array[i, j]; 
    Console.Write($"{sum/array.GetLength(0)} "); 
  } 
Console.WriteLine();
}
double[,] newAverage = Num2DArray();
Getsum(newAverage);
  

//int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];

//for(int i = 0; i < arr.GetLength(0); i++)
//{
    //for(int j = 0; j < arr.GetLength(1); j++)
  //  {
    //    arr[i, j] = random.Next(1, 10);
      //  Console.Write(arr[i, j]+ " ");
    //}
    //Console.WriteLine();
//} 
//Console.WriteLine("____________");
//Console.WriteLine(arr.GetLength(0));
//for(int j=0; j<arr.GetLength(1); j++)
//{
    //double sum = 0;
    //for(int i = 0; i<arr.GetLength(0); i++)
    //{
      //  sum += arr[i, j];
    //}
  //  Console.WriteLine($"{sum/arr.GetLength(0)}");
//}
//Console.ReadLine();



