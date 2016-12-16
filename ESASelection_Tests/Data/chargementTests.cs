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
    public class chargementTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            chargement c= new chargement(1, "e", "1", "2", "3", "4", "br", "chemin");
            Assert.AreEqual(c.ToString(), "ID : 1\nEnonce : e\nReponse 1 : 1\nReponse 2 : 2\nReponse 3 : 3\nReponse 4 : 4\nBonne reponse : br");
        }
        [TestMethod()]
        public void chargementTest()
        {
            chargement c = new chargement(1, "e", "1", "2", "3", "4", "br", "chemin");
            Assert.AreEqual(c.iD, 1);
            Assert.AreEqual(c.reponse1, "1");
            Assert.AreEqual(c.reponse2, "2");
            Assert.AreEqual(c.reponse3, "3");
            Assert.AreEqual(c.reponse4, "4");
            Assert.AreEqual(c.bonneReponse, "br");
            Assert.AreEqual(c.cheminImage, "chemin");
        }
    }
}