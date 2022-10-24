﻿using func;

// Задача 18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).
//   2  |  1
// -----------
//   3  |  4

// -------------------------------------------------------------------

(string x, string y) helpQtr(int qtr) {
	switch (qtr) {
		case 0: return ("= 0", "= 0");
		case 1: return ("> 0", "> 0");
		case 2: return ("< 0", "> 0");
		case 3: return ("< 0", "< 0");
		case 4: return ("> 0", "< 0");
        default: return ("ERROR", "ERROR");
	}
}

int qtr = 0;
bool res = false;
while (res != true) {
    qtr = rw.getInt("Введите номер четверти");
    if (qtr < 0 || qtr > 4) rw.error("Выход из диапозона", "Повторите ввод");
    else res = true;
}

var (x, y) = helpQtr(qtr);

rw.echo($"В четверти {qtr} находятся координаты (x {x}, y {y})");

// -------------------------------------------------------------------
