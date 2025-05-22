// See https://aka.ms/new-console-template for more information

//p1 60min
//p2 90min

string _filePath =  @"C:\Advent of Code\2019\Advent of Code 2019 Day 2\PuzzleInput.txt";
string input = File.ReadAllText(_filePath);
string[] inputNumbers = input.Split(',');
List<int> numbers = new List<int>();
int firstNumber = 0;
int secondNumber = 0;
int outputNumber = 0;
/*
foreach (string number in inputNumbers)
{
    numbers.Add(int.Parse(number));
}

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == 1)
    {
        int numberToChange = numbers[i + 3];
        int possition1 = numbers[i + 1];
        int possition2 = numbers[i + 2];
        int number1 = numbers[possition1];
        int number2 = numbers[possition2];

        numbers[numberToChange] = number1 + number2;
        i += 3;
    }

    if (numbers[i] == 2)
    {
        int numberToChange = numbers[i + 3];
        int number1 = numbers[i + 1];
        int number2 = numbers[i + 2];
        numbers[numberToChange] = numbers[number1] * numbers[number2];
        i += 3;
    }

    if (numbers[i] == 99)
    {
        break;
    }
}
*/
int output = 19690720;
for (int i = 0; i < inputNumbers.Length; i++)
{
    for (int j = 0; j < inputNumbers.Length; j++)
    {
        numbers = new List<int>();
        foreach (string number in inputNumbers)
        {
            numbers.Add(int.Parse(number));
        }

        numbers[1] = j;
        numbers[2] = i;
        for (int k = 0; k < numbers.Count; k++)
        {
            if (numbers[k] == 1)
            {
                int numberToChange = numbers[k + 3];
                int possition1 = numbers[k + 1];
                int possition2 = numbers[k + 2];
                int number1 = numbers[possition1];
                int number2 = numbers[possition2];

                numbers[numberToChange] = number1 + number2;
                k += 3;
            }

            if (numbers[k] == 2)
            {
                int numberToChange = numbers[k + 3];
                int number1 = numbers[k + 1];
                int number2 = numbers[k + 2];
                numbers[numberToChange] = numbers[number1] * numbers[number2];
                k += 3;
            }

            if (numbers[k] == 99)
            {
                break;
            }

            if (numbers[0] == output)
            {
                firstNumber = numbers[1];
                secondNumber = numbers[2];
                outputNumber = firstNumber * 100 + secondNumber;
            }
        }
    }
}

Console.WriteLine(outputNumber);