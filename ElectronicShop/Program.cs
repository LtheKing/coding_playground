using System.IO;

class solution
{
    public static void Main(string[] args)
    {
        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b);

        Console.WriteLine(moneySpent);
    }

    static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        int affordable = 0;
        for (int i = 0; i < keyboards.Length; i++)
        {
            for (int a = 0; a < drives.Length; a++)
            {
                if ((drives[a] + keyboards[i] <= b) && (drives[a] + keyboards[i]) > affordable)
                {
                    affordable = drives[a] + keyboards[i];
                }
            }
        }

        if (affordable == 0)
        {
            return -1;
        }

        return affordable;
    }
}