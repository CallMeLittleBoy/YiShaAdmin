using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using YiSha.Util;
using YiSha.Util.Model;

namespace YiSha.DataTest
{
    [SetUpFixture]
    public class SetupFixture
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            GlobalContext.SystemConfig = new SystemConfig
            {
                DBProvider = "SqlServer",
                DBConnectionString = "server=localhost;database=YiShaAdmin;user=sa;password=123456;",
                //DBConnectionString = "server=localhost;database=YiShaAdmin;user=sa;password=123456;port=3306;",
                DBCommandTimeout = 180,
                DBBackup = "DataBase"
            };
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }
    }
}
