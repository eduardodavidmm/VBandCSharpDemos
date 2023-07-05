

string text = "distribuidor de productos de construccion";
int n  = 0;

text = text.Trim();
var words = text.Split(' ');
n = words.Length;

Console.WriteLine("Words number:" + n);
