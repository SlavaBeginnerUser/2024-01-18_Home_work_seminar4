// // разные типы значений
// int value = 100;
// Console.WriteLine(value);
// double d = 5.55;
// char c = '!';
// bool b = true;
// Console.WriteLine(d);
// Console.WriteLine(c);
// Console.WriteLine(b);



// // операции с разными типами данных
// int i1 = 5;
// int i2 = 6;
// int sum = i1 + i2;
// Console.WriteLine(sum);

// long l1 = 6;
// long sum2 = i1 + l1;
// Console.WriteLine(sum2);

// double d1 = 5.5;
// double sum3 = d1 + i1;

// int product1 = i1 * i2;
// long product2 = l1 * i1;
// double product3 = i1 * d1;
// Console.WriteLine(product1);
// Console.WriteLine(product2);
// Console.WriteLine(product3);

// int quotient = i1 / i2;
// Console.WriteLine(quotient);

// d1 = 6;
// double quotient2 = i1 / d1;
// Console.WriteLine(quotient2);



// // поиск MAX
// int a = 6;
// int b = 7;
// int c = 9;
// int d = 4;
// int e = 10;
// int max = a;
// if (b > max)
// {
// 	max = b;
// }
// if (c > max)
// {
// 	max = c;
// }
// if (d > max)
// {
// 	max = d;
// }
// if (e > max)
// {
// 	max = e;
// }
// Console.WriteLine(max);


// // вывод через цикл значений от 1 до 100
// int n = 100;
// int i = 1;
// while (i <= n)
// {
// 	//Console.WriteLine(i);
// 	Console.Write(i);
// 	Console.Write(' ');
// 	i = i + 1;
// }



// // вывод знач массива по элементно
// // int[] arr = new int[5];
// // arr[0] = 5;
// // arr[1] = 7;
// // arr[2] = 5;
// // arr[3] = 4;
// // arr[4] = 3;
// int[] arr = new int[5] { 1, 2, 3, 4, 5 }; // короткий вар задания массива
// // int[] arr = { 1, 2, 3, 4, 5 }; // или самый короткий
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);



// // задаем массив на 10 циклом от 1 до 10
// int n = 10;
// int[] arr = new int[n];
// int i = 0;

// //while (i < n) или 
// while (i < arr.Length)
// {
// 	arr[i] = i + 1;
// 	Console.Write($"{arr[i]} ");
// 	i = i + 1;
// }



// //массив на 10, вывод четных
// int n = 10;
// int[] array = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 5 };
// int i = 0;

// while (i < n)
// {
// 	if (array[i] % 2 == 0)
// 	{
// 		Console.Write($"{array[i]} ");
// 	}
// 	i = i + 1;
// }



// //массив, поиск максимального
// int n = 5;
// int[] array = { 2, 10, 7, 3, 9 };
// int i = 0;
// int max = array[0];

// while (i < n)
// {
// 	if (array[i] > max)
// 	{
// 		max = array[i];
// 	}
// 	i = i + 1;
// }
// Console.WriteLine(max);



// // функция для вычисления формулы: a*b/(c+d)
// double CalculateFormula(int a, int b, int c, int d)
// {
// 	double numenator = a * b;
// 	int denomenator = c + d;
// 	double result = numenator / denomenator;
// 	return result;
// }
// double result = CalculateFormula(1, 2, 3, 4);
// Console.WriteLine(result);



// // функция квадрата числа / вывод квадратов числа от 1 до N (N = 5, 10, 15) 
// void PrintSquares(int limit)
// {
// 	int i = 1;
// 	while (i <= limit)
// 	{
// 		Console.Write($"{i * i} ");
// 		i++;
// 	}
// }
// PrintSquares(5);
// Console.WriteLine();
// PrintSquares(10);
// Console.WriteLine();
// PrintSquares(15);



// //Функция для замены в массиве четных элементов на 0
// void ZeroEvenElements(int[] arr)
// {
// 	for (int i = 0; i < arr.Length; i++)
// 	{
// 		if (arr[i] % 2 == 0)
// 		{
// 			arr[i] = 0;
// 		}
// 	}
// }
// void PrintArray(int[] arr)
// {
// 	foreach (int e in arr)
// 	{
// 		Console.Write($"{e} ");
// 	}
// }

