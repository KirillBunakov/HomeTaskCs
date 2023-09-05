// двумерные массивы

// Console.WriteLine("Введите первую размерность");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите вторую размерность");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, colums];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     matrix[i, j] = new Random().Next(0, 10);
//     Console.Write(matrix[i, j] + " ");
//   }
//   Console.WriteLine();
// }

/////////////////

// int[,] matrix = new int[3, 4];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     matrix[i, j] = i + j;
//     Console.Write(matrix[i, j] + " ");
//   }
//   Console.WriteLine();
// }

////////////////

// Console.WriteLine("Введите первую размерность");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите вторую размерность");
// int colums = Convert.ToInt32(Console.ReadLine());


// int[,] matrix = new int[rows, colums];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     matrix[i, j] = new Random().Next(0, 10);
//     Console.Write(matrix[i, j] + " ");
//   }
//   Console.WriteLine();
// }

// Console.WriteLine();

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     if (i % 2 == 0 && j % 2 == 0)
//     {
//       matrix[i, j] = matrix[i, j] * matrix[i, j];
//     }
//     Console.Write(matrix[i, j] + " ");
//   }
//   Console.WriteLine();
// }

///////////////

// Console.WriteLine("Введите первую размерность");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите вторую размерность");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, colums];
// int sumNum = 0;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     matrix[i, j] = new Random().Next(0, 10);
//     Console.Write(matrix[i, j] + " ");

//     if (i == j)
//     {
//       sumNum = sumNum + matrix[i, j];
//     }
//   }
//   Console.WriteLine();
// }

// Console.WriteLine("Сумма гравной диагонали равняется:" + sumNum);

//////// Домашнее задание
// Задача 47

// Console.WriteLine("Введите первую размерность");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите вторую размерность");
// int colums = Convert.ToInt32(Console.ReadLine());

// double[,] matrix = new double[rows, colums];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     matrix[i, j] = new Random().NextDouble();
//     Console.Write(matrix[i, j] + " ");
//   }
//   Console.WriteLine();
// }

// Задача 50

// int[,] matrix = new int[5, 5];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     matrix[i, j] = new Random().Next(1, 10);
//     Console.Write(matrix[i, j] + " ");
//   }
//   Console.WriteLine();
// }

// Console.Write("Введите позицию элемента: ");
// int position = Convert.ToInt32(Console.ReadLine());
// int result = 0;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     if (i == position / 10 && j == position % 10)
//     {
//       result = matrix[i, j];
//     }
//   }
// }

// if (result > 0)
// {
//   Console.WriteLine(result);
// }
// else
// {
//   Console.WriteLine("Такого числа нет в массиве");
// }

////// Задача 52

// int[,] matrix = new int[3, 3];
// int sumColum1 = 0;
// int sumColum2 = 0;
// int sumColum3 = 0;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     matrix[i, j] = new Random().Next(0, 10);
//     Console.Write(matrix[i, j] + " ");
//     if (j == 0)
//     {
//       sumColum1 = sumColum1 + matrix[i, j];
//     }
//     else if (j == 1)
//     {
//       sumColum2 = sumColum2 + matrix[i, j];
//     }
//     else if (j == 2)
//     {
//       sumColum3 = sumColum3 + matrix[i, j];
//     }
//   }
//   Console.WriteLine();
// }

// Console.WriteLine("Сумма цифр первого столбца: " + sumColum1);
// Console.WriteLine("Сумма цифр второго столбца: " + sumColum2);
// Console.WriteLine("Сумма цифр третьего столбца: " + sumColum3);



