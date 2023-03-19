// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)

void PrintMatrix(int[,] matrix)

void ReplaceNumberToSquare(int[,] matrix)
{
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i < matrix.GetLength(0))
            {
                i = i%2;
            }
        }
      }

}