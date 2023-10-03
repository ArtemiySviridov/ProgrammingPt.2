using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Automobile_Class;

namespace UnitTestAutomobile
{
    [TestClass]
    public class UnitTestAuto
    {
        Automobile car;
        [TestInitialize]
        public void Init() 
        {
             car = new Automobile("Audi", "TT", 2006, 2023, "Bob");
        }  

        [TestMethod]
        public void Sum_500and1000and300_1800returned()
        {
            int firstpay = 500;
            int secondpay = 1000;
            int thirdpay = 300;
            int expected = 1800;

            
            int actual = car.SumFines(firstpay, secondpay, thirdpay);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_minus1_messagereturn()
        {
            car.DiagnosticYear = -1;
            string expected = "Вы не проходили ТО! Пройдите прямо сейчас.";

            string actual = car.DiagnosticYearEntered(car.DiagnosticYear);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_0_falsereturned()
        {
            int scrapped = 0;

            bool actual = car.ScrapAutomobile(scrapped);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Check_1000_0returned()
        {
            int expected = 0;

            int actual = car.RightReleaseYear();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Finesum_minus1000_Errorreturned() 
        {
            int finesum = -1000;

            Assert.ThrowsException<ArgumentException>(() => car.WrongFineSum(finesum));
        }
    }
}
