﻿//Create a program that takes a text and a string of banned words. 
//    All words included in the ban list should be replaced with a string of 
//    asterisks '*', whose length must be equal to the word's length. 
//    The entries in the ban list will be separated by a comma and space ", ". 
//    The ban list should be entered on the first input line and the text on the second input line. 

string [] bannedWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();

foreach (string bannedWord in bannedWords)
{
    string censoredWord = new string('*', bannedWord.Length); 

    if (text.Contains(bannedWord))
    {
        text = text.Replace(bannedWord,censoredWord);
    }
}
Console.WriteLine(text);