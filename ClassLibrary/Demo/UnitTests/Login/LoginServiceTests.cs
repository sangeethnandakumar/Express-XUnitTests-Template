using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.UnitTests.Login
{
    //TEST DRIVEN DEVELOPMENT
    public class LoginServiceTests
    {
        //Naming Convention
        private void Methord_Scenerio_ExpectedBehavior()
        {
            //Arrange
            //Act
            //Assert
            //Assert
        }


        //Arrange Test Data
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { true, new Credential("sangeeth", "sangee") };
            yield return new object[] { true, new Credential("navaneeth", "navu") };
            yield return new object[] { true, new Credential("surya", "surya") };
            yield return new object[] { true, new Credential("nandakumar", "nandu") };
            yield return new object[] { false, new Credential("admin", "test") };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void PerformLogin_TestData_ReturnStatus(object expected, params Credential[] args)
        {
            //Act
            var loginService = new LoginService();
            foreach (var arg in args)
            {
                var result = loginService.PerformLogin(arg);
                //Assert
                Assert.Equal(expected, result);
            }
        }

        [Fact(Skip = "It's buggy can't test until fixed monday")]
        public void PerformLogin_VaidCredential_ReturnTrue()
        {
            var loginService = new LoginService();
            var isLoggedIn = loginService.PerformLogin(new Credential("sangeeth", "sangee"));
            Assert.True(isLoggedIn);
        }

    }
}
