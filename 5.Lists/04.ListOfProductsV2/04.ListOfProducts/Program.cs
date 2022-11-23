// See https://aka.ms/new-console-template for more information

int numOfLines = int.Parse(Console.ReadLine());

List<string> lines = new List<string>();

for (int i = 0; i < numOfLines; i++)
{
    string line = Console.ReadLine();

        //(i + 1) + "." + line;
    
    lines.Add(line);
}

lines.Sort();

for (int i = 0; i < lines.Count; i++)
{
    string currentLine = lines[i];
    lines[i] = (i + 1) + "." + currentLine;
}

Console.WriteLine(string.Join(Environment.NewLine, lines));