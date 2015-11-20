using Microsoft.VisualStudio.TestTools.UnitTesting;
using pqtcourrier;
using pqtcity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcourrier.Tests
{
    [TestClass()]
    public class RegisteredLetterTests
    {
        City objCity;
        RegisteredLetter objRegisteredLetter;

        [TestMethod()]
        public void executeContentTest()
        {
            objCity = new City("Starling");
            objRegisteredLetter = new RegisteredLetter(new Sender(objCity.listHabitant[0]), new Receiver(objCity.listHabitant[1]), new SimpleLetter(new Sender(objCity.listHabitant[0]), new Receiver(objCity.listHabitant[1]), "bla bla"));

            objRegisteredLetter.executeContent();
        }
    }
}