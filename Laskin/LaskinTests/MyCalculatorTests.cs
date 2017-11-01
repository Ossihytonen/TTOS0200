using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laskin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laskin.Tests
{
    [TestClass()]
    public class MyCalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //testataan MyCal - luokan Add- methodia , AAA-malli
            int i = 10;
            int j = 12;
            int tulos = 22;
            MyCalculator laskin = new MyCalculator();
            //Act
            int summa = laskin.Add(i, j);
            //Assert
            Assert.AreEqual(tulos, summa);
            //Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //testataan MyCal - luokan Add- methodia , AAA-malli
            int i = 10;
            int j = 12;
            int tulos = 120;
            MyCalculator laskin = new MyCalculator();
            //Act
            int summa = laskin.Multiply(i, j);
            //Assert
            Assert.AreEqual(tulos, summa);
            //Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest()
        {
            //testataan MyCal - luokan Add- methodia , AAA-malli
            int i = 24;
            int j = 0;
            int odotettu = 1;
            MyCalculator laskin = new MyCalculator();
            //Act
            try
            {
                int jako = laskin.Divide(i, j);
                Assert.AreEqual(odotettu, jako);
            }
            catch (DivideByZeroException)
            {

            }
            catch(Exception)
            {
                Assert.Fail();
            }
            //Assert
            //Assert.AreEqual(odotettu, jako);
            //Assert.Fail();
        }
    }
}