using func;

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// -------------------------------------------------------------------

(int min, int max, int diff) search(int[] arr) {
	int min = 0, max = 0;
	foreach (var item in arr) {
		if (item < min) min = item;
		if (item > max) max = item;
	}
	return (min, max, max - min);
}

int[] numbersArray = ar.init(4, -99, 99);
(int min, int max, int diff) = search(numbersArray);

ar.echoArrayInt(numbersArray);
rw.echo($"Разница между максимальным ({max}) и минимальным ({min}) эл-ами массива: {diff}");

// -------------------------------------------------------------------