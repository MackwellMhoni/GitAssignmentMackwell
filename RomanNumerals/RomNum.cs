
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
}

