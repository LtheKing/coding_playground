int value = 0;
int limit = Convert.ToInt32(Console.ReadLine());

//vertical loop
for (int i = 0; i < limit; i++)
{
    //horizontal loop
    for (int j = 0; j < limit; j++)
    {
        Console.Write(value + " ");
        value++;
    }

    Console.WriteLine();
}