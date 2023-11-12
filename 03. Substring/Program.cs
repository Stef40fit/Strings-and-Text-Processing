//•	Read first string from the first line of the console
//•	Reads second string from the second line of the console
//•	Remove all of the occurrences of the first string in the second string
//•	Print the remaining string


string wordToRemove = Console.ReadLine();
string text = Console.ReadLine();
while (text.Contains(wordToRemove))
{
    int indexOfwordToRemove = text.IndexOf(wordToRemove);
    text = text.Replace(wordToRemove, "");
}
Console.WriteLine(text);
 