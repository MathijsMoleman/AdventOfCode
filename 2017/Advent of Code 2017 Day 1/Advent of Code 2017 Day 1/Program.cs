// See https://aka.ms/new-console-template for more information

string _filePath =  @"C:\Advent of Code\2017\Advent of Code 2017 Day 1\PuzzleInput.txt";
string input = File.ReadAllText(_filePath);
List<int> sums = new();
int jump = input.Length / 2;
int j = jump ;
int answer = 0;

for (int i = 0; i < input.Length; i++)
{
    if (i >= jump)
    {
        j = i - jump;
        if (input[i] == input[j])
        {

            sums.Add(input[i] - 48);
            Console.WriteLine(input[i] + "," + input[j]);
        }
    }
    else
    {
        j = i + jump;
        if (input[i] == input[j])
        {

            sums.Add(input[i] - 48);
            Console.WriteLine(input[i] + "," + input[j]);
        }
    }

}

for (int i = 0; i < sums.Count; i++)
{
    answer += sums[i];
}
Console.WriteLine(answer);