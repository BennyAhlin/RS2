
Console.WriteLine("Hello, please enter your name in \"Rövarspråk\" and I will translate it.");
string nameInput = Console.ReadLine().ToLower();
Console.Clear();
string[] konsonanter =
{
    "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z"
};

for (int i = 0; i < nameInput.Length; i++)
{
    string name = nameInput[i].ToString();
    bool nameKons = false;
    for (int j = 0; j < konsonanter.Length; j++)
    {
        string kons = konsonanter[j].ToString();
        if (name == kons)
        {
            nameKons = true;
        }
    }
    if (nameKons)
    {
        nameInput = nameInput.Remove(i + 1, 2);
    }
}
Console.WriteLine(nameInput);