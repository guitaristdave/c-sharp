﻿using func;

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// -------------------------------------------------------------------

int num = rw.getInt();
int count = Math.Abs(num).ToString().Length;
rw.echo($"Количество цифр в числе {num} = {count}");

// -------------------------------------------------------------------