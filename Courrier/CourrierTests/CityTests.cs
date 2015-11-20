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
    public class CityTests
    {
        City objCity;

        [TestMethod()]
        public void CityTest()
        {
            objCity = new City("Starling");
            Assert.IsNotNull(objCity);
        }

        [TestMethod()]
        public void sendLetterTest()
        {
            objCity = new City("Starling");
            Letter objLetter = new SimpleLetter(new Sender(objCity.listHabitant[0]), new Receiver(objCity.listHabitant[1]), "bla bla");
            objCity.sendLetter(objLetter);

            Assert.AreEqual(1, objCity.getNumberOfLetter());
        }

        [TestMethod()]
        public void distributeLettersTest()
        {
            objCity = new City("Starling");
            Letter objLetter = new SimpleLetter(new Sender(objCity.listHabitant[0]), new Receiver(objCity.listHabitant[1]), "bla bla");
            objCity.sendLetter(objLetter);

            Assert.AreEqual(1, objCity.getNumberOfLetter());

            objCity.distributeLetters();

            Assert.AreEqual(0, objCity.getNumberOfLetter());

        }

        [TestMethod()]
        public void getNameCityTest()
        {
            objCity = new City("Starling");
            Assert.AreEqual("Starling", objCity.getNameCity());
        }

        [TestMethod()]
        public void getNumberOfInhabitantsTest()
        {
            objCity = new City("Starling");
            Assert.AreEqual(100, objCity.getNumberOfInhabitants());
        }
    }
}