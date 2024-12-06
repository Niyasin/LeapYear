namespace LeapYear
{
    public class LeapYearShould
    {
        [Theory]
        [InlineData(2024)]
        [InlineData(2028)]
        [InlineData(2032)]
        [InlineData(2036)]
        [InlineData(2000)]
        [InlineData(2400)]
        [InlineData(2800)]
        [InlineData(3200)]
        public void ShouldReturnFalseForLeapYears(int year)
        {
            bool result = LeapYear.IsLeapYear(year);
            Assert.True(result);
        }

        [Theory]
        [InlineData(2001)] 
        [InlineData(2002)]
        [InlineData(2100)]
        [InlineData(2200)]
        [InlineData(2300)]
        [InlineData(2500)]
        public void ShouldReturnFalseForCommonYear(int year)
        {
            bool result = LeapYear.IsLeapYear(year);
            Assert.False(result);
        }
    }

    public class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0) {
                if(year % 100 == 0 && year %400 != 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}