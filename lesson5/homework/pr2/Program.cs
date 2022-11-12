using func;

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// -------------------------------------------------------------------

int[] numbersArray = ar.init(rw.getInt("Введите кол-во эл-ов", true), -99, 99);
int summ = 0;
for (int i = 1; i < numbersArray.Length; i += 2) summ += numbersArray[i];

ar.echoArrayInt(numbersArray);
rw.echo($"Сумма эл-ов на нечет. позициях: {summ}");

// -------------------------------------------------------------------