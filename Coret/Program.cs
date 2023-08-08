using Microsoft.VisualBasic;

public class Result
{
    public static string procVowel(string param)
    {
        string result = "";

        for (int i = 0; i < param.Length; i++)
        {
            if (param[i] == 'a' || param[i] == 'e' ||
            param[i] == 'i' || param[i] == 'o' ||
            param[i] == 'u' || param[i] == 'A' ||
            param[i] == 'E' || param[i] == 'I' ||
            param[i] == 'O' || param[i] == 'U')
            {
                result += param[i];
            }
        }

        result = String.Concat(result.OrderBy(c => c));
        return result;
    }

    public static string procConsonant(string str)
    {
        string result = "";
        str = str.Trim();
        for (int i = 0; i < str.Length; i++)
        {
            var check = "aeiouAEIOU".Contains(str[i]);
            if (!check)
            {
                result += str[i];
            }
            //if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
            //{
            //    result += str[i];
            //}

        }

        result = String.Concat(result.OrderBy(c => c));
        return result.ToLower();
    }

    public static void Main(string[] args)
    {
        Console.Write("Input one line of words (S) : ");
        string input = Console.ReadLine();

        string charVowel = procVowel(input);
        string charConsonant = procConsonant(input);

        Console.WriteLine("Vowel Characters : ");
        Console.WriteLine(charVowel);
        Console.WriteLine("Consonant Characters : ");
        Console.WriteLine(charConsonant);
    }
}



//int a = Convert.ToInt32(Console.ReadLine());
//List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();
//int total = 0;

//if (c.Count != a)
//{
//    Console.WriteLine("Input must be equal with count of family");
//} else
//{
//	foreach (var item in c)
//	{
//		total += item;
//	}

//	int result = total / 4;
//	int sisa = total % 4;

//	if (sisa > 0)
//	{
//		result += 1;
//	}

//    Console.WriteLine(result);
//}