// int[] array = { 1, 2, 3, 4, 5 };
// ZeroEvenElements(array);
// PrintArray(array);



// // Напишите программу, которая на вход принимает два целых числа 
// //и проверяет, является ли первое число квадратом второго.
// int first_number = 25;
// int second_number = 4;

// if(second_number * second_number == first_number)
// {
// 	Console.Write("first number is a quoter of second number");
// }
// else
// {
// 	Console.Write("first number is not a quoter of second number");
// }



//Напишите программу, которая на вход принимает
//целое число N, а на выходе показывает все целые
//числа в промежутке от -N до N.

// int num = 5;
// int num2 = num * (-1);

// while (num2 <= num)
// {
// 	Console.Write($"{num2} ");
// 	num2++;
// 	// num2 - счетчик, увеличивается на +1
// }



//Напишите программу, которая принимает на вход
//трёхзначное целое число и на выходе показывает сумму
//первой и последней цифры этого числа.

// int num = 425;
// if (num >= 100 && num <= 999)
// && означает (и) - выполняются оба условия
// {
// 	int num1 = num / 100; // получили первое число
// 	int num2 = num % 10; // в результате 42 и 5 (% оставляет остаток от деления 5)
// 	int sum = num1 + num2;
// 	Console.Write($"сумма первой и последней цифр числа {num} равна {sum}");
// }
// else
// { 
// 	Console.Write($"число {num} не является трехзначным"); 
// }



// // ДЗ 1) сравнение двух чисел
// int firstNumber = 3;
// int secondNumber = 3;
// if (secondNumber == firstNumber)
// {
// 	Console.Write($"Введенные числа равны {firstNumber}");
// }
// else
// {
// 	if (secondNumber > firstNumber)
// 	{
// 		Console.Write($"Первое число {firstNumber} меньше чем второе число {secondNumber}");
// 	}
// 	else
// 	{
// 		Console.Write($"Первое число {firstNumber} больше чем второе число {secondNumber}");
// 	}
// }



// // ДЗ2 Максимальное из трех чисел
// int a = 5;
// int b = 6;
// int c = 7;
// int max;
// if (a > b)
// {
// 	max = a;
// 	if (c > max)
// 	{
// 	max = c;
// 	}
// }
// else
// {
// 	max = b;
// 	if (c > max)
// 	{
// 	max = c;
// 	}
// }
// 	Console.Write($"{max}");



// // ДЗ 3 проверка числа на чётность
// int number = 301;
// if (number % 2 > 0)
// {
// 	Console.Write($"Число {number} нечётное");
// }
// else
// {
// 	Console.Write($"Число {number} чётное");
// }



// //ДЗ 4 вывод всех четных чисел от 1 до N
// int number = 21;
// int i = 2;
// while (i <= number)
// {
// 	Console.Write(i);
// 	Console.Write("\t");
// 	i = i + 2;
// }



// //Задание 1
// //Напишите программу, которая принимает на вход трёхзначное число 
// //и удаляет вторую цифру этого числа.

// // Пример
// // a = 425 => 45;
// // a = 891 => 81;

// Console.WriteLine("Введите трехзначное число: ");
// string? num = Console.ReadLine();
// int num1 = Convert.ToInt32 (num);
// if (num1 >= 100 && num1 <= 999)
// {
// 	int FirstNum = num1 / 100; // получили первое число
// 	int TherdNum = num1 % 10; // в результате 42 и 5 ("%" оставляет остаток от деления 5)
// 	int ResultNum = FirstNum * 10 + TherdNum;
// 	Console.Write($"число, состоящее из первой и последней цифр числа {num1} является {ResultNum}");
// }
// else 
// {
// 	Console.Write($"число {num} не является трехзначным");
// }



// //Задание 2
// //Напишите программу, которая принимает на вход трёхзначное число 
// //  и возводит вторую цифру этого числа в степень, равную третьей цифре
// //Пример:
// //487 => 8^7 = 2 097 152

