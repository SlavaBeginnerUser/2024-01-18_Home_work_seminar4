// // string elem = "Hello"; // строка = массив из букв
// // Console.WriteLine(elem.Length); // вывод количества ячеек = длинна массива

// // char[] a = {'a', 'b', 'c' }; // строка не преобразованная в однородный массив
// // Console.WriteLine(a.Length); // вывод количества ячеек = длинна массива

// // Задайте массив символов (тип char[]). Создайте строку из символов этого массива. 
// // Указание Конструктор строки вида string(char []) не использовать. 
// // Пример[‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// // решение №1
// // char[] a = { 'a', 'b', 'c', 'd' };
// // Console.WriteLine(a);  

// // решение №2
// string GetStringFromChar(char[] array)
// {
// 	string str = ""; // "" - пустая строка
// 	foreach (char e in array)
// 	{
// 		str += e;
// 	}
// 	return str;
// }
// char[] str = { 'a', 'b', 'c', 'd' };
// string res = GetStringFromChar (str);
// Console.WriteLine((res));


