﻿using func;

// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// -------------------------------------------------------------------

var rnd = new Random();
int number = rnd.Next(100, 1000);
int.TryParse($"{number / 100}{number % 10}", out int result);

rw.echo($"base - {number}; result - {result};");

// -------------------------------------------------------------------