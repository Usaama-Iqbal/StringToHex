using System;
using System.Text;

public class Program
{
    public static string StringToHex(string input)
    {
        StringBuilder hex = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            hex.Append(((int)c).ToString("X2"));
        }

        return hex.ToString();
    }

    public static void Main(string[] args)
    {
        //string input = "Hello, World!";
        string input;
        Console.Write("Please Input The string : ");
        input =Console.ReadLine();
        string hexResult = StringToHex(input);
        Console.Write("The HexDecimal of given number is : "+hexResult);
    }
}
