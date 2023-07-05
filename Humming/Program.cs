
string text = "david";
string text2 = "davob";

int distance = 0;

if (text.Length != text2.Length)
    throw new ArgumentException("FALSE LENGTH");

for (int i = 0; i < text.Length; i++)
{
    if (text[i] != text2[i])
        distance++;
}

Console.WriteLine(distance);