using Problem;
namespace PasswordTestCases
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("absc",false)]
        [InlineData("absc1Dfew", true)]
        [InlineData("abscsad2", false)]
        [InlineData("abscsdadD", false)]
        [InlineData("absccxzzc", false)]
        [InlineData("ABCDEFG1", false)]
        public void PasswordTest(String password, Boolean expected)
        {
            var actual = PasswordVerify.IsPasswordValid(password);
            Assert.Equal(expected, actual);
        }
    }
}