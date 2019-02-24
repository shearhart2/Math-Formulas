using Microsoft.VisualStudio.TestTools.UnitTesting;
using exercise1A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1A.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Circ_CircTest()
        {
            Assert.AreEqual(Math.PI * 4, Program.Circ_Circ(2));
        }

        [TestMethod()]
        public void Area_CircTest()
        {
            Assert.AreEqual(Math.PI * 4, Program.Area_Circ(2));
        }

        [TestMethod()]
        public void VolumeOfHemisphereTest()
        {
            Assert.AreEqual(4.0 / 3 * Math.PI * 8 / 2, Program.VolumeOfHemisphere("2"));
        }

        [TestMethod()]
        public void AreaOfTriangleTest()
        {
            Assert.AreEqual(Convert.ToInt32(Math.Sqrt(0)), Program.AreaOfTriangle(6, 2, 4, 6));
        }

        [TestMethod()]
        public void HeronFormulaTest()
        {
            Assert.AreEqual(23, Program.HeronFormula(2, 36, 8));
        }

        [TestMethod()]
        public void ConvertNumberTest()
        {
            Assert.AreEqual(5, Program.ConvertNumber("5"));
        }

        [TestMethod()]
        public void NegQuadraticEquationTest()
        {
            Assert.AreEqual(-9 - Math.Sqrt(77), Program.NegQuadraticEquation(2, 36, 8));
        }

        [TestMethod()]
        public void PosQuadraticEquationTest()
        {
            Assert.AreEqual(-9 + Math.Sqrt(77), Program.PosQuadraticEquation(2, 36, 8));
        }

        [TestMethod()]
        public void NoImaginationTest()
        {
            Assert.AreEqual(1232, Program.NoImagination(2,36,8));
        }
    }
}