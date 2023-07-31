// int num = new Random().Next(10,100);
// Console.WriteLine(num);

// int num1 = num/10;
// int num2 = num%10;
// if(num1 > num2)
// {
//   Console.WriteLine(num1);
// }
// else
// {
//   Console.WriteLine(num2);
// }

// ----------------------

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int num1 = num / 100;
// int num2 = num % 10;
// int result = num1 * 10 + num2;

// Console.WriteLine("Результат: " + result);
// Console.WriteLine($"Результат: {result}");
// -----------------------

// Console.Write("Введите число1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if ((num1 == num2 * num2) || (num2 == num1 * num1))
// {
//   Console.WriteLine("Yes");
// }
// else
// {
//   Console.WriteLine("No");
// }

// ----------------------------

// Console.Write("Введите число1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// {
//   Console.WriteLine("Кратно");
// }
// else
// {
//   Console.WriteLine($"Остаток от деления {num1 % num2}");
// }

// --------------------------

// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if ((num1 % 7 == 0) && (num1 % 23 == 0))
// {
//   Console.WriteLine("Yes");
// }
// else
// {
//   Console.WriteLine("No");
// }

// ------------ HomeTask
// Задача 10 
// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int result = number / 10 % 10;
// Console.WriteLine(result);

// Задача 13
// int number = new Random().Next(10, 100000);
// Console.WriteLine(number);

// if ((number > 100) && (number < 1000))
// {
//   int result = number % 10;
//   Console.WriteLine(result);
// }
// else if ((number >= 1000) && (number < 10000))
// {
//   int result = number / 10 % 10;
//   Console.WriteLine(result);
// }
// else if (number >= 10000)
// {
//   int result = number / 100 % 10;
//   Console.WriteLine(result);
// }
// else
// {
//   Console.WriteLine("Третьей цифры нет");
// }

// Задача 15

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Вы ввели чисто: {num}");

// if ((num == 6) || (num == 7))
// {
//   Console.WriteLine("Да, этот день выходной");
// }
// else if (num > 7)
// {
//   Console.WriteLine("Такого дня недели нет");
// }
// else
// {
//   Console.WriteLine("Нет, это будний день");
// };
