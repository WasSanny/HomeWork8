// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Task1();

void Task1()
{
  int[,] array = CreatTwoDimensionArray(4, 7);
  Console.WriteLine(PrintTwoDimensionArray(array));

  int minSumLine = 0;
  int sumLine = SumLineElement(array, 0);

  for (int i = 1; i < array.GetLength(0); i++)
  {
    int tempSumLine = SumLineElement(array, i);

    if (sumLine > tempSumLine)
    {
      sumLine = tempSumLine;
      minSumLine = i;
    }
  }

  Console.WriteLine($"\n В строке № {minSumLine+1} - наименьшая сумма элементов равная: {sumLine}");
}

int[,] CreatTwoDimensionArray(int firstLength, int secondLength ) 
{
  Console.WriteLine();

  int[,] result = new int[firstLength, secondLength]; 
  Random rnd = new Random(); 

  for (int i = 0; i < result.GetLength(0); i++) 
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = rnd.Next(1, 10);
    }
  }

  return result;
}

int SumLineElement(int[,] array, int i)
{
  int sumLine = array[i,0];

  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }

  return sumLine;
}

string PrintTwoDimensionArray(int[,] array) 
{
  string result = string.Empty; 

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      result += $"{array[i,j]} "; 
    }
    
    result += Environment.NewLine; 
  }

  return result;
}