// // вариант1 через цикл
// int numTask2 = 123;
// int secondDigit = numTask2 / 10 % 10; // получили второе число
// int thirdDigit = numTask2 % 10; // получили третье число
// int ind = 0;
// int multy = 1;
// while (ind < thirdDigit)
// {
// 	multy *= secondDigit; // multy = multy * secondDigit
// 	ind++;
// }
// Console.Write($"вторая цифра в степени третьей цифры числа {numTask2} равна {multy}");

// // вариант2 с функцией Math.Pow
// int numTask2 = 123;
// int secondDigit = numTask2 / 10 % 10; // получили второе число
// int thirdDigit = numTask2 % 10; // получили третье число
// double resultTask2 = Math.Pow (secondDigit, thirdDigit);
// Console.Write($"вторая цифра в степени третьей цифры числа {numTask2} равна {resultTask2}");



// //Задание 3
// //Напишите программу, которая принимает на вход два числа
// // и выводит является ли второе число кратным первому.
// //Если второе число некратно первому, то программа выводит остаток от деления.
// //14, 5 => нет, 4 
// //16, 8 => да

// int num1 = 14;
// int num2 = 5;
// int division = num1 % num2;
// if(division > 0)
// 	Console.Write($"нет, {division}");
// else
// 	Console.Write($"ДА");



// //Задача4
// //Напишите программу, которая выводит третью с начала цифру заданного числа,
// // или сообщает об её отсутствии.
// //Пример
// //456 -> 6
// //7812 -> 1

// int numTask4 = 1234567891;
// if (numTask4 > 99)
// {
// 	while (numTask4 > 999)
// 	{
// 		numTask4 = numTask4 / 10;
// 	}
// 	int thirdDigit = numTask4 % 10;
// 	Console.Write($"третья цифра равна {thirdDigit}");
// }
// else
// {
// 	Console.Write($"третьей цифры нет");
// }



// // Задача1
// // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// // a=50 -> нет
// // a=7 -> нет
// // a=322 -> да

// Console.WriteLine("Введите число для проверки кратности на 7 и 23: ");
// string? num = Console.ReadLine();
// int num1 = Convert.ToInt32 (num);
// int test1 = num1 % 7;
// int test2 = num1 % 23;
// if (test1 > 0 || test2 > 0)
// 	Console.Write($"нет");
// else
// 	Console.Write($"да");



// //Задача2
// //Напишите программу, которая принимает на вход координаты точки (X и Y), причем 
// // X и Y не равны 0, и выдает номер координатной четверти.

// Console.WriteLine("Введите число X не равное 0: ");
// string? num1 = Console.ReadLine();
// int numX = Convert.ToInt32 (num1);
// Console.WriteLine("Введите число Y не равное 0: ");
// string? num2 = Console.ReadLine();
// int numY = Convert.ToInt32(num2);
// if (numX>0 && numY>0)
// 	Console.WriteLine("Координатная четверть №1 ");
// if (numX < 0 && numY > 0)
// 	Console.WriteLine("Координатная четверть №2 ");
// if (numX < 0 && numY < 0)
// 	Console.WriteLine("Координатная четверть №3 ");
// if (numX > 0 && numY < 0)
// 	Console.WriteLine("Координатная четверть №4 ");
// else
// 	Console.WriteLine("Ошибка! Вы ввели нулевое значение! ");



// // Задача3
// // Напишите программу, которая принимает на вход целое число из отрезка [10:99]
// // и показывает наибольшую цифру числа.

// Console.WriteLine("Введите число в промежутке значений 10-99 включительно: ");
// string? num1 = Console.ReadLine();
// int numX = Convert.ToInt32 (num1);
// if (numX >= 10 && numX <= 99)
// {
// 	int digit1 = numX / 10; //первая цифра
// 	int digit2 = numX % 10; //вторая цифра
// 	if(digit1 > digit2)
// 		Console.WriteLine($"Наибольшая цифра: {digit1} ");
// 	else
// 		Console.WriteLine($"Наибольшая цифра: {digit2} ");
// }
// else
// 	Console.WriteLine("Ошибка! Вы ввели значение вне заданного диапазона! ");



// //Задача4
// //Напишите программу, которая на вход принимает натуральное число N, 
// //а на выходе показывает его цифры через запятую.

// Console.WriteLine("Введите натуральное число: ");
// string? num1 = Console.ReadLine();
// int numN = Convert.ToInt32(num1);
// while (numN > 0)
// {
// 	int ClassNum = numN % 10;
// 	Console.Write(ClassNum);
// 	Console.Write(", ");
// 	numN = numN / 10;
// }



// // Задача1
// //Задайте массив. Напишите программу, которая определяет, 
// // присутствует ли заданное число в массиве. Программа должна выдать ответ: Да / Нет.

// int num = 5;
// int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// bool flag = false;

// for (int i = 0; i < array.Length; i++)
// {
// 	if (num == array[i])
// 	{
// 		flag = true;
// 	}
// }
// if(flag)
// {
// 	Console.WriteLine("Да");
// }
// else
// {
// 	Console.WriteLine("Нет");
// }



// //Задача2
// //Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
// //Замените отрицательные элементы на положительные, а положительные на отрицательные.

// int[] array = new int[] { -1, 2, 3, -4, 5, 6, -7, 8, 9, -10 };
// foreach (int item in array)
// Console.Write($"{item * -1} ");



// //Задача3
// //Найдите произведения пар чисел в одномерном массиве.
// //Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// //Результат запишите в новый массив. (если есть, средний элемент поставить в конец)

// // Пример
// [1 3 2 4 2 3] => [3 6 8]
//[2 3 1 7 5 6 3] => [6 18 5 7] (элемент 7 не имеет пары)

// int[] array = new int[] { -1, 2, 3, -4, 5 };
// int[] printArr = new int[array.Length / 2];

// for (int i = 0; i < array.Length / 2; i++)
// {
// 	printArr[i] = array[i] * array[array.Length - 1 - i];
// }
// for (int i = 0; i < printArr.Length; i++)
// {
// 	Console.Write($"{printArr[i]} ");
// }
// if(array.Length % 2 > 0)
// {
// 	Console.Write($"{array[array.Length/2]} ");
// }



// // Домашнее задание №1
// // Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, 
// // значения которых лежат в отрезке [10,90].

// int[] array = new int[] { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 }; // Создание массива
// int summ = 0;
// for (int i = 0; i < array.Length; i++)
// {
// 	if (array[i] >= 10 && array[i] <= 90)
// 	{
// 		summ = summ + 1;
// 	}
// }
// Console.Write(summ);



// //Домашнее задание №2
// //Задайте массив на 10 целых чисел. Напишите программу, которая определяет 
// //количество чётных чисел в массиве.

// int[] array = new int[] { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 }; // Создание массива
// int summ = 0;
// for (int i = 0; i < array.Length; i++)
// {
// 	if (array[i] % 2 == 0)
// 	{
// 		summ = summ + 1;
// 	}
// }
// Console.Write(summ);



// //Домашнее задание №3
// //Задайте массив из вещественных чисел с ненулевой дробной частью. 
// //Найдите разницу между максимальным и минимальным элементов массива.

// double[] array = new double[] { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 }; // Создание массива
// double max = array[0];
// double min = array[0];

// for (int i = 0; i < array.Length; i++)
// {
// 	if (array[i] > max)
// 	{
// 		max = array[i];
// 	}
// 	if (array[i] < min)
// 	{
// 		min = array[i];
// 	}
// }
// Console.Write(max - min);



// // определяем количество разрядов digitNumber в введенном числе inputNumber
// Console.WriteLine("Введите целое число: ");
// int inputNumber = Convert.ToInt32(Console.ReadLine());
// int digitNumber = 0;
// while (inputNumber != 0)
// {
// 	inputNumber = inputNumber / 10;
// 	digitNumber++;
// }
// Console.Write($"Количество разрядов равно {digitNumber} ");



// // Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// // Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная.

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



// // Задача 2: 
// // Задайте массив заполненный случайными трёхзначными числами.
// // Напишите программу, которая покажет количество чётных чисел в массиве.

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



// // Задача 3:
// // Напишите программу, которая перевернёт одномерный массив
// // (первый элемент станет последним, второй – предпоследним и т.д.)
// // [1 3 5 6 7 8] => [8 7 6 5 3 1]

// // создание random массива, значения от 0 до 9
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
// // выводим на печать созданный массив
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

// for (int i = 0; i < arrayTask3.Length / 2; i++)
// {
// 	int temp = arrayTask3[i];
// 	arrayTask3[i] = arrayTask3[arrayTask3.Length - (i + 1)]; // массив [-1] - поледнее значение, [-2] - предпоследнее
// 	arrayTask3[arrayTask3.Length - (i + 1)] = temp;
// }
// PrintArray(arrayTask3); // показывает созданный массив



// // двумерный массив
// int[,] matrix = new int[3, 5];  // задали массив из 3х строк и 5ти столбцов
// 								// заполнение массива случайными числами от 1 до 10
// Random rnd = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++) // построчно
// {
// 	for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам
// 	{
// 		matrix[i, j] = rnd.Next(1, 11);
// 	}
// }
// // выод созданного массива
// Console.WriteLine("Созданнный массив:");
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// 	for (int j = 0; j < matrix.GetLength(1); j++)
// 	{
// 		Console.Write($"{matrix[i, j]} "); // интерполяция строк
// 	}
// 	Console.WriteLine();
// }



// // функция по созданию двумерного массива со значениями от 1 до 10
// int[,] CreateMatrix(int rowCount, int colunsCount)
// {
// 	int[,] matrix = new int[rowCount, colunsCount];  // задали массив из 3х строк и 5ти столбцов
// 	Random rnd = new Random();
// 	for (int i = 0; i < matrix.GetLength(0); i++) // построчно
// 	{
// 		for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам
// 		{
// 			matrix[i, j] = rnd.Next(1, 11);
// 		}
// 	}
// 	return matrix;
// }

// // функция по выведению массива, созданного функцией CreateMatrix
// void ShowMatrix(int[,] matrix)
// {
// 	Console.WriteLine("Созданнный массив:");
// 	for (int i = 0; i < matrix.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < matrix.GetLength(1); j++)
// 		{
// 			Console.Write($"{matrix[i, j]} ");
// 		}
// 		Console.WriteLine();
// 	}
// }

// // создание массива 4х5 с помощью функции CreateMatrix 
// int[,] matrix = CreateMatrix(4, 5);
// ShowMatrix(matrix); // вывод массива с помощью функции ShowMatrix 



// // Задача
// // Назовём число «интересным» если его сумма цифр чётная
// // Создать двумерный массив, состоящий из целых чисел. 
// // Вывести на экран «интересные» элементы массива

// // функция по созданию двумерного массива со значениями от 1 до 999
// int[,] CreateMatrix(int rowCount, int colunsCount)
// {
// 	int[,] matrix = new int[rowCount, colunsCount];  // задали массив из 3х строк и 5ти столбцов
// 	Random rnd = new Random();
// 	for (int i = 0; i < matrix.GetLength(0); i++) // построчно
// 	{
// 		for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам
// 		{
// 			matrix[i, j] = rnd.Next(1, 1000);
// 		}
// 	}
// 	return matrix;
// }
// int[,] matrix = CreateMatrix(3, 4); // создание массива 3х4 с помощью функции CreateMatrix 
// ShowMatrix(matrix); // вывод массива с помощью функции ShowMatrix
// foreach (int e in matrix)
// {
// 	if (IsInteresting(e) == true) // проверка интересное число или нет
// 	{
// 		Console.Write("Интересное число: ");
// 		Console.WriteLine(e);  // вывод результата проверки
// 	}
// }
// // функция по выведению массива, созданного функцией CreateMatrix
// void ShowMatrix(int[,] matrix)
// {
// 	Console.WriteLine("Созданнный массив:");
// 	for (int i = 0; i < matrix.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < matrix.GetLength(1); j++)
// 		{
// 			Console.Write($"{matrix[i, j]} ");
// 		}
// 		Console.WriteLine();
// 	}
// }
// // проверка на числа "интересность" (сумма цивр числа четная)
// bool IsInteresting(int value)
// {
// 	int sumOfDigits = GetSumOfDigits(value);    // сумма цифр в числе
// 	if (sumOfDigits % 2 == 0)
// 	{
// 		return true;
// 	}
// 	else
// 	{
// 		return false;
// 	}
// }
// // функция по подсчету суммы цифр в числе
// int GetSumOfDigits(int value)
// {
// 	int sum = 0;
// 	while (value > 0)
// 	{
// 		sum = sum + value % 10;
// 		value = value / 10;
// 	}
// 	return sum;
// }



