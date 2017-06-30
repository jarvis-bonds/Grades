using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grade.Test.Types
{
    [TestClass]
    public class Types
    {
        [TestMethod]
        public void GradeBookVariablesHoldReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Jarvis Grade Book";

            Assert.AreEqual(g1.Name, g2.Name);
        }

        [TestMethod]
        public void InVariableHoldValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            Assert.AreNotEqual(x1, x2);
        }
    }
}
