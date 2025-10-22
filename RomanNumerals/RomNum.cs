// See https://aka.ms/new-console-template for more information

using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class RomNum
{
    public string Results()
    {
         return "MCMXCIX";
    }

    public void Conv(int i)
    {
        
        //
        
    }



    /*  private char currentValue = 'I';

      public string ToRoman(int number)
      {
         var testValue = Conv(number);
          return testValue;
      }

      public string Conv(int num)
      {
       *//*   var map = new[]
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

          foreach (var item in map)
          {
              while (num >= item.Value)
              {
                  result.Append(item.Symbol);
                  num -= item.Value;
              }
          }

          return result.ToString();
      }*/
}

