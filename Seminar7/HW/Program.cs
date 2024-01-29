// // Задача 1: Задайте значения M и N. Напишите программу, 
// // которая выведет все натуральные числа в промежутке от M до N. 
// // Использовать рекурсию, не использовать циклы.

// Console.WriteLine("Введите нижнюю границу диапазона M: ");
// int numStart = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите верхнюю границу диапазона N: ");
// int numEnd = Convert.ToInt32(Console.ReadLine());

// void Numbers(int numEnd)
// {
// 	if (numEnd == numStart-1)
// 	{
// 		return;
// 	}
// 	Numbers(numEnd - 1);
// 	Console.Write($"{numEnd} ");     
// }

// Numbers(numEnd);



// // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// // Даны два неотрицательных числа m и n.

// // Решение из интернета:
// Console.WriteLine("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int akkerman(int m, int n)
// {
// 	if (m == 0)
// 	{
// 		return n + 1;
// 	}
// 	else
// 		if (n == 0)
// 	{
// 		return akkerman(m - 1, 1);
// 	}
// 	else
// 	{
// 		return akkerman(m - 1, akkerman(m, n - 1));
// 	}
// }

// Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");



// // Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// // Использовать рекурсию, не использовать циклы.

// // создание random массив до 10ти элементов
// int[] NewArray(int size_arr)
// {
// 	int[] newArray = new int[size_arr];
// 	Random rnd = new Random();
// 	for (int i = 0; i < size_arr; i++)
// 	{
// 		newArray[i] = rnd.Next(0, 10);
// 	}
// 	return newArray;
// }
// // вывод на печать массива
// void PrintArray(int[] arrayToShow)
// {
// 	for (int i = 0; i < arrayToShow.Length; i++)
// 	{
// 		Console.Write($"{arrayToShow[i]} ");
// 	}
// 	Console.WriteLine();
// }
// Console.WriteLine("Введите количество элементов в массиве: "); // запрос количества элементов
// int sizeOfArray = Convert.ToInt32(Console.ReadLine()); // преобразование в число
// int[] arrayTask3 = NewArray(sizeOfArray); // создает массив для отображения
// PrintArray(arrayTask3); // показывает созданный массив

// void ShowReversArr(int[] arrayToShow, int index)
// {
// 	if (index == 0)
// 	{
// 		return;
// 	}
// 	else
// 	{
// 		Console.Write($"{arrayToShow[index - 1]} ");
// 		ShowReversArr(arrayToShow, index - 1);
// 	}
// }

// ShowReversArr(arrayTask3, arrayTask3.Length); // показывает перевернутый массив