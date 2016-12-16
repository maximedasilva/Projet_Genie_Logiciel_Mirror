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
    public class AttentionTests
    {
        [TestMethod()]
        public void AttentionTest()
        {
            Presenter p = new Presenter(new View());
            Attention t = new Attention(p, DifficultyLevel.hard);
            Assert.AreSame(p, t.myPresenter);
            Assert.AreEqual(t.goodAnswer, 0);
            Assert.AreEqual(t.Consigne, " PLusieurs objets vont apparaitre ainsi que 3 boutons,\nl'objectif est de reconnaitre les similitudes entre deux objets consécutifs.\n Il y a 3 boutons avec chacun une règle qui change d'une série à une autre.\n Ces règles seront énoncées entre chaque série\n Regles : \n\nmême couleur\nmême nombre de points\nmême forme");
        }
    }
}