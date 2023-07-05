

string text = "anfsdnfoiandfindsfalskmdlkasndl";
char character = 'a';

int a = 0;

foreach (char c in text)
{
    if (c == character)
        a++;
}

Console.WriteLine(a);
