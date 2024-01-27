// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки. 
// Указание Использовать рекурсию. Не использовать цикл. 
// Пример 
// “hello” => h l l 
// “World” => W r l d 
// “Hello world!” => H l l w r l d

using System.ComponentModel;

void ShowLetters(string str)
 {
	if(str.Length == 0)
	{
		return ;
	}
	string vowels = "aouyie";
	if(!vowels.Contains(Char.ToLower((str[0]))) && char.IsAsciiLetter(str[0])) //если не содержит voweels переводим 1й элем строки в char и в нижн регистр => то 
	{
		Console.Write($"{str[0]} ");
	}
	ShowLetters(str.Substring(1));	// удаляет (1)-один символ в строке
 }

ShowLetters("Hello World!");