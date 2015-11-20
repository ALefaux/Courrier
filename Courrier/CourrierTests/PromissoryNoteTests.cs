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
    public class PromissoryNoteTests
    {
        City objCity;
        [TestMethod()]
        public void executeContentTest()
        {
            objCity = new City("Starling");

            PromissoryNote objPromissoryNote = new PromissoryNote(new Sender(objCity.listHabitant[0]), new Receiver(objCity.listHabitant[1]), 50);
            objPromissoryNote.executeContent();
        }
    }
}