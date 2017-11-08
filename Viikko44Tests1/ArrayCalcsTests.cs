using Microsoft.VisualStudio.TestTools.UnitTesting;
using Viikko44;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko44.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        double[] array12 = {};
        [TestMethod()]
        public void Sum1Test()
        {
            ArrayCalcs.Sum1(array12);
        }

        [TestMethod()]
        public void AveTest()
        {
            ArrayCalcs.Ave(array12);
        }

        [TestMethod()]
        public void MinimiTest()
        {
            ArrayCalcs.Minimi(array12);
        }

        [TestMethod()]
        public void MaximiTest()
        {
            ArrayCalcs.Maximi(array12);
        }
    }
}