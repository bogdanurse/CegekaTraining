using Microsoft.VisualStudio.TestTools.UnitTesting;
using Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects.Tests
{
    [TestClass()]
    public class PointTests
    {
        [TestMethod()]
        public void DistanceToTest()
        {
            Point punctA = new Point(1, 3);
            Point punctB = new Point(2, 4);

            Assert.AreEqual(punctA.DistanceTo(punctB), 1,4142135623731);
            
        }
    }
}