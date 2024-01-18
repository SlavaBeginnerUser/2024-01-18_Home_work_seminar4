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



int sumOfDigits = 0;
while (true) // бесконечный запуск программы до команды break
{
Console.WriteLine("Введите целое число: ");
string inputstring= Convert.ToString(Console.ReadLine()); // преобразование в "строку"
if(inputstring == "q")
	break;
int inputNumber = Convert.ToInt32(inputstring); // преобразование в число
sumOfDigits = 0;
while (inputNumber != 0)
{
	sumOfDigits = sumOfDigits + inputNumber % 10;;
	inputNumber = inputNumber / 10;
}
if(sumOfDigits % 2 == 0)
{
		Console.Write($"Сумма цифр четная и равна {sumOfDigits} "); 
		break;
}
}
