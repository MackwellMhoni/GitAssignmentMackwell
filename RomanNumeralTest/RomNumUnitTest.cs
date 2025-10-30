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
        public void Test_Roman_Numeral_Out_Of_RANGE_0()
        {
            var rNum = new RomNum();
            int input = 0;

            Assert.Equal("Not in range", rNum.InRang(input));
        }

        [Fact]
        public void Test_Roman_Numeral_Random_ConverT_1()
        {
            var rNum = new RomNum();
            int input = 1;

            rNum.Conv(input);

            Assert.Equal("I", rNum.Conv(input));
        }

        [Fact]
        public void Test_Roman_Numeral_Random_Conversion()
        {
            var rNum = new RomNum();
            int input = 50;

            rNum.Conv(input);

            Assert.Equal("L", rNum.Conv(input));
        }

        [Fact]
        public void Test_Roman_Numeral_2000()
        {
            var rNum = new RomNum();
            int input = 2000;

            rNum.Conv(input);

            Assert.Equal("MM", rNum.Conv(input));
        }

        [Fact]
        public void Test_Roman_Numeral_3000()
        {
            var rNum = new RomNum();
            int input = 3000;

            rNum.Conv(input);

            Assert.Equal("MMM", rNum.Conv(input));
        }


        [Fact]
        public void Test_Roman_Repition()
        {
            var rNum = new RomNum();
            int input = 4;
            rNum.Conv(input);
            Assert.Equal("IIII", rNum.Repition(input));
        }

        [Fact]
        public void Test_Roman_Numeral_Conversion_Construction()
        {
            var rNum = new RomNum();
            int input = 900;

            rNum.Conv(input);

            Assert.Equal("CM", rNum.Subtract(input));
        }
    }
}


