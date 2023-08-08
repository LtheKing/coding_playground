using System.Linq;

int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

int result = Result.equalizeArray(arr);

Console.WriteLine(result);

class Result
{

    /*
     * Complete the 'equalizeArray' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int equalizeArray(List<int> arr)
    {
        int maxcount = 0;
        int element_having_max_freq = 0;
        int n = arr.Count;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }

            if (count > maxcount)
            {
                maxcount = count;
                element_having_max_freq = arr[i];
            }
        }

        List<int> sorted = new List<int>();

        for (int i = 0; i < n; i++)
        {
            if (arr[i] != element_having_max_freq)
            {
                sorted.Add(arr[i]);
            }
        }

        return sorted.Count();
    }

}