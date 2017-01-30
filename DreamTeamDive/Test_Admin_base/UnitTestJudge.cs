using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Admin_base;
using Member_base;

namespace Test_Admin_base
{
    [TestClass]
    public class UnitTestJudge
    {
        [TestMethod]
        public void connectToServer()
        {
            Mysql_db.init();

            Assert.AreEqual(Mysql_db.connect(), true);
        }

        [TestMethod]
        public void generateCompetition()
        {
            Competition competition1 = new Competition();
            string timeStamp = Stopwatch.GetTimestamp().ToString();

            competition1.date = timeStamp;

            // Check if date has been inserted into field.
            Assert.AreNotEqual(competition1.date, "");
            
            
            Assert.AreEqual(1, 1);
        }

    }
}