// // Задача
// // Считать с консоли строку, состоящую из цифр и латинских букв.
// // Сформировать новую строку, состоящую из букв исходной строки.


// string GetLettersFromString(string s)
// {
// 	string letters = "";     // Ввод строки 
// 	foreach (char e in s)    // Проход по элементам строки
// 	{
// 		if (char.IsAsciiLetter(e) == true)   // является ли проверяемый элемент буквой
// 		{
// 			letters = letters + e;   // дописываем подходящий элемент к новой строке 
// 		}
// 	}
// 	return letters;
// }

// string str = Console.ReadLine();    // ввод строки
// string result = GetLettersFromString(str);  // вызов функции GetLettersFromString
// Console.WriteLine(result);



// // Задайте двумерный массив. 
// // Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// // Пример 
// // 2 3 4 3    			4 3 16 3
// // 4 3 4 1    => 		4 3 4  1
// // 2 9 5 4 				4 9 25 4

// // int [,] matrix = new int [rows,collums]; - создание 2х мерного массива
// // array.Length - посчитает все подряд элементы в массиве
// // array.GetLength(0) - посчитает все элементы в строке
// // array.GetLength(1) - посчитает все элементы в столбце

// int[,] CreateArray2D(int rows, int collums)     // функция по созданию 2D массива
// {
// 	int[,] array1 = new int[rows, collums];
// 	Random rnd = new Random();
// 	for (int i = 0; i < rows; i++)
// 		for (int j = 0; j < collums; j++)
// 			array1[i, j] = rnd.Next(0, 10);     // заполнение случайными значениями от 0 до 9
// 	return array1;
// }

// void ShowArray2D(int[,] matrix)                 // функция по выводу 2D массива
// {
// 	for (int i = 0; i < matrix.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < matrix.GetLength(1); j++)
// 			Console.Write($"{matrix[i, j]} ");
// 		Console.WriteLine();
// 	}
// 	Console.WriteLine();
// }

// int[,] SquareElem(int[,] firstArray)        // метод решенияя условия задачи
// {
// 	for (int i = 0; i < firstArray.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < firstArray.GetLength(1); j++)
// 		{
// 			if (i % 2 == 0 && j % 2 == 0)
// 			{
// 				firstArray[i, j] *= firstArray[i, j];   // возведение в квадрат
// 														// *= firstArray[i, j] соответствует firstArray[i, j] * firstArray[i, j]
// 			}
// 		}
// 	}
// 	return firstArray;
// }

// int[,] arrayTask1 = CreateArray2D(4, 5);    // задаем размер массива 4 строки х 5 столбцов
// ShowArray2D(arrayTask1);
// int[,] resultArrayTask1 = SquareElem(arrayTask1);	// создали массив который заполняется результатом 
// // после использования функции SquareElem(arrayTask1)
// Console.WriteLine("Результат: ");
// ShowArray2D(resultArrayTask1);



// // Задайте двумерный массив. 
// // Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// // Пример 
// // 2 3 4 3    
// // 4 3 4 1    =>  2 + 3 + 5 = 10 
// // 2 9 5 4

