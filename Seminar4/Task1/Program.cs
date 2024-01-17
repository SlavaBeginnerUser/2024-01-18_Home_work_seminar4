// Задание №1     Задайте одномерный массив, заполненный случайными числами. 
// Определите количество простых чисел (делится на себя и 1) в этом массиве. 
// Примеры 
// [1 3 4 19 3] => 2 
// [4 3 4 1 9 5 21 13]  => 3

// создание random массива 
//данные от 1 до 20, размер N задается при вызове CreateArray (N)
int[] CreateArray(int size_arr) // int [] - тип возвращаемых данных, (...) - аргументы.
{
	int[] createdArray = new int[size_arr];
	Random rnd = new Random();
	for (int i = 0; i < size_arr; i++)
	{
		createdArray[i] = rnd.Next(1, 21);
	}
	return createdArray;
}

// выводим на печать созданный массив
void ShowArray(int[] arrayToShow)
{
	// foreach (int val in arrayToShow)
	// {
	// 	Console.Write($"{val} ");
	// }
	// или
	for (int i = 0; i < arrayToShow.Length; i++)
	{
		Console.Write($"{arrayToShow[i]} ");
	}
}

// определяем количество простых чисел
int CountOfPrimes(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (IsPrime(array[i]))
			count++;
	}
	return count;
}

bool IsPrime(int value) // проверка числа (простое или нет)
{
	bool res = true;
	for (int k = 2; k < value; k++)
	{
		if (value % k == 0)
			res = false;
	}
	return res;
}

// Решение задания №1  
int size = 10; // задали размер массива
int[] arrayTask1 = CreateArray(size);  // переменная для хранение массива
ShowArray(arrayTask1); // вывод созданного массива
Console.WriteLine(); // новая строка
Console.WriteLine("Количество простых чисел равно " + CountOfPrimes(arrayTask1)); // вывод ответа
