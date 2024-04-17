using Microsoft.VisualStudio.TestTools.UnitTesting;
using MeasurementsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementsLib.Tests
{
    [TestClass()]
    public class MeasurementTests
    {
        [TestMethod()]
        public void ValidatePpmTest()
        {
            Measurement measurement1 = new Measurement(1, 720);
            
            measurement1.ValidatePpm();

            Measurement measurement2 = new Measurement(2, 0);
           
            measurement2.ValidatePpm();

            Measurement measurement3 = new Measurement(3, -1);
            
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => measurement3.ValidatePpm());
        }
    }
}