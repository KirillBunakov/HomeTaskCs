// Задача 17

// Console.WriteLine("Введите координату x: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//   Console.WriteLine("Точка лежит на 1 четверти");
// }
// else if (x < 0 && y > 0)
// {
//   Console.WriteLine("Точка лежит на 2 четверти");
// }
// else if (x < 0 && y < 0)
// {
//   Console.WriteLine("Точка лежит на 3 четверти");
// }
// else if (x > 0 && y < 0)
// {
//   Console.WriteLine("Точка лежит на 4 четверти");
// }
// else
// {
//   Console.WriteLine("точка лежит на оси координат");
// }

// Задача 17 - наоборот

// Console.WriteLine("Введите номер плоскости: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1)
// {
//   Console.WriteLine("x > 0 , y > 0");
// }
// else if (num == 2)
// {
//   Console.WriteLine("x < 0 , y > 0");
// }
// else if (num == 3)
// {
//   Console.WriteLine("x < 0 , y < 0");
// }
// else if (num == 4)
// {
//   Console.WriteLine("x > 0 , y < 0");
// }
// else if (num == 0 | num > 4)
// {
//   Console.WriteLine("точка вне четверти");
// }


// Задача 21
// Console.WriteLine("Введите число: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double num = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
// Console.WriteLine(num);

// Таблица квадратов чисел
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//   Console.WriteLine(Math.Pow(i, 2));
// }


// Домашнее задание
// Задача 19
// Решение через "массив" рассказанный в лекции
// Console.Write("Введите пятизначное число: ");
// string x = Console.ReadLine();

// if ((x[0] == x[4]) && (x[1] == x[3]))
// {
//   Console.WriteLine($"число {x} является палидромом!");
// }
// else
// {
//   Console.WriteLine($"число {x} не является палидромом");
// }

// Задача 21
// Console.Write("Введите число: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)));

// Задача 23
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= num; i++)
// {
//   Console.WriteLine($"Число {i} в кубе равно {(Math.Pow(i, 3))}");
// }


