// Console.Write("Введите размерность: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите размерность: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] matrix = new int[rows, columns];

// void GetArray()
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = new Random().Next(0, 10);
//     }
//   }
// }

// void PrintArray()
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       Console.Write(matrix[i, j] + " ");
//     }
//     System.Console.WriteLine();
//   }
// }

// void ChangeArray()
// {
//   int temp = 0;
//   int indexLastRows = matrix.GetLength(0) - 1;

//   for (int i = 0; i < matrix.GetLength(1); i++)
//   {
//     temp = matrix[0, i];
//     matrix[0, i] = matrix[indexLastRows, i];
//     matrix[indexLastRows, i] = temp;
//   }
// }

// GetArray();
// PrintArray();
// ChangeArray();
// System.Console.WriteLine();
// PrintArray();

////////////////////////////

// Console.Write("Введите размерность: ");
// int rows = int.Parse(Console.ReadLine());

// int[,] matrix = new int[rows, rows];
// int[,] matrix2 = new int[rows, rows];

// void GetArray()
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = new Random().Next(0, 10);
//     }
//   }
// }

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     System.Console.WriteLine();
//   }
// }

// void ChangeArray()
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix2[j, i] = matrix[i, j];
//     }
//     System.Console.WriteLine();
//   }
// }

// GetArray();
// PrintArray(matrix);
// ChangeArray();
// Console.WriteLine();
// PrintArray(matrix2);

/////////////////

// Console.Write("Введите размерность: ");
// int rows = int.Parse(Console.ReadLine());

// int[,] matrix = new int[rows, rows];

// int minEl = int.MaxValue;
// int rowMinEl = 0;
// int colMinEl = 0;

// void GetArray()
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = new Random().Next(0, 10);
//       if (minEl > matrix[i, j])
//       {
//         minEl = matrix[i, j];
//         rowMinEl = i;
//         colMinEl = j;
//       }
//     }
//   }
// }

// void PrintArray()
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       Console.Write(matrix[i, j] + " ");
//     }
//     System.Console.WriteLine();
//   }
// }

// void CutArray()
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       if (i != rowMinEl && j != colMinEl)
//       {
//         Console.Write(matrix[i, j] + " ");
//       }
//     }
//     System.Console.WriteLine();
//   }
// }

// GetArray();
// PrintArray();
// Console.WriteLine();
// CutArray();

////////////////////// Домашнее задание

////// Задание 54

Console.Write("Введите первую размерность: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую размерность: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, colums];

void GetArray()
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(0, 10);
    }
  }
}

void PrintArray()
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }

}

void ChangeArray()
{
  int minValue = 100;
  int temp = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

    }
  }

}


GetArray();
PrintArray();
Console.WriteLine();
ChangeArray();
PrintArray();

///////////// Задание 56

// Console.WriteLine("Введите первую размерность");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите вторую размерность");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, colums];
// int[] sumOfRows = new int[rows];


// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     matrix[i, j] = new Random().Next(0, 10);
//     Console.Write(matrix[i, j] + " ");
//     sumOfRows[i] = sumOfRows[i] + matrix[i, j];
//   }
//   Console.WriteLine();
// }
// // Выводим массив сумм строк
// for (int i = 0; i < sumOfRows.Length; i++)
// {
//   Console.WriteLine(sumOfRows[i]);
// }

// // Находим минимальное значение и индекс этого числа, индекс числа = индексу строки двухмерного массива
// int minValue = int.MaxValue;
// int indexMinValue = 0;
// for (int i = 0; i < sumOfRows.Length; i++)
// {
//   if (minValue > sumOfRows[i])
//   {
//     minValue = sumOfRows[i];
//     indexMinValue = i;
//   }
// }
// Console.WriteLine("Минимальное значение: " + minValue);
// Console.WriteLine("Индекс строки с наименьшей суммой элементов: " + indexMinValue);

///////////////// Задание 58
/// Интересное задание!

// Console.WriteLine("Введите размерности массивов");
// int rows = Convert.ToInt32(Console.ReadLine());

// int[,] matrix1 = new int[rows, rows];
// int[,] matrix2 = new int[rows, rows];


// void GetArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(0, 10);
//     }
//   }
// }

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
//   Console.WriteLine();
// }

// GetArray(matrix1);
// PrintArray(matrix1);
// GetArray(matrix2);
// PrintArray(matrix2);


// int[,] multMatrix = new int[rows, rows];
// void MultArray(int[,] array, int[,] array1)
// {

//   for (int i = 0; i < multMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < multMatrix.GetLength(1); j++)
//     {
//       multMatrix[i, j] = array[i, j] * array1[i, j];
//     }
//   }

// }

// MultArray(matrix1, matrix2);
// PrintArray(multMatrix);

////////// Задание 60

// Console.WriteLine("Введите размерности массивов");
// int rows = Convert.ToInt32(Console.ReadLine());

// int[,,] matrix = new int[rows, rows, rows];


// void GetArray()
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       for (int k = 0; k < matrix.GetLength(2); k++)
//       {
//         matrix[i, j, k] = new Random().Next(11, 100);
//       }
//     }
//   }
// }

// void PrintArray()
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       for (int k = 0; k < matrix.GetLength(2); k++)
//       {
//         Console.Write(matrix[i, j, k] + " " + i + j + k + " ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// GetArray();
// PrintArray();

//////////// 
