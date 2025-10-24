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

            rNum.InRang(input);

            Assert.Equal("Not in range", rNum.Results());
        }
    }
}


