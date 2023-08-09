static void generateMatrix(int param)
{
    //int limit = param * 2;
    int limit = 4;
    int vertical = 0;
    int horizontal = 0;

    for (int i = 0; i < param; i++)
    {
        Console.WriteLine(i);
    }
}

int param = Convert.ToInt32(Console.ReadLine());
generateMatrix(param);