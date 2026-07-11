string input = "";
List<string> listOfNames = new List<string>();

while(true)
{
    Console.WriteLine("Enter a name: ");
    input = Console.ReadLine();
    if (input.ToLower() == "x")
    {
        break;
    }
    else
    {
        listOfNames.Add(input.Trim());
    }
}
Console.WriteLine("Enter desired text: ");
string text = Console.ReadLine();
List<string> textToArray = text.Split(" ").ToList();

Dictionary<string, int> result = new Dictionary<string, int>();
int count = 0; 
foreach (string name in listOfNames)
{
    foreach (string word in textToArray)
    {
        if(word.ToLower().Contains(name.ToLower())) { count++; }
    }
    result.Add(name, count);
    count = 0;
}



foreach (KeyValuePair<string,int> pair in result)
{
    Console.WriteLine($"The name {pair.Key} appears {pair.Value} in the text");
}
