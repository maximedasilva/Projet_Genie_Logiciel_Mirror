using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESASelection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESASelection.Tests
{
    [TestClass()]
    public class CalculTests
    {
        [TestMethod()]
        public void CalculTest()
        {
            Presenter p = new Presenter(new View());
            Calcul c = new Calcul(p, DifficultyLevel.Easy);
            Assert.AreEqual(DifficultyLevel.Easy, c.Difficulty);
            Assert.AreEqual(c.myPresenter, p);
            Assert.AreEqual(c.Consigne, " Dans ce test vous devez résoudre des opération mentalement");
        }

    }
}