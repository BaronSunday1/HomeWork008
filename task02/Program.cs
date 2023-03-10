// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int ReadInput(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}
int[,] FirstGenerateMatrix(int m, int n)
{
    int[,] firstMatrix = new int[m,n];
    Random rand = new Random();
    for(int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            firstMatrix[i,j] = new Random().Next(-21, 21);
        }
    }
    return firstMatrix;
}
int[,] SecondGenerateMatrix(int p, int n)
{
    int[,] secondMatrix = new int[p,n];
    Random rand = new Random();
    for(int i = 0; i < secondMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            secondMatrix[i,j] = new Random().Next(-21, 21);
        }
    }
    return secondMatrix;
}
void DoubleMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(-21, 21);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
int m = ReadInput("Введите число строк 1-й матрицы: ");
int n = ReadInput("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = ReadInput("Введите число столбцов 2-й матрицы: ");
int[,] firstMatrix = FirstGenerateMatrix(m, n);
CreateArray(firstMatrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMatrix);

int[,] secondMatrix = SecondGenerateMatrix(n, p);
CreateArray(secondMatrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secondMatrix);

int[,] resultMatrix = new int[m,p];

DoubleMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);