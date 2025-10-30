
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
        var romanNumerals = new[]
        {
            new { Value = 1000, Symbol = "M" },
            new { Value = 900, Symbol = "CM" },
            new { Value = 500,  Symbol = "D" },
            new { Value = 400, Symbol = "CD" },
            new { Value = 100,  Symbol = "C" },
            new { Value = 90, Symbol = "XC" },
            new { Value = 50,   Symbol = "L" },
            new { Value = 40, Symbol = "XL" },
            new { Value = 10,   Symbol = "X" },
            new { Value = 90, Symbol = "IX" },
            new { Value = 5,    Symbol = "V" },
            new { Value = 4, Symbol = "IV" },
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

    public string Repition(int number)
    {
        var romanNumerals = new[]
        {
            new { Value = 1000, Symbol = "M" },
            new { Value = 900, Symbol = "CM" },
            new { Value = 500,  Symbol = "D" },
            new { Value = 400, Symbol = "CD" },
            new { Value = 100,  Symbol = "C" },
            new { Value = 90, Symbol = "XC" },
            new { Value = 50,   Symbol = "L" },
            new { Value = 40, Symbol = "XL" },
            new { Value = 10,   Symbol = "X" },
            new { Value = 90, Symbol = "IX" },
            new { Value = 5,    Symbol = "V" },
            new { Value = 4, Symbol = "IV" },
            new { Value = 1,    Symbol = "I" }
        };

        var result = new StringBuilder();
        int remainingNum = num;

        foreach (var pair in romanNumerals)
        {
            while (remainingNum >= pair.Value)
            {
                string repeat = string.Concat(Enumerable.Repeat(pair.Symbol, 4));
                if(repeat.Contains(pair.Symbol + pair.Symbol + pair.Symbol + pair.Symbol))
                {
                    throw new InvalidOperationException("Roman numeral repetition exceeded for symbol: " + pair.Symbol);
                }
                else
                {
                    result.Append(pair.Symbol);
                    remainingNum -= pair.Value;
                }

                  
            }
        }

        return result.ToString();
    }

    public string Subtract(int num)
    {
        var romanNumerals = new[]
        {
            new { Value = 1000, Symbol = "M" },
            new { Value = 900, Symbol = "CM" },
            new { Value = 500,  Symbol = "D" },
            new { Value = 400, Symbol = "CD" },
            new { Value = 100,  Symbol = "C" },
            new { Value = 90, Symbol = "XC" },
            new { Value = 50,   Symbol = "L" },
            new { Value = 40, Symbol = "XL" },
            new { Value = 10,   Symbol = "X" },
            new { Value = 90, Symbol = "IX" },
            new { Value = 5,    Symbol = "V" },
            new { Value = 4, Symbol = "IV" },
            new { Value = 1,    Symbol = "I" }
        };

        var result = new StringBuilder();
        int remainingNum = num;

        foreach (var pair in romanNumerals)
        {
            while (remainingNum >= pair.Value)
            {
                var Npairs = pair.Symbol;
                result.Append(Npairs);
                remainingNum -= pair.Value;
            }
        }

        return result.ToString();

    }
}



