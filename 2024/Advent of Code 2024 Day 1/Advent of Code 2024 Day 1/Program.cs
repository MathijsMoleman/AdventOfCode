// See https://aka.ms/new-console-template for more information

string _filePath =  @"C:\Advent of Code\2024\Advent of Code 2024 Day 1\PuzzleInput.txt";
string[] input = File.ReadAllLines(_filePath);
List<int> leftList = new List<int>();
List<int> rightList = new List<int>();
List<int> simularaties = new List<int>();
int awnser = 0;

foreach (var line in input)
{
    var numbers = line.Split(' ');
    
    leftList.Add(int.Parse(numbers[0]));
    rightList.Add(int.Parse(numbers[3]));
}
// rightList.Sort((a,b) => a - b);
// leftList.Sort((a,b) => a - b);

for (int i = 0; i < leftList.Count; i++)
{
    int leftNumber = leftList[i];
    int simularity = 0;
    int timesRepeated = 0;
    for (int j = 0; j < rightList.Count; j++)
    {
        int rightNumber = rightList[j];
        if (leftNumber == rightNumber)
        {
            timesRepeated += 1;
        }
    }
    simularity = leftNumber * timesRepeated;
    simularaties.Add(simularity);

}

foreach (var number in simularaties)
{
    awnser += number;
}
Console.WriteLine(awnser);
