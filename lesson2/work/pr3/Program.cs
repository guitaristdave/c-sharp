﻿// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int rd(int num) {
	Console.Write($"Введите {num} число: ");
	return int.Parse(Console.ReadLine());
}

int num1 = rd(1);
int num2 = rd(2);

int e = num1 % num2;

Console.WriteLine($"Число {num1} " + (e == 0 ? "" : "не ") + $"крано {num2}" + (e == 0 ? "" : $" остаток: {e}"));