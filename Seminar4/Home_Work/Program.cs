// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная.


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

// // создание random массива 
// int[] NewArray(int size_arr)
// {
// 	int[] newArray = new int[size_arr];
// 	Random rnd = new Random();
// 	for (int i = 0; i < size_arr; i++)
// 	{
// 		newArray[i] = rnd.Next(100, 1000);
// 	}
// 	return newArray;
// }
// // выводим на печать созданный массив
// void PrintArray(int[] arrayToShow)
// {
// 	for (int i = 0; i < arrayToShow.Length; i++)
// 	{
// 		Console.Write($"{arrayToShow[i]} ");
// 	}
// 	Console.WriteLine();
// }
// // проверка на условия задачи
// int CountOfElementsTask2(int[] arr)
// {
// 	int count = 0;
// 	for (int i = 0; i < arr.Length; i++)
// 	{
// 		if (arr[i] % 2 == 0)
// 			count++;
// 	}
// 	return count;
// }
// // решение задачи 2
// Console.WriteLine("Введите количество элементов в массиве: "); // запрос количества элементов
// int sizeOfArray = Convert.ToInt32(Console.ReadLine()); // преобразование в число
// int[] arrayTask2 = NewArray(sizeOfArray); // создает массив для отображения
// PrintArray(arrayTask2); // показывает созданный массив
// Console.WriteLine($"Количество чётных чисел в массиве равно: {CountOfElementsTask2(arrayTask2)}");


// Задача 3:
// Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]


// создание random массива, значения от 0 до 9
int[] NewArray(int size_arr)
{
	int[] newArray = new int[size_arr];
	Random rnd = new Random();
	for (int i = 0; i < size_arr; i++)
	{
		newArray[i] = rnd.Next(0, 10);
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
Console.WriteLine("Введите количество элементов в массиве: "); // запрос количества элементов
int sizeOfArray = Convert.ToInt32(Console.ReadLine()); // преобразование в число
int[] arrayTask3 = NewArray(sizeOfArray); // создает массив для отображения
PrintArray(arrayTask3); // показывает созданный массив

for (int i = 0; i < arrayTask3.Length / 2; i++)
{
	int temp = arrayTask3[i];
	arrayTask3[i] = arrayTask3[arrayTask3.Length - (i + 1)]; // массив [-1] - поледнее значение, [-2] - предпоследнее
	arrayTask3[arrayTask3.Length - (i + 1)] = temp;
}
PrintArray(arrayTask3); // показывает созданный массив
