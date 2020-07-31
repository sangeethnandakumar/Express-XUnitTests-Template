using ClassLibrary;
using System;
using System.Data.SqlClient;
using Xunit;

namespace Demo.Fixtures
{
    [CollectionDefinition("LoginFixture")]
    public class LoginFixture : IClassFixture<LoginFixture>, IDisposable
    {
        public SqlConnection Db { get; private set; }
        public Credential Credential { get; set; }
        public LoginService LoginService { get; set; }

        public LoginFixture()
        {
            LoginService = new LoginService();
            //Db = new SqlConnection("MyConnectionString");
            // initialize data in the test database
        }

        public void SetupTestdataOnDatabase()
        {

        }

        public void Dispose()
        {
            // clean up test data from the database
        }
    }
}
