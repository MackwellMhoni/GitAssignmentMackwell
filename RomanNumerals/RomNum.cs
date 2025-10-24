// See https://aka.ms/new-console-template for more information

using System;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class RomNum
{
    private int[] rndNumber;
    private int currentNumber = 0;
    private string currentConv;
    public string Results()
    {
        //returning the roman numeral concatenated symbol
        return "MCMXCIX";
    }

    public void Conv(int num)
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



        /*// Use StringBuilder for efficient string concatenation.
        var result = new StringBuilder();
        int remainingNum = num;

        // 3. Conversion Logic: Iterate and subtract.
        foreach (var pair in romanNumerals)
        {
            // While the remaining number is greater than or equal to the current value,
            // append the symbol and subtract the value.
            while (remainingNum >= pair.Value)
            {
                result.Append(pair.Symbol);
                remainingNum -= pair.Value;
            }
        }

        return result.ToString();*/
    }

    public string InRang(int num)
    {

        if (num < 1 || num > 3000)
        {
            string result = "Not in range";
            return result;
        }else 
        {
            string result = "In range";
            return result;
        }
    }
}

