//•	Read a single string from the console
//•	Print all the digits on the first line
//•	Print all the letters on the second line
//•	Print all the other characters on the third line
//Note: There will always be at least one digit, one letter and one other character.


using System.Text;

string text = Console.ReadLine();

StringBuilder digits = new StringBuilder();
StringBuilder letters = new StringBuilder();
StringBuilder others = new StringBuilder();
foreach (char symbol in text)
{
    if (char.IsDigit(symbol))
    {
        digits.Append(symbol);
    }
    else if (char.IsLetter(symbol))
    {
        letters.Append(symbol);
    }
    else
    {
        others.Append(symbol);
    }
    
}
Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(others);