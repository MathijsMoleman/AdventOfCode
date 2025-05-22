// See https://aka.ms/new-console-template for more information

string _filePath =  @"C:\Advent of Code\2019\Advent of Code 2019 Day 1\PuzzleInput.txt";
string[] input = File.ReadAllLines(_filePath);
List<int> fuelAmounts = new List<int>();
int totalFuel = 0;
foreach (string line in input)
{
    List<int> addedfuel = new List<int>();
    int mass = Convert.ToInt32(line);
    int fuelAmount = mass / 3 -2;
    addedfuel.Add(fuelAmount);
    Console.WriteLine(fuelAmount);
    while(fuelAmount / 3 - 2 >= 0)
    {
        fuelAmount = fuelAmount / 3 -2;
        addedfuel.Add(fuelAmount);
        Console.WriteLine(fuelAmount);
    }
    fuelAmount = 0;
    foreach (int fuel in addedfuel) 
    { 
        fuelAmount += fuel;
    }
    fuelAmounts.Add(fuelAmount);
    addedfuel.Clear();
}

foreach (int fuelAmount in fuelAmounts)
{
    totalFuel += fuelAmount;
}
Console.WriteLine(totalFuel);