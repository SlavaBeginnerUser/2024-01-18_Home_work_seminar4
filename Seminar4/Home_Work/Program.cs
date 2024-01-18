// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная.

// определяем количество разрядов digitNumber в введенном числе inputNumber
// Console.WriteLine("Введите целое число: ");
// int inputNumber = Convert.ToInt32(Console.ReadLine());
// int digitNumber = 0;
// while (inputNumber != 0)
// {
// 	inputNumber = inputNumber / 10;
// 	digitNumber++;
// }
// Console.Write($"Количество разрядов равно {digitNumber} ");


// // Задача1 - решение
// int sumOfDigits = 0;
// while (true) // бесконечный запуск программы до команды break
// {
// Console.WriteLine("Введите целое число или'q'для выхода: ");
// string inputstring= Convert.ToString(Console.ReadLine()); // преобразование в "строку"
// if(inputstring == "q")
// 	break;
// int inputNumber = Convert.ToInt32(inputstring); // преобразование в число
// sumOfDigits = 0;
// while (inputNumber != 0)
// {
// 	sumOfDigits = sumOfDigits + inputNumber % 10;
// 	inputNumber = inputNumber / 10;
// }
// if(sumOfDigits % 2 == 0)
// {
// 		Console.Write($"Сумма цифр четная и равна {sumOfDigits} "); 
// 		break;
// }
// }


// Задача 2: 
//Задайте массив заполненный случайными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

// создание random массива 
int[] NewArray(int size_arr)
{
	int[] newArray = new int[size_arr];
	Random rnd = new Random();
	for (int i = 0; i < size_arr; i++)
	{
		newArray[i] = rnd.Next(100, 1000);
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
// проверка на условия задачи
int CountOfElementsTask2(int[] arr)
{
	int count = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] % 2 == 0)
			count++;
	}
	return count;
}
// решение задачи
Console.WriteLine("Введите количество элементов в массиве: "); // запрос количества элементов
int sizeOfArray = Convert.ToInt32(Console.ReadLine()); // преобразование в число
int[] arrayTask2 = NewArray(sizeOfArray); // создает массив для отображения
PrintArray(arrayTask2); // показывает созданный массив
Console.WriteLine($"Количество чётных чисел в массиве равно: {CountOfElementsTask2(arrayTask2)}");