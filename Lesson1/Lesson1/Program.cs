int secretKey = 65;

string text = Console.ReadLine();

string codeText = "";

for (int i = 0; i < text.Length; i++)
{
    codeText += (char)(text[i] ^ secretKey);
}

Console.WriteLine(codeText);

string unCodeText = "";
for (int i = 0; i < codeText.Length; i++)
{
    unCodeText += (char)(codeText[i] ^ secretKey);
}

Console.WriteLine(unCodeText);


