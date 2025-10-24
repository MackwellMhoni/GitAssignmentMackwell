
using System.Text;

public class RomNum
{
    public int num;
    public string Results()
    {
        if (num < 1 || num < 3000)
        {
            string result = "Not in range";
            return result;
        }
        else
        {
            string result = "In range";
            return result;
        }
    }

    public string InRang(int num)
    {
        return Results();
    }

    public string Conv(int num)
    {
        //symbols and values in roman numerals
        var romanNumerals = new[]
        {
            new { Value = 1000, Symbol = "M" },
            new { Value = 500,  Symbol = "D" },
            new { Value = 100,  Symbol = "C" },
            new { Value = 50,   Symbol = "L" },
            new { Value = 10,   Symbol = "X" },
            new { Value = 5,    Symbol = "V" },
            new { Value = 1,    Symbol = "I" }
        };

        var result = new StringBuilder();
        int remainingNum = num;

        foreach (var pair in romanNumerals)
        {
            while (remainingNum >= pair.Value)
            {
                result.Append(pair.Symbol);
                remainingNum -= pair.Value;
            }
        }

        return result.ToString();
    }

    public string Subtract(int num)
    {
        return "";
    }
}



