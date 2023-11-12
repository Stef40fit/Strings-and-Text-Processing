//•	Reads a series of strings from the console, until you receive an "end" command
//•	Reverse given strings
//•	Print each pair (old text and reversed text) on a separate line in the format:
// "{word} = {reversed word}"

string word = Console.ReadLine();

while (word != "end")
{
    string reversedWord = "";

    for(int i = word.Length-1; i>=0; i -= 1)
    {
        reversedWord += word[i];
    }
    Console.WriteLine($"{word} = {reversedWord}");
    word = Console.ReadLine();
}

