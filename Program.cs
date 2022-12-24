// Изначально задан массив строк, нужно выбрать элементы длинной 3 и более символов и сформировать из них новый массив

void PrintArray(string[] array) // print array
{
    System.Console.Write("[");
	foreach (var item in array)
	{
		Console.Write(item + ", ");
	}
	System.Console.Write("]");
}

string[] book = new string[] {"roinsg", "2354", "dog", "bugaty", ":~O", "tinto", "winter", "war", "mamy"};
string[] selection = new string[] {};

PrintArray(book);

for(int i = 0; i < book.Length; i++)
{
	if(book[i].Length < 4)
		selection = selection.Append(book[i]).ToArray();
}
System.Console.Write(" -> ");
PrintArray(selection);





