class Solution
{

    // Complete the catAndMouse function below.
    static string catAndMouse(int x, int y, int z)
    {
        int cat1 = 0;
        int cat2 = 0;

        if (z > x)
        {
            cat1 = z - x;
        } else
        {
            cat1 = x - z;
        }

        if (z > y)
        {
            cat2 = z - y;
        }
        else
        {
            cat2 = y - z;
        }

        if (cat1 == cat2)
        {
            return "Mouse C";
        } else if (cat1 < cat2) {
            return "Cat A";
        } else
        {
            return "Cat B";
        }

    }

    static void Main(string[] args)
    {

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] xyz = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xyz[0]);

            int y = Convert.ToInt32(xyz[1]);

            int z = Convert.ToInt32(xyz[2]);

            string result = catAndMouse(x, y, z);

            Console.WriteLine(result);
        }
    }
}