List<string>people= new();

people.Add("Alice");
people.Add("Hakan");
people.Add("Hilal");

foreach (string person in people)
{
    Console.WriteLine(person);
}
Console.WriteLine("************");

people.Remove("Bob");


foreach (string person in people)
{
    Console.WriteLine(person);
}
Console.WriteLine("************");




