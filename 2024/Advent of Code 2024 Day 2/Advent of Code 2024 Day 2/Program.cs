// See https://aka.ms/new-console-template for more information
//p1 60min
//p2 175min 
string filePath = @"C:\Advent of Code\2024\Advent of Code 2024 Day 2\PuzzleInput.txt"; 
List<string> input = File.ReadAllLines(filePath).ToList();
int totalSafeReports = 0;
/*
foreach (var line in input)
{
    bool decreasing = false;
    bool Unsafe = false;
    string[] instructions = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
    int numer1 = int.Parse(instructions[0]);
    int numer2 = int.Parse(instructions[1]);
    if (numer1 - numer2 < 0)
    {
          decreasing = true;
    }
    
    for (int i = 0; i < instructions.Length -1; i++)
    {
        int j = i + 1;
        numer1 = int.Parse(instructions[i]);
        numer2 = int.Parse(instructions[j]);
        //Console.WriteLine(numer1 + "," +  numer2 + "," + (numer1 - numer2));
        if (numer1 - numer2 > 0 && decreasing == true)
        {
            Unsafe = true;
        }
        else if (numer1 - numer2 < 0 && decreasing == false)
        {
            Unsafe = true;
        }
        else if (numer1 == numer2 )
        {
            Unsafe = true;
        }
        else if (numer1 - numer2 > 3 || numer1 - numer2 < 1 && decreasing == false)
        {
            Unsafe = true;
        }
        else if (numer1 - numer2 < -3 || numer1 - numer2 > -1 && decreasing == true)
        {
            Unsafe = true;
        }
        else if (Unsafe == false)
        {
            Unsafe = false;
        }
    }

    if (Unsafe == true)
    {
        Console.WriteLine("Unsafe");
    }
    else
    {
        Console.WriteLine("Safe");
        totalSafeReports++;
    }
}
*/

foreach (var line in input)
{
    List<int> numbers = line.Split(" ").Select(int.Parse).ToList();
    bool decreasing = false;
    bool Unsafe = true;
    for (int i = 0; i < numbers.Count; i++)
    {
        if (Unsafe == true)
        {
            int numberBeingRemoved = numbers[i];
            Unsafe = false;
            numbers.RemoveAt(i);
            int numer1 = numbers[0];
            int numer2 = numbers[1];
            if (numer1 - numer2 > 0)
            {
                decreasing = true;
            }

            for (int j = 0; j < numbers.Count - 1; j++)
            {
                int k = j + 1;
                numer1 = numbers[j];
                numer2 = numbers[k];
                //Console.WriteLine(numer1 + "," +  numer2 + "," + (numer1 - numer2));
                if (numer1 - numer2 < 0 && decreasing == true)
                {
                    Unsafe = true;
                }
                else if (numer1 - numer2 > 0 && decreasing == false)
                {
                    Unsafe = true;
                }
                else if (numer1 == numer2)
                {
                    Unsafe = true;
                }
                else if ((numer1 - numer2 > 3 || numer1 - numer2 < 1) && decreasing == true)
                {
                    Unsafe = true;
                }
                else if ((numer1 - numer2 < -3 || numer1 - numer2 > -1) && decreasing == false)
                {
                    Unsafe = true;
                }
                else if (Unsafe == false)
                {
                    Unsafe = false;
                }
                Console.Write(numbers[j]+ " ");
                if (k == numbers.Count -1)
                {
                    Console.Write(numbers[k]);
                }
            }

            Console.WriteLine(" ");
            if (Unsafe == true)
            {
                numbers.Insert(i, numberBeingRemoved);
            }
            else
            {
                Console.WriteLine("Safe");
                totalSafeReports++;
                break;
            }
        }
    }

    if (Unsafe == true)
    {
        Console.WriteLine("Unsafe");
    }
Console.WriteLine(" ");
}
Console.WriteLine($"Total Safe: {totalSafeReports}");