using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SolidProblems.SingleResponsibilityPrinciple;
using SolidProblems.SingleResponsibilityPrincipleError;

namespace SolidProblems.Tests
{
    class DataBaseWorkerTests
    {
        [Test]
        public void TestConnect()
        {
            DataBaseWorker dbworker = new DataBaseWorker
                ("localhost", 3306, "sakila", "user", "password");
            var names = dbworker.GetAllNames();
            Assert.AreEqual(200, names.Count);
        }

        [Test]
        public void TestTrueConnect()
        {
            DataBaseConnector dbworker = new DataBaseConnector
                ("localhost", 3306, "sakila", "user", "password");
            var names = DataBaseGateways.GetAllNames(dbworker.GetConnection());
            Assert.AreEqual(200, names.Count);
        }
    }
}
