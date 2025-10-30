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
        public void Test_Roman_Numeral_Negative()
        {
            var rNum = new RomNum();
            int input = -1;

            Assert.Equal("Not in range", rNum.InRang(input));
        }

        [Fact]
        public void Test_Roman_Numeral_Negative3000()
        {
            var rNum = new RomNum();
            int input = -3000;

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
        public void Test_Roman_Numeral_1000()
        {
            var rNum = new RomNum();
            int input = 1000;

            rNum.Conv(input);

            Assert.Equal("M", rNum.Conv(input));
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
        public void Test_Roman_Numeral_RND_number()
        {
            var rNum = new RomNum();
            int input = 1984;

            rNum.Conv(input);

            Assert.Equal("MCMLXXXIV", rNum.Conv(input));
        }



        [Fact]
        public void Test_Roman_Repition()
        {
            var rNum = new RomNum();
            int input = 4;
            rNum.Conv(input);
            Assert.Equal("Error: More than 3 repetitions", rNum.Repition(input));
        }

        [Fact]
        public void Test_Roman_Numeral_Conversion_Construction()
        {
            var rNum = new RomNum();
            int input = 900;

            rNum.Conv(input);

            Assert.Equal("CM", rNum.Subtract(input));
        }

        [Fact]
        public void Test_Roman_Numeral_Reverse()
        {
            var rNum = new RomNum();
            int input = 1984;

            Assert.Equal("Symbols in the wrong order", rNum.ConvertToRoman(input));
        }
    }
}


