using System.Security;
using System;
using System.ComponentModel;
using System.Diagnostics;

//string a = "This is really fine!";
//var s = a.Split(' ');
//var result = s.Reverse();
//string d = "";
//foreach (var item in result)
//{
//    d += item + " ";
//}

//Console.WriteLine(d);


// Instantiate the secure string.
SecureString securePwd = new SecureString();
ConsoleKeyInfo key;

Console.Write("Enter password: ");
do
{
    key = Console.ReadKey(true);

    // Ignore any key out of range.
    if (((int)key.Key) >= 65 && ((int)key.Key <= 90))
    {
        // Append the character to the password.
        securePwd.AppendChar(key.KeyChar);
        Console.Write("*");
    }
    // Exit if Enter key is pressed.
} while (key.Key != ConsoleKey.Enter);
Console.WriteLine();

try
{
    Process.Start("Postman.exe");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    securePwd.Dispose();
}