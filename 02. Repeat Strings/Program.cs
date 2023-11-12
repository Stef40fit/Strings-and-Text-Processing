//•	Reads an array of strings from the console
//•	Each string is repeated N times, where N is the length of the string
//•	Print the concatenated string

string[] words = Console.ReadLine().Split();
string output = "";
for(int i = 0; i < words.Length; i++)
{
    string currentWord = words[i];
for (int j = 0; j < words[i].Length; j++)
    {
        output += currentWord;
    }
}
Console.WriteLine(output);
