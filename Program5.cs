// int[] array = new int[12];

// int SumNegNumber = 0;
// int SumPolNumber = 0;

// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(-9, 10);
//   Console.WriteLine(array[i] + " ");
//   if (array[i] > 0)
//   {
//     SumPolNumber = SumPolNumber + array[i];
//   }
//   else
//   {
//     SumNegNumber = SumNegNumber + array[i];
//   }
// }
// System.Console.WriteLine($"Сумма положительных чисел = {SumPolNumber}");
// System.Console.WriteLine($"Сумма отрицательных чисел = {SumNegNumber}");

//////////////////
// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(-9, 10);
//   if (array[i] < 0)
//   {
//     array[i] = array[i] * -1;
//     Console.WriteLine(array[i]);
//   }
// }

//////////////////

// Console.Write("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(1, 5);
//   if (array[i] == number)
//   {
//     Console.WriteLine($"Число под индексом {i} = числу заданное пользователем");
//   }
// }

//////////////////

// int[] array = new int[123];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0, 1000);
//   if (array[i] > 10 && array[i] < 99)
//   {
//     count++;
//   }
// }
// Console.WriteLine($"Количество совпадений: {count}");

//////////////////

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array1 = new int[num];
// int[] array2 = new int[array1.Length / 2 + array1.Length % 2];

// for (int i = 0; i < array1.Length; i++)
// {
//   array1[i] = new Random().Next(0, 5);
//   Console.Write(array1[i] + " ");
// }

// System.Console.WriteLine();

// for (int i = 0; i < array2.Length; i++)
// {
//   array2[i] = array1[i] * array1[array1.Length - 1 - i];
//   if (i == array1.Length - 1 - i)
//   {
//     array2[i] = array1[i];
//   }
//   System.Console.Write(array2[i] + " ");
// }






/////////////////// Домашнее задание
// Задача 34

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0, 99);
//   System.Console.Write(array[i] + " ");
// }
// Console.WriteLine();

// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//   if (array[i] % 2 == 0)
//   {
//     count++;
//   }
// }
// Console.WriteLine(count);

// Задача 36

// Console.Write("Введите число: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[length];
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0, 99);
//   Console.Write(array[i] + " ");
// }
// System.Console.WriteLine();

// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   if (array[i] % 2 == 1)
//   {
//     count = count + array[i];
//   }
// }
// Console.WriteLine(count);

// Задача 38

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().NextDouble() * (0 - 99) + 99; // тут мне помог гугл
  Console.Write(array[i] + " ");
}
System.Console.WriteLine();

double max = 0;
double min = array[0]; // сначала написал min =0, но тк у нас тип double это привело к результату min=0 что не верно, поэтому минимум нужно дать array[0] чтобы далее сравнить с другими числами
for (int i = 0; i < array.Length; i++)
{
  if (array[i] > max)
  {
    max = array[i];
  }
  else if (array[i] < min)
  {
    min = array[i];
  }
}
System.Console.WriteLine(max);
System.Console.WriteLine(min);
