/*

Functions in programming

Problem to solve:

You've got a text. In text, you have to replace all spaces by underlines,
and all small letters "k" replace by big letters "K", and big letters "c"
replace by small letters "C". 

*/

string text = "I'm bored, "
            + "my peek of productivity is far behind. "
            + "Would you like to go on walk? "
            + "Oh, god, thank you for this fresh air.";

// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
newText = Replace(newText, 'c', 'C');
newText = Replace(newText, 'k', 'K');
Console.WriteLine();
Console.WriteLine(newText);