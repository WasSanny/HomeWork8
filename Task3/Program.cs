// Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.

// Например, даны 2 матрицы:

// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:

// 18 20
// 15 18

////////////////////////////////////////////////////

Task1();

void Task1()
{
  Console.Clear();

  int[,] array1 = CreatTwoDimensionArray(2, 2);
  Console.WriteLine($"Матрица №1\n{PrintTwoDimensionArray(array1)}");

  int[,] array2 = CreatTwoDimensionArray1(2, 2);
  Console.WriteLine($"Матрица №2\n{PrintTwoDimensionArray(array2)}");

  int[,] resultMatrix = new int[2, 2];
  MultiplyMatrix(array1, array2, resultMatrix);
  Console.WriteLine($"Результат перемножения матриц №1 и №2:\nМатрица №3\n{PrintTwoDimensionArray(resultMatrix)}");
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

int[,] CreatTwoDimensionArray1(int firstLength, int secondLength ) 
{
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

void MultiplyMatrix(int[,] array1, int[,] array2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;

      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
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
