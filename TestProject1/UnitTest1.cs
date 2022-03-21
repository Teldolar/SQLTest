using System;
using System.Data;
using System.IO;
using Aquality.Selenium.Browsers;
using MySql.Data.MySqlClient;
using NUnit.Framework;
using TestProject1.Utils;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void DbTest()
        {
            LogUtil.WriteTableToTxtFile(SqlUtil.GetTableBySqlRequest("FindMinTime.sql"),@"..\..\..\FindMinTimeResult.txt");
            LogUtil.WriteTableToTxtFile(SqlUtil.GetTableBySqlRequest("FindUniqueTestCount.sql"),@"..\..\..\FindUniqueTestCountResult.txt");
            LogUtil.WriteTableToTxtFile(SqlUtil.GetTableBySqlRequest("TestsBeforeDate.sql"),@"..\..\..\TestsBeforeDateResult.txt");
            LogUtil.WriteTableToTxtFile(SqlUtil.GetTableBySqlRequest("FirefoxAndChromeTestCount.sql"),@"..\..\..\FirefoxAndChromeTestCountResult.txt");
        }
    }
}