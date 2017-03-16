using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diver_Contest;


namespace Test_Admin_base
{
    [TestClass]
    public class UnitTestJudge
    {
        [TestMethod]
        public void databaseInit()
        {
            // Test if connection can be established.
            Assert.AreEqual(Mysql_db.connect(), true);

            // Test command
            string command = "SELECT * FROM Divers";

            // Execute command
            try
            {
                Mysql_db.execute(command);
                Assert.AreEqual(1, 1);
            }
            catch
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void generateCompetition()
        {
            Competition competition1 = new Competition();
            string timeStamp = Stopwatch.GetTimestamp().ToString();

            competition1.id = 1;
            competition1.date = timeStamp;

            // Check if date has been inserted into field.
            Assert.AreNotEqual(competition1.date, "");

            //Creating new Divers
            Diver diver1 = new Diver();
            Diver diver2 = new Diver();

            diver1.id = 1;
            diver1.name = "Ahmed";
            diver1.country = "Sweden";
            diver1.competition = competition1.id;

            diver2.id = 2;
            diver2.name = "Peter";
            diver2.country = "Sweden";
            diver2.competition = competition1.id;

            // Add divers to contest using addDiver.
            competition1.addDiver(diver1);
            competition1.addDiver(diver2);

            // Check diver1 information
            Assert.AreEqual(diver1.name, "Ahmed");
            Assert.AreEqual(diver1.country, "Sweden");
            // Check diver1 competition
            Assert.AreEqual(diver1.competition, competition1.id);

            // Check diver2 information
            Assert.AreEqual(diver2.name, "Peter");
            Assert.AreEqual(diver2.country, "Sweden");
            // Check diver2 competition
            Assert.AreEqual(diver2.competition, competition1.id);

            //Creating new Judges
            Judge judge1 = new Judge();
            Judge judge2 = new Judge();
            Judge judge3 = new Judge();

            judge1.id = 1;
            judge1.name = "Judy";
            judge1.competition = competition1.id;

            judge1.id = 2;
            judge1.name = "Tupac";
            judge1.competition = competition1.id;

            judge3.id = 3;
            judge3.name = "Xweri";
            judge3.competition = competition1.id;

            //Simulate one jump each for each diver.
            diver1.jumpTest();
            diver2.jumpTest();

            // Rate jumps
            judge1.rate(diver1.jumps[0], 10);
            judge2.rate(diver1.jumps[0], 6.5);
            judge3.rate(diver1.jumps[0], 5);

            judge1.rate(diver2.jumps[0], 5);
            judge2.rate(diver2.jumps[0], 0);
            judge3.rate(diver2.jumps[0], 7.5);

            // Check if diver1 jump1 recieved grade.
            Assert.AreEqual(diver1.jumps[0].grade[0].Item2, 10);
            Assert.AreEqual(diver1.jumps[0].grade[1].Item2, 6.5);
            Assert.AreEqual(diver1.jumps[0].grade[2].Item2, 5);

            // Check if diver2 jump recieved grade.
            Assert.AreEqual(diver2.jumps[0].grade[0].Item2, 5);
            Assert.AreEqual(diver2.jumps[0].grade[1].Item2, 0);
            Assert.AreEqual(diver2.jumps[0].grade[2].Item2, 7.5);

            //Simulate another jump each for each diver.
            diver1.jumpTest();
            diver2.jumpTest();

            // Rate jumps
            judge1.rate(diver1.jumps[1], 9);
            judge2.rate(diver1.jumps[1], 2.5);
            judge3.rate(diver1.jumps[1], 5);

            judge1.rate(diver2.jumps[1], 1);
            judge2.rate(diver2.jumps[1], 10);
            judge3.rate(diver2.jumps[1], 7.5);

            // Check if diver1 jump1 recieved grade.
            Assert.AreEqual(diver1.jumps[1].grade[0].Item2, 9);
            Assert.AreEqual(diver1.jumps[1].grade[1].Item2, 2.5);
            Assert.AreEqual(diver1.jumps[1].grade[2].Item2, 5);

            // Check if diver2 jump recieved grade.
            Assert.AreEqual(diver2.jumps[1].grade[0].Item2, 1);
            Assert.AreEqual(diver2.jumps[1].grade[1].Item2, 10);
            Assert.AreEqual(diver2.jumps[1].grade[2].Item2, 7.5);

            // Check if total grade is accurate.
            Assert.AreNotEqual(diver1.sumGrades, 28);
            Assert.AreNotEqual(diver2.sumGrades, 16);
            // Calculate sum of diver points
            diver1.calcSum(2);
            diver2.calcSum(2);

            // End event and check winner
            //Assert.AreEqual(competition1.end(), diver1.sumGrades);
        }
    }
}
