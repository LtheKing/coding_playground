
string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);

int k = Convert.ToInt32(firstMultipleInput[1]);

string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int r_q = Convert.ToInt32(secondMultipleInput[0]);

int c_q = Convert.ToInt32(secondMultipleInput[1]);

List<List<int>> obstacles = new List<List<int>>();

for (int i = 0; i < k; i++)
{
    obstacles.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(obstaclesTemp => Convert.ToInt32(obstaclesTemp)).ToList());
}

int result = Result.queensAttack(n, k, r_q, c_q, obstacles);

Console.WriteLine(result);

class Result
{
    public static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
    {
        return 0;
    }
}