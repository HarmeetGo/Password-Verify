using Problem;
namespace PasswordTestCases
{
    public class PasswordVerifyFixture
    {




        [Theory]

        [InlineData("absc1Dfew")]
        [InlineData("absc")]
        [InlineData("abscsad2")]
        [InlineData("abscsdadD")]
        [InlineData("absccxzzc")]
        [InlineData("ABCDEFG1")]
        [InlineData("ABCDEFGH")]
        [InlineData("ABC")]
        [InlineData("Abcd12Dss")]
        public void IsPasswordValid_InvalidPassword_ThrowsError(String password)
        {
            Assert.Throws<Exception>(() => PasswordVerify.IsPasswordValid(password));
        }


        //public void IsPasswordValid_ValidPassword_ReturnsTrue()
        //{
        //    String validPassword = "passWord1";
        //    var actual = PasswordVerify.IsPasswordValid(validPassword); 
        //    Assert.True(actual);
        //}
        //public void PasswordTest(String password, Boolean expected)
        //{
        //    var actual = PasswordVerify.IsPasswordValid(password);
        //    Assert.Equal(expected, actual);
        //}
    }
}