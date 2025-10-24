using System.Text;

namespace RomanNumeralTest
{
    public class RomNumUnitTest
    {
        [Fact]
        public void Test_Roman_Numeral_Out_Of_Range()
        {
            var rNum = new RomNum();
            int input = 3050;

            Assert.Equal("Not in range", rNum.InRang(input));
        }


        [Fact]
        public void Test_Roman_Numeral_Conversion()
        {
            var rNum = new RomNum();
            int input = 50;

            rNum.Conv(input);

            Assert.Equal("L", rNum.Conv(input));
        }
    }
}


