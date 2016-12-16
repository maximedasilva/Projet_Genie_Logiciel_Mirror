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
    public class MemoryTests
    {
        [TestMethod()]
        public void MemoryTest()
        {
            Presenter p = new Presenter(new View());
            Memory m = new Memory(p, DifficultyLevel.hard);
            Assert.AreEqual(m.Difficulty, DifficultyLevel.hard);
            Assert.AreEqual(m.Consigne, "Dans cet exercice vous devrez identifier les chiffres contenus dans une forme et une couleur donnée et les restituer dans l'ordre");
            Assert.AreEqual(m.goodAnswer, 0);
            Assert.AreEqual(m.numberOfTest, 0);
            Assert.AreEqual(m.myPresenter, p);
            
        }
    }
}