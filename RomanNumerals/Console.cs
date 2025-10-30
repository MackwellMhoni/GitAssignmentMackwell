using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1–3000): ");
            if (!int.TryParse(Console.ReadLine(), out int num) || num < 1 || num > 3000)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            string romanNumeral = ConvertToRoman(num);
            string reversed = new string(romanNumeral.Reverse().ToArray());

            Console.WriteLine($"Roman numeral: {romanNumeral}");
            Console.WriteLine($"Reversed Roman numeral: {reversed}");
        }

       
        static string ConvertToRoman(int number)
        {
            var romanNumerals = new[]
            {
                new { Value = 1000, Symbol = "M" },
                new { Value = 900,  Symbol = "CM" },
                new { Value = 500,  Symbol = "D" },
                new { Value = 400,  Symbol = "CD" },
                new { Value = 100,  Symbol = "C" },
                new { Value = 90,   Symbol = "XC" },
                new { Value = 50,   Symbol = "L" },
                new { Value = 40,   Symbol = "XL" },
                new { Value = 10,   Symbol = "X" },
                new { Value = 9,    Symbol = "IX" },
                new { Value = 5,    Symbol = "V" },
                new { Value = 4,    Symbol = "IV" },
                new { Value = 1,    Symbol = "I" }
            };

            var result = new StringBuilder();
            int remaining = number;

            foreach (var pair in romanNumerals)
            {
                while (remaining >= pair.Value)
                {
                    result.Append(pair.Symbol);
                    remaining -= pair.Value;
                }

            }

            return result.ToString();
        }
    }
}