// int[,] CreateArray2D(int rows, int collums)     // функция по созданию 2D массива
// {
// 	int[,] array2 = new int[rows, collums];
// 	Random rnd = new Random();
// 	for (int i = 0; i < rows; i++)
// 		for (int j = 0; j < collums; j++)
// 			array2[i, j] = rnd.Next(0, 10);     // заполнение случайными значениями от 0 до 9
// 	return array2;
// }

// void ShowArray2D(int[,] matrix)                 // функция по выводу 2D массива
// {
// 	for (int i = 0; i < matrix.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < matrix.GetLength(1); j++)
// 			Console.Write($"{matrix[i, j]} ");
// 		Console.WriteLine();
// 	}
// 	Console.WriteLine();
// }

// int MainDiagSum(int[,] array2)          // функция по решению задачи 1й метод
// {
// 	int mainDiagSum = 0;
// 	for (int i = 0; i < array2.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array2.GetLength(1); j++)
// 		{
// 			if (i == j)
// 				mainDiagSum = mainDiagSum + array2[i, j];
// 		}
// 	}
// 	return mainDiagSum;
// }

// int MainDiagSum2(int[,] array2)         // функция по решению задачи 2й метод
// {
// 	int mainDiagSum = 0;
// 	if (array2.GetLength(0) <= array2.GetLength(1))
// 	{
// 		for (int i = 0; i < array2.GetLength(0); i++)
// 		{
// 			mainDiagSum += array2[i, i]; // += array2[i,i] тождественно = mainDiagSum + array2[i,i]
// 		}
// 	}
// 	else
// 	{
// 		for (int i = 0; i < array2.GetLength(1); i++)
// 		{
// 			mainDiagSum += array2[i, i];
// 		}
// 	}
// 	return mainDiagSum;
// }

// int[,] arrayTask2 = CreateArray2D(4, 3);    // задаем размер массива (4 строки и 3 столбца)
// ShowArray2D(arrayTask2);                    // показываем массив
// int sumMainDiag = MainDiagSum(arrayTask2);  // решение 1м методом
// int sum2MainDiag = MainDiagSum2(arrayTask2);// решение 2м методом
// Console.WriteLine($"Результат 1-го метода: {sumMainDiag} ");
// Console.WriteLine($"Результат 2-го метода: {sum2MainDiag} ");



// // Задайте двумерный массив.
// // Сформируйте новый одномерный массив, состоящий из 
// // средних арифметических значений по строкам двумерного массива. 
// // Пример 
// // 2 3 4 3   
// // 4 3 4 1    =>  [3 3 5] 
// // 2 9 5 4

// int[,] CreateArray2D(int rows, int collums)     // функция по созданию 2D массива
// {
// 	int[,] array3 = new int[rows, collums];
// 	Random rnd = new Random();
// 	for (int i = 0; i < rows; i++)
// 		for (int j = 0; j < collums; j++)
// 			array3[i, j] = rnd.Next(0, 10);     // заполнение случайными значениями от 0 до 9
// 	return array3;
// }

// void ShowArray2D(int[,] matrix)                 // функция по выводу 2D массива
// {
// 	for (int i = 0; i < matrix.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < matrix.GetLength(1); j++)
// 			Console.Write($"{matrix[i, j]} ");
// 		Console.WriteLine();
// 	}
// 	Console.WriteLine();
// }

// void PrintArray(double[] massiv)       // функция по выводу 1D массива с веществ знач
// {
// 	for (int i = 0; i < massiv.Length; i++)
// 	{
// 		Console.Write($"{massiv[i]} ");
// 		Console.WriteLine();
// 	}
// 	Console.WriteLine();
// }

// double[] AvgArray(int[,] array3)    // функция решения для задачи
// {
// 	double[] avgMeans = new double[array3.GetLength(0)];    // одномерный массив с вещественным типом данных
// 	for (int i = 0; i < array3.GetLongLength(0); i++)
// 	{
// 		double currentSum = 0;
// 		for (int j = 0; j < array3.GetLongLength(1); j++)
// 		{
// 			currentSum = currentSum + array3[i, j];
// 		}
// 		currentSum = currentSum / array3.GetLength(1);
// 		avgMeans[i] = currentSum;
// 	}
// 	return avgMeans;
// }

