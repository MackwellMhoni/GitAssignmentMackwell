namespace RomanNumeralTest
{
    public class RomNumUnitTest
    {
        [Fact]
        public void Test_Roman_Numeral_Conversion()
        {
            var rNum = new RomNum();

            rNum.Conv(0);

            Assert.Equal(0, rNum.Results());
        }
    }
}
