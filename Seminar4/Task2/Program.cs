// Задайте массив из N случайных целых чисел (N вводится с клавиатуры). 
// Найдите количество чисел, которые оканчиваются на 1 (%10==1) и делятся нацело на 7 (%7==0). 
// Пример [1 5 11 21 81 4 0 91 2 3] => 2

// создание random массива 
//данные от 1 до 99, размер N задается при вызове CreateArray (N)
int[] NewArray(int size_arr)
{
	int[] newArray = new int[size_arr];
	Random rnd = new Random();
	for (int i = 0; i < size_arr; i++)
	{
		newArray[i] = rnd.Next(1, 100);
	}
	return newArray;
}
// выводим на печать созданный массив
void PrintArray(int[] arrayToShow)
{
	for (int i = 0; i < arrayToShow.Length; i++)
	{
		Console.Write($"{arrayToShow[i]} ");
	}
	Console.WriteLine();
}
// проверка на остаток =1 и =7
int CountOfElementsTask2(int[] arr)
{
	int count = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] % 10 == 1 && arr[i] % 7 == 0)
			count++;
	}
	return count;
}

Console.WriteLine ("Введите количество элементов в массиве: " ); // запрос количества элементов
int sizeOfArray = Convert.ToInt32(Console.ReadLine());
int [] arrayTask2 = NewArray(sizeOfArray);
PrintArray (arrayTask2);
Console.WriteLine($"Результат: {CountOfElementsTask2(arrayTask2)}");
