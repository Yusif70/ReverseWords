string group = "Salam JetAcademy qrupu";
string[] words = SplitToArray(group);
foreach (string word in words)
{
	Console.Write(word + " ");
}
Console.WriteLine();

ReverseWords(words);
foreach (string word in words)
{
	Console.Write(word + " ");
}
Console.WriteLine();


static string[] SplitToArray(string group)
{
	int wordIndex = 0;
	string[] arr = new string[20];
	string word = "";
	for (int i = 0; i < group.Length; i++)
	{
		if (group[i] != ' ')
		{
			word += group[i];
			if (i == group.Length - 1)
			{
				arr[wordIndex] = word;
			}
		}
		else
		{
			arr[wordIndex] = word;
			wordIndex++;
			word = "";
		}
	}
	return arr;
}

static string[] ReverseWords(string[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		string y = "";
		for (int j = 0; j < arr[i]?.Length; j++)
		{
			y += arr[i][arr[i].Length - j - 1];
		}
		arr[i] = y;
	}
	return arr;
}