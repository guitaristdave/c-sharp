﻿using func;

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// -------------------------------------------------------------------

string num;
while ((num = Math.Abs(rw.getInt("Введите 3х значное число")).ToString()).Length != 3) rw.echo("-- Попробуйте снова --");
rw.echo($"2 цифра - {num[1]}");

// -------------------------------------------------------------------