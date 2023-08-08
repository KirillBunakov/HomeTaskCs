// int[] array = new int[] { 1, 2, 3, 4, 5 };

// void ReverseArray()
// {
//   for (int i = 0; i < array.Length / 2; i++)
//   {
//     int temp = array[i];
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = temp;
//   }
// }

// void PrintArray()
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     System.Console.Write(array[i] + " ");
//   }
// }

// ReverseArray();
// PrintArray();

//////////////

// Console.Write("Введите сторону треугольника: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите сторону треугольника: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите сторону треугольника: ");
// int z = Convert.ToInt32(Console.ReadLine());

// if (x < y + z && y < x + z && z < x + y)
// {
//   System.Console.WriteLine("Это треугольник");
// }
// else
// {
//   System.Console.WriteLine("Не треугольник");
// }

//////////////

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string result = "";

// while (num > 0)
// {
//   result = num % 2 + result;
//   num /= 2;
// }
// System.Console.WriteLine(result);

//////////////

// Console.Write("Сколько чисел показать: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int firstNum = 0;
// int secondNum = 1;

// System.Console.Write(firstNum + " ");
// System.Console.Write(secondNum + " ");

// for (int i = 2; i < num; i++)
// {
//   int nextNum = firstNum + secondNum;
//   System.Console.Write(nextNum + " ");
//   firstNum = secondNum;
//   secondNum = nextNum;
// }

//////////////

// int[] array = new int[] { 1, 2, 3, 4, 5 };
// int[] array1 = new int[array.Length];

// void CopyArray()
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     array1[i] = array[i];
//     System.Console.Write(array1[i] + " ");
//   }
// }

// CopyArray();




//////////////// Домашнее задание
// Задача 41

// System.Console.Write("Сколько чисел вы хотите ввести? ");
// int count = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[count];
// for (int i = 0; i < count; i++)
// {
//   System.Console.Write("Введина число: ");
//   array[i] = Convert.ToInt32(Console.ReadLine());
// }
// System.Console.WriteLine();
// System.Console.Write("Введеные числа: ");
// for (int i = 0; i < array.Length; i++)
// {
//   System.Console.Write(array[i] + " ");
// }



// void CountOfPosNumbers()
// {
//   int result = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] > 0)
//     {
//       result++;
//     }
//   }
//   System.Console.WriteLine("Чисел больше нуля: " + result);

// }
// System.Console.WriteLine();
// CountOfPosNumbers();

// Задача 43

// int b1 = 2;
// int k1 = 5;
// int k2 = 9;
// int b2 = 4;