// int[,] arrayTask3 = CreateArray2D(4, 3);    // задаем размер массива (4 строки и 3 столбца)
// ShowArray2D(arrayTask3);                    // показываем массив
// double[] avgMeansArr = AvgArray(arrayTask3);
// Console.WriteLine("Результат: ");
// PrintArray(avgMeansArr);        // вывод через функцию
// 								// или вывод через foreach:
// foreach (double val in avgMeansArr)
// {
// 	Console.Write(Math.Round(val, 3) + " "); // округление до 3го знака после запятой
// 	Console.WriteLine();
// }



// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента или же указание, 
// // что такого элемента нет: "Позиция по рядам выходит за пределы массива" или
// // "Позиция по колонкам выходит за пределы массива"
// // Позиции в массиве считать от единицы.

// // В коде, начальные условия:
// // int[,] numbers = new int[,] {
// // 	{1, 2, 3, 4},
// // 	{5, 6, 7, 8},
// // 	{9, 10, 11, 12}
// // };

// // int x = 2;
// // int y = 2;
// // Выводится: 6

// int[,] numbers = new int[,]
// {
// 	{1, 2, 3, 4},
// 	{5, 6, 7, 8},
// 	{9, 10, 11, 12}
// };

// int x = 2;
// int y = 2;

// int i = x - 1;
// int j = y - 1;

// if (i >= numbers.GetLength(0))
// {
// 	Console.Write("Позиция по рядам выходит за пределы массива");
// }
// else
// {
// 	if (j >= numbers.GetLength(1))
// 	{
// 		Console.Write("Позиция по колонкам выходит за пределы массива");
// 	}
// 	else
// 	{	
// 		Console.Write($"{numbers[i, j]} ");
// 	}
// }



// // Задайте двумерный массив. Напишите программу, которая поменяет местами 
// // первую и последнюю строку массива.
// // Начальные условия:
// // int[,] numbers = new int[,] {
// // 	{1, 2, 3, 4},
// // 	{5, 6, 7, 8},
// // 	{9, 10, 11, 12}
// // };
// // Выводится:
// // 9   10  11  12
// // 5   6   7   8
// // 1   2   3   4

// int[,] numbers = new int[,]
// {
// 	{1, 2, 3, 4},
// 	{5, 6, 7, 8},
// 	{9, 10, 11, 12}
// };

// int[,] numbersResult = numbers;
// int temp = 0;
// for (int i = 0; i < numbers.GetLength(1); i++)
// {
// 	temp = numbers[0, i];
// 	numbers[0, i] = numbersResult[numbers.GetLength(0) - 1, i];
// 	numbersResult[numbers.GetLength(0) - 1, i] = temp;
// }
// for (int i = 0; i < numbersResult.GetLength(0); i++)
// {
// 	for (int j = 0; j < numbersResult.GetLength(1); j++)
// 		Console.Write($"{numbersResult[i, j]}\t");
// 	Console.WriteLine();
// }
// Console.WriteLine();



// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Начальные условия:
// // Начальные условия
// int[,] numbers = new int[,] {
// 	{1, 2, 3},
// 	{1, 1, 0},
// 	{7, 8, 2},
// 	{9, 10, 11}
// };
// Выводится: 1



// int[,] numbers = new int[,]
// {
// 	{1, 2, 3},
// 	{1, 1, 0},
// 	{7, 8, 2},
// 	{9, 10, 11}
// };
// int minRowSum = 0;
// int check = 0;
// int numOfMinRowSum = 0;
// for (int i = 0; i < numbers.GetLongLength(0); i++)
// {
// 	int rowSum = 0;
// 	for (int j = 0; j < numbers.GetLongLength(1); j++)
// 		rowSum = rowSum + numbers[i, j];
// 	if (check == 0)
// 	{
// 		minRowSum = rowSum;
// 		check = 1;
// 	}
// 	if (minRowSum > rowSum)
// 	{
// 		minRowSum = rowSum;
// 		numOfMinRowSum = i;
// 	}
// }
// Console.WriteLine($"{numOfMinRowSum} ");