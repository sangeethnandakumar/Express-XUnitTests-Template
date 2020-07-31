using ClassLibrary;
using Demo.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace Demo.IntegrationTests
{
    [Collection("LoginFixture")]
    public class Login
    {
        private readonly LoginFixture _login;
        private readonly ITestOutputHelper _output;

        public Login(ITestOutputHelper outputHelper, LoginFixture login)
        {
            _output = outputHelper;
            _login = login;
        }
        

        [Fact]
        public void Step1_SetupCredential()
        {
            //Create credential
            _login.Credential = new Credential("sangeeth", "sangee");
            _output.WriteLine($"Step1 - Created new credential");
        }

        [Fact]
        public void Step2_SetupDatabase()
        {
            //Setup database
            _login.SetupTestdataOnDatabase();
            _output.WriteLine($"Step2 - Setup database");
        }

        [Fact]
        public void Step3_TryLoggingIn()
        {
            //Try to login
            var result = _login.LoginService.PerformLogin(_login.Credential);
            Assert.True(result);
            _output.WriteLine($"Step3 - Login : {result}");
        }
    }
}
