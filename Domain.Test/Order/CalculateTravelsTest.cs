using Domain.Order;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Test.Order
{
    [TestClass]
    public class CalculateTravelsTest
    {
        [TestMethod]
        public void calculateTest()
        {
            // Arrange
            RawInfo rawInfo = new RawInfo();
            rawInfo.WorkDays = 5;
            rawInfo.ElementValue = new List<int>();
            rawInfo.ElementValue.Add(4);

            rawInfo.ElementValue.Add(100);
            rawInfo.ElementValue.Add(30);
            rawInfo.ElementValue.Add(1);
            rawInfo.ElementValue.Add(1);

            rawInfo.ElementValue.Add(3);

            rawInfo.ElementValue.Add(20);
            rawInfo.ElementValue.Add(20);
            rawInfo.ElementValue.Add(20);

            rawInfo.ElementValue.Add(11);

            rawInfo.ElementValue.Add(1);
            rawInfo.ElementValue.Add(2);
            rawInfo.ElementValue.Add(3);
            rawInfo.ElementValue.Add(4);
            rawInfo.ElementValue.Add(5);
            rawInfo.ElementValue.Add(6);
            rawInfo.ElementValue.Add(7);
            rawInfo.ElementValue.Add(8);
            rawInfo.ElementValue.Add(9);
            rawInfo.ElementValue.Add(10);
            rawInfo.ElementValue.Add(11);

            rawInfo.ElementValue.Add(6);

            rawInfo.ElementValue.Add(9);
            rawInfo.ElementValue.Add(19);
            rawInfo.ElementValue.Add(29);
            rawInfo.ElementValue.Add(39);
            rawInfo.ElementValue.Add(49);
            rawInfo.ElementValue.Add(59);

            rawInfo.ElementValue.Add(10);

            rawInfo.ElementValue.Add(32);
            rawInfo.ElementValue.Add(56);
            rawInfo.ElementValue.Add(76);
            rawInfo.ElementValue.Add(8);
            rawInfo.ElementValue.Add(44);
            rawInfo.ElementValue.Add(60);
            rawInfo.ElementValue.Add(47);
            rawInfo.ElementValue.Add(85);
            rawInfo.ElementValue.Add(71);
            rawInfo.ElementValue.Add(91);



            CalculateTravels calculateTravels = new CalculateTravels();
            List<Output> output = calculateTravels.calculate(rawInfo);
            Assert.AreEqual(rawInfo.WorkDays, output.Count);
            Assert.AreEqual("Case #1: 2", output[0].CaseDay + ": " + output[0].NumberMaxTravels);
            Assert.AreEqual("Case #2: 1", output[1].CaseDay + ": " + output[1].NumberMaxTravels);
            Assert.AreEqual("Case #3: 2", output[2].CaseDay + ": " + output[2].NumberMaxTravels);
            Assert.AreEqual("Case #4: 3", output[3].CaseDay + ": " + output[3].NumberMaxTravels);
            Assert.AreEqual("Case #5: 5", output[4].CaseDay + ": " + output[4].NumberMaxTravels);

        }

        [TestMethod]
        public void calculateConstrainsWorkDaystLessThanZeroTest()
        {
            // Arrange
            RawInfo rawInfo = new RawInfo();
            rawInfo.WorkDays = 0;
            

            CalculateTravels calculateTravels = new CalculateTravels();
            List<Output> output = calculateTravels.calculate(rawInfo);
            Assert.AreEqual(0, output.Count);            
        }

        [TestMethod]
        public void calculateConstrainsWorkDaysGreaterThanFiveHundredTest()
        {
            // Arrange
            RawInfo rawInfo = new RawInfo();
            rawInfo.WorkDays = 501;


            CalculateTravels calculateTravels = new CalculateTravels();
            List<Output> output = calculateTravels.calculate(rawInfo);
            Assert.AreEqual(0, output.Count);
        }

        [TestMethod]
        public void calculateConstrainsElementsValuesGreaterThanFiveHundredTest()
        {
            // Arrange
            // Arrange
            RawInfo rawInfo = new RawInfo();
            rawInfo.WorkDays = 1;
            rawInfo.ElementValue = new List<int>();
            rawInfo.ElementValue.Add(4);

            rawInfo.ElementValue.Add(130);
            rawInfo.ElementValue.Add(30);
            rawInfo.ElementValue.Add(1);
            rawInfo.ElementValue.Add(1);


            CalculateTravels calculateTravels = new CalculateTravels();
            List<Output> output = calculateTravels.calculate(rawInfo);
            Assert.AreEqual("Case #1: 0", output[0].CaseDay + ": " + output[0].NumberMaxTravels);
        }
    }
}
