// // Задача 1: Задайте двумерный массив символов (тип char [,]). 
// // Создать строку из символов этого массива. 
// // Пример:			
// // a b c   => “abcdef” 
// // d e f 

// string GetStringFromChar(char[,] array)  // метод создания строки из массива
// {
// 	string str = ""; // "" - пустая строка
// 	foreach (char e in array)
// 	{
// 		str += e;
// 	}
// 	return str;
// }
// char[,] symbolsArr = new [,]
// {
// 	{ 'a', 'b', 'c'},
// 	{ 'd', 'e', 'f'}
// };

// string res = GetStringFromChar (symbolsArr);
// Console.WriteLine((res));



// // Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// // Сформируйте строку, в которой все заглавные буквы заменены на строчные. 
// // Пример:  “aBcD1ef!-” => “abcd1ef!-” 

// Console.Write("Введите строку: ");
// string str = Console.ReadLine();
// string res = str.ToLower();  // преобразование верхн региста символов в нижний
// Console.WriteLine($"{res}");



// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
// Пример:
// “aBcD1ef! -” => Нет 
// “шалаш” => Да 
// “55655” => Да

char[] StringToChars(string str) // метод преобразования строки в массив
{
	char[] chars = new char[str.Length];
	for (int i = 0; i < str.Length; i++)
	{
		chars[i] = str[i]; // в массив заносим значение из строки
	}
	return chars;
}

Console.Write("Введите строку: ");
string str = Console.ReadLine();
char[] chr = StringToChars(str);  // создаем массив
bool flag = true;

for (int i = 0; i < chr.Length / 2; i++)
{
	if (chr[i] != chr [chr.Length - 1*(i+1)])
	{
		flag = false;
	}
}
if (flag == true)
{
	Console.WriteLine("Да");
}
else
{
	Console.WriteLine("Нет");
}