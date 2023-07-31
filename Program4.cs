// Семинар 4

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetSumNum(int number)
// {
//   int result = 0;
//   int count = 1;
//   while (num >= count)
//   {
//     result = result + count;
//     count++;
//   }

//   return result;
// }
// Console.WriteLine(GetSumNum(num));

// Задача 26

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int CountOfNumbers(int num)
// {
//   int count = 0;
//   while (num > 0)
//   {
//     count++;
//     num = num / 10;
//   }

//   return count;
// }

// int result = CountOfNumbers(num);
// Console.WriteLine(result);

// Задача 28
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetMult(int x)
// {
//   int mult = 1;
//   for (int i = 1; i <= num; i++)
//   {
//     mult = mult * i;
//   }
//   return mult;
// }

// int result = GetMult(num);
// Console.WriteLine(result);

// Задача 30
// Console.Write("Введите количество элементов в массиве: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[num];
// void GetArray()
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = new Random().Next(0, 2);
//     Console.Write(array[i] + " ");
//   }
// }
// GetArray();

/////// Домашнее задание
// Задача 25
// Console.Write("Введите число1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int Mult(int x, int y)
// {
//   return x * y;
// }
// Console.WriteLine(Mult(num1, num2));

// Задача 27
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int Length(int num)
// {
//   int index = 0;
//   while (num > 0)
//   {
//     num = num / 10;
//     index++;
//   }
//   return index;
// }
// Console.WriteLine("длинна числа " + Length(num));
// int length = Length(num);

// int Sum(int a, int b)
// {
//   int sum = 0;
//   for (int i = 1; i <= b; i++)
//   {
//     sum = sum + a % 10;
//     a = a / 10;
//     Console.WriteLine(sum);
//   }
//   return sum;
// }
// Console.WriteLine(Sum(num, length));

// Задача 29

// Console.Write("Введите количество элементов в массиве: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[num];
// void GetArray()
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = new Random().Next(0, 9999);  // если не задать диапазон то выдаются 9ти значные цифры
//     Console.Write(array[i] + " ");
//   }
// }
// GetArray();




