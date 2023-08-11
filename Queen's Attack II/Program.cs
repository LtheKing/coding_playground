
using System.Collections.Generic;

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
        int result = 0;

        //vertical loop
        for (int i = 1; i <= n; i++)
        {
            //horizontal loop
            for (int j = 1; j <= n; j++)
            {

                //looping obstacle
                if ((j == c_q) && (i == r_q))
                {
                    for (int p = 0; p < k; p++)
                    {
                    
                        //cek lurus
                        if ((obstacles[p][0] != c_q) && (obstacles[p][1] != r_q))
                        {
                            result++;
                        }

                        int h = j;
                        int v = i;

                        //cek diagonal atas kanan
                        while (h <= n && v <= n )
                        {
                            h++;
                            v++;  
                            
                            if ((obstacles[p][0] != h) && (obstacles[p][1] != v))
                            {
                                result++;
                            }
                        }

                        h = j;
                        v = i;

                        //cek diagonal kiri bawah
                        while (h >= n && v >= n)
                        {
                            h--;
                            v--;

                            if ((obstacles[p][0] != h) && (obstacles[p][1] != v))
                            {
                                result++;
                            }

                        }

                        h = j;
                        v = i;

                        //cek diagonal kiri atas
                        while (v <= n && h >= n)
                        {
                            v++;
                            h--;

                            if ((obstacles[p][0] != h) && (obstacles[p][1] != v))
                            {
                                result++;
                            }
                        }

                        h = j;
                        v = i;

                        //cek diagonal kanan bawah
                        while (v >= n && h <= n)
                        {
                            v--;
                            h++;

                            if ((obstacles[p][0] != h) && (obstacles[p][1] != v))
                            {
                                result++;
                            }
                        }
                    }
                }
            }
        }

        return result;
    }
}

//NOTES
//queensAttack has the following parameters:
//-int n: the number of rows and columns in the board
//- nt k: the number of obstacles on the board
//- int r_q: the row number of the queen's position
//- int c_q: the column number of the queen's position
//- int obstacles[k][2]: each element is an array of  integers, the row and column of an obstacle