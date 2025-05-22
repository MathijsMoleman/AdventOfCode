// See https://aka.ms/new-console-template for more information
//60 min
//60 min
string _filePath =  @"C:\Advent of Code\2018\Advent of Code 2018 Day 2\PuzzleInput.txt";
string[] input = File.ReadAllLines(_filePath);
int dubbles = 0;
int triples = 0;
/*
foreach (var line in input)
{
    List<char> tripples = new List<char>();
    bool tripleFound = false;
    bool dubbleFound = false;
    
    for (int i = 0; i < line.Length; i++)
    {
        for (int j = 0; j < line.Length; j++)
        {
            if (line[i] == line[j] && i != j)
            {
                for (int k = 0; k < line.Length; k++)
                {
                    if (line[i] == line[j] && line[j] == line[k] && i != k && j != k && !tripples.Contains(line[i]))
                    {
                        tripples.Add(line[k]);
                        tripleFound = true;
                    }
                }

                if (!tripples.Contains(line[i]))
                {
                    dubbleFound = true;
                }
            }
        }
    }

    if (dubbleFound)
    {
        dubbles++;
    }

    if (tripleFound)
    {
        triples++;
    }
}
Console.WriteLine(dubbles + "," + triples + "," + dubbles * triples);
*/
List<char> correctLetters = new List<char>();  
for (int i = 0; i < input.Length; i++)
{
    for (int j = 0; j < input.Length; j++)
    {
        List<char> sameLetters = new List<char>();
        int differentLetters = 0;
        for (int k = 0; k < input[i].Length; k++)
        {
            if (i == j)
            {
                break;
            }
            char letter1 = input[i][k];
            char letter2 = input[j][k];

            if (letter1 != letter2)
            {
                differentLetters++;
            }
            else
            {
                sameLetters.Add(letter1);
            }
        }

        if (differentLetters == 1)
        {
            correctLetters = sameLetters;
        }
    }
}

foreach (var letter in correctLetters)
{
    Console.Write(letter);
}
