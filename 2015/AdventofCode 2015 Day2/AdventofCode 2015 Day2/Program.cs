// See https://aka.ms/new-console-template for more information

string filePath =  @"C:\Advent of Code\2015\AdventofCode 2015 Day2\PuzzleInput.txt";
string[] input = File.ReadAllLines(filePath);
List<int> squareFeets = new List<int>();
List<int> ribonFeets = new List<int>();
int totalSquareFeet = 0;
int totalRibonFeet = 0;
foreach (string line in input)
{
    var numbers = line.Split('x');
    int l = int.Parse(numbers[0]);
    int w = int.Parse(numbers[1]);
    int h = int.Parse(numbers[2]);
    int number1 = l * w;
    int number2 = w * h;
    int number3 = h * l;
    int squareFeet = 2 * number1 + 2 * number2 + 2 * number3;
    List<int> dimensions = new List<int>();
    dimensions.Add(number1);
    dimensions.Add(number2);
    dimensions.Add(number3);
    dimensions.Sort();
    squareFeet += dimensions[0];
    
    squareFeets.Add(squareFeet);
    
    List<int> ribonDimensions = new List<int>();
    ribonDimensions.Add(l);
    ribonDimensions.Add(w);
    ribonDimensions.Add(h);
    ribonDimensions.Sort();
    int ribonFeet = ribonDimensions[0] * 2 + ribonDimensions[1] * 2;
    int ribonbow = l * w * h;
    int ribontotal = ribonbow + ribonFeet;
    ribonFeets.Add(ribontotal);
}

foreach (int squareFeet in squareFeets)
{
    totalSquareFeet += squareFeet;
}

foreach (int ribonFeet in ribonFeets)
{
    totalRibonFeet += ribonFeet;
}
Console.WriteLine(totalSquareFeet);
Console.WriteLine(totalRibonFeet);