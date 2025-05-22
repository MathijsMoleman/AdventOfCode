// See https://aka.ms/new-console-template for more information
class MyProject
{ 
    private static int calibrationValue = 0;
    static List<int> numbers = new List<int>();

    static void Main(string[] args)
    {
        string filePath = @"C:\Advent of Code\2023\Advent of Code 2023 Day 1\PuzzleInput.txt";
        List<string> lines = File.ReadAllLines(filePath).ToList();
        Dictionary<string, int> textNumbers = new Dictionary<string, int>()
        {
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9},
        };
        GetNumbers(lines, textNumbers);
        Console.WriteLine(calibrationValue);
    }
 
    static void GetNumbers(List<string> lines, Dictionary<string, int> textNumbers)
    {
        foreach (string line in lines)
        {
            string checkedCharacters = string.Empty;
            foreach (char character in line)
            {
 
                if (char.IsDigit(character))
                {
                    int number = (int)char.GetNumericValue(character);
                    numbers.Add(number);
                }
                else
                {
                    checkedCharacters += character;
                    if (checkedCharacters.Length >= 3)
                    {
                        for(int i = 0; i < textNumbers.Count; i++)
                        {
                            if(checkedCharacters.Contains(textNumbers.ElementAt(i).Key))
                            {
                                char lastCharacter = checkedCharacters.Last();
                                numbers.Add(textNumbers.ElementAt(i).Value);
                                checkedCharacters = string.Empty;
                                checkedCharacters += lastCharacter;
                            }
                        }
                    }
                }
            }
            GetFirstAndLastNumbers();
        }
    }
 
    static void GetFirstAndLastNumbers()
    {
        CalculateAnwser(numbers.First(),  numbers.Last());
        numbers.Clear();
    }
 
    static void CalculateAnwser(int a, int b)
    {
        calibrationValue += (a * 10) + b;
        Console.WriteLine((a * 10) + b);
    }
}
