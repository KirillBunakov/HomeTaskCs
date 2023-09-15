// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int startNum = 1;

// string PrintNumber(int start, int end)
// {
//   if (start == end)
//   {
//     return start.ToString();
//   }
//   return (start + " " + PrintNumber(start + 1, end));
// }

// Console.WriteLine(PrintNumber(startNum, num));

/////////////////////////////

// Console.Write("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 < num2)
// {
//   Console.WriteLine(PrintNumber(num1, num2));
// }
// else
// {
//   Console.WriteLine("Вы ввели не корректные числа");
// }

// string PrintNumber(int start, int end)
// {
//   if (start == end)
//   {
//     return start.ToString();
//   }
//   return (start + " " + PrintNumber(start + 1, end));
// }

/////////////////////////////

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumOfNum(int num)
// {
//   if (num == 00)
//   {
//     return 0;
//   }
//   return (num % 10 + SumOfNum(num / 10));
// }

// Console.WriteLine(SumOfNum(number));

/////////////////////////////

// Console.Write("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int Squad(int number1, int number2)
// {
//   if (number2 == 0)
//   {
//     return 1;
//   }
//   if (number2 == 1)
//   {
//     return number1;
//   }
//   return (number1 * Squad(number1, number2 - 1));
// }

// Console.WriteLine(Squad(num1, num2));

/////////////////////// Домашнее задание
// Задача 64
// Console.Write("Введите первое число:");
// int num = Convert.ToInt32(Console.ReadLine());

// string PrintNumber(int number)
// {
//   if (number == 1)
//   {
//     return number.ToString();
//   }
//   return (number + " " + PrintNumber(number - 1));
// }

// Console.WriteLine(PrintNumber(num));

// Задача 66
// Console.Write("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int SumOfRange(int number1, int number2)
// {
//   if (number1 > number2)
//   {
//     return 0;
//   }
//   return (number1 + SumOfRange(number1 + 1, number2));
// }

// Console.WriteLine(SumOfRange(num1, num2));

// Задача 68

// Console.Write("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int Akkerman(int m, int n)
// {
//   if (m == 0 && n <= 1000000)
//   {
//     return n + 1;
//   }
//   else if (m == 1 && n <= 1000000)
//   {
//     return n + 2;
//   }
//   else if (m == 2 && n <= 1000000)
//   {
//     return 2 * n + 3;
//   }
//   else if (m == 3 && n <= 1000000)
//   {
//     return (int)Math.Pow(2, n + 3) - 3;
//   }
//   else if (m > 3 && n <= 24)
//   {
//     return (int)Math.Pow(2, n + 3) - 3;
//   }
//   return 0;
// }

// Console.WriteLine(Akkerman(num1, num2));


