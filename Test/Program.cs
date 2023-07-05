
// Invertir una cadena

string text = "eduardo";
string textResult = "";

/*
for (int i = text.Length-1; i>=0 ; i--)
{
    textResult += text[i];
}*/

char[] chars = text.ToCharArray();
Array.Reverse(chars);
textResult = new string(chars);

Console.WriteLine(textResult);






