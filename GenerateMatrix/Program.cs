static void generateMatrix(int param)
{
	int limit = param * 2;
	for (int i = 0; i < limit; i++)
	{
		if (i <= limit)
		{

		}
		Console.Write(i + " ");
		Console.WriteLine(i);
	}
}

int param = Convert.ToInt32(Console.ReadLine());
generateMatrix(param);  