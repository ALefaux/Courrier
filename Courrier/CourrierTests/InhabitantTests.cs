using Microsoft.VisualStudio.TestTools.UnitTesting;
using pqtcity;
using pqtcourrier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcity.Tests
{
    [TestClass()]
    public class InhabitantTests
    {
        City objCity;
        [TestMethod()]
        public void InhabitantTest()
        {
            objCity = new City("Starling");

            Assert.AreEqual(100, objCity.getNumberOfInhabitants());
        }

        [TestMethod()]
        public void createSimpleLetterTest()
        {
            objCity = new City("Starling");

            objCity.listHabitant[0].createSimpleLetter(objCity.listHabitant[1], "bla bla");

            Assert.AreEqual(1, objCity.getNumberOfLetter());
            Assert.AreEqual("a simple letter", objCity.objPostBox.listCourrierReceive[0].getDescription());
        }

        [TestMethod()]
        public void createUrgentLetterTest()
        {
            objCity = new City("Starling");

            objCity.listHabitant[0].createUrgentLetter(objCity.listHabitant[1], new SimpleLetter(new Sender(objCity.listHabitant[0]), new Receiver(objCity.listHabitant[1]), "bla bla"));

            Assert.AreEqual(1, objCity.getNumberOfLetter());
            Assert.AreEqual("an urgent letter", objCity.objPostBox.listCourrierReceive[0].getDescription());
        }

        [TestMethod()]
        public void createPromissoryNoteTest()
        {
            objCity = new City("Starling");

            objCity.listHabitant[0].createPromissoryNote(objCity.listHabitant[1], 5);

            Assert.AreEqual(1, objCity.getNumberOfLetter());
            Assert.AreEqual("a promissory note letter", objCity.objPostBox.listCourrierReceive[0].getDescription());
        }

        [TestMethod()]
        public void createRegisteredLetterTest()
        {
            objCity = new City("Starling");

            objCity.listHabitant[0].createRegisteredLetter(objCity.listHabitant[1], new SimpleLetter(new Sender(objCity.listHabitant[0]), new Receiver(objCity.listHabitant[1]), "bla bla"));

            Assert.AreEqual(1, objCity.getNumberOfLetter());
            Assert.AreEqual("a registered letter", objCity.objPostBox.listCourrierReceive[0].getDescription());
        }

        [TestMethod()]
        public void createThanksLetterTest()
        {
            objCity = new City("Starling");

            objCity.listHabitant[0].createThanksLetter(objCity.listHabitant[1], "bla bla");

            Assert.AreEqual(1, objCity.getNumberOfLetter());
            Assert.AreEqual("a thanks letter", objCity.objPostBox.listCourrierReceive[0].getDescription());
        }

        [TestMethod()]
        public void createAcknowledgmentTest()
        {
            objCity = new City("Starling");

            objCity.listHabitant[0].createAcknowledgment(objCity.listHabitant[1], "bla bla");

            Assert.AreEqual(1, objCity.getNumberOfLetter());
            Assert.AreEqual("an acknowledgment of receipt", objCity.objPostBox.listCourrierReceive[0].getDescription());
        }

        [TestMethod()]
        public void getCityTest()
        {
            objCity = new City("Starling");

            City checkCity = objCity.listHabitant[0].getCity();

            Assert.IsNotNull(checkCity);
            Assert.AreEqual("Starling", checkCity.getNameCity());
        }
    }
}