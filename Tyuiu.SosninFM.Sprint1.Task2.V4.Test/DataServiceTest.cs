using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SosninFM.Sprint1.Task2.V4.Lib;

namespace Tyuiu.SosninFM.Sprint1.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()

        {
            DataService dataService = new DataService();
            int x = 2;
            var res = dataService.CalculateSquare(x);
            Assert.AreEqual(4, res);

        }
    }
}
