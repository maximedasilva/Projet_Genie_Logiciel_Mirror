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
    public class ProblemsTests
    {
        [TestMethod()]
        public void ProblemsTest()
        {
            var p = new Presenter(new View());
            var t=new Problems(p, DifficultyLevel.Easy, ProblemType.Mathematic);
            Assert.AreEqual(t.Consigne, "Dans ce test vous devez répondre à un QCM. Les mauvaises réponses ne font pas perdre de point");
            Assert.AreEqual(t.myPresenter, p);
            Assert.AreEqual(t.goodAnswer, 0);
        }


    }
}