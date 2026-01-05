using System;

class class1
{
    static void Main()
    {
        Console.Write("From base (2/8/10/16): ");
        int fromBase = int.Parse(Console.ReadLine());

        Console.Write("To base (2/8/10/16): ");
        int toBase = int.Parse(Console.ReadLine());

        Console.Write("Number: ");
        //reads the number as string cuz of the hexdecimal because it can contain letters
        string input = Console.ReadLine().ToUpper();

        long dec = ToDecimal(input, fromBase);
        string result = FromDecimal(dec, toBase);

        Console.WriteLine($"Result: {result}");
    }

    // base -> decimal
    static long ToDecimal(string value, int fromBase)
    {
        long result = 0;
        foreach (char digitChar in value)
        {
            int digit = digitChar <= '9' ? digitChar - '0' : digitChar - 'A' + 10;
            result = result * fromBase + digit;
        }
        return result;
    }

    // decimal -> base
    static string FromDecimal(long number, int toBase)
    {
        if (toBase == 10) return number.ToString();
        if (number == 0) return "0";

        string result = "";
        while (number > 0)
        {
            int remainder = (int)(number % toBase);
            result = (remainder < 10 ? (char)('0' + remainder) : (char)('A' + remainder - 10)) + result;
            number /= toBase;
        }
        return result;
    }
}
