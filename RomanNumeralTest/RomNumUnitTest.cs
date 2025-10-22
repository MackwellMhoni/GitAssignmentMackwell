using System.Text;

namespace RomanNumeralTest
{
    public class RomNumUnitTest
    {
        [Fact]
        public void Test_Roman_Numeral_Conversion()
        {
            var rNum = new RomNum();
            int input = 1994;

            rNum.Conv(input);

            Assert.Equal("MCMXCIX", rNum.Results());
        }

    }
}

