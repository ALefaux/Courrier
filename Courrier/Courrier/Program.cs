using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pqtcity;
using pqtcourrier;

namespace pqtmain
{
    class Courrier
    {
        static void Main(string[] args)
        {
            City objCity = new City("Straling");
            Console.WriteLine("Mailing letters for 6 days");

            //DAY 1
            Console.WriteLine("************************************************************");
            Console.WriteLine("Day 1");
            objCity.listHabitant[16].createUrgentLetter(objCity.listHabitant[0], new SimpleLetter(new Sender(objCity.listHabitant[16]), new Receiver(objCity.listHabitant[0]), "bla bla")) ;
            objCity.listHabitant[34].createSimpleLetter(objCity.listHabitant[9], "bla bla");
            objCity.listHabitant[45].createPromissoryNote(objCity.listHabitant[8], 18);
            objCity.listHabitant[86].createPromissoryNote(objCity.listHabitant[49], 94);
            objCity.listHabitant[34].createSimpleLetter(objCity.listHabitant[24], "bla bla");

            //DAY 2
            Console.WriteLine("************************************************************");
            Console.WriteLine("Day 2");
            objCity.objPostBox.distributeCourrier();
            objCity.listHabitant[86].createPromissoryNote(objCity.listHabitant[27], 731);
            objCity.listHabitant[61].createRegisteredLetter(objCity.listHabitant[54], new SimpleLetter(new Sender(objCity.listHabitant[61]), new Receiver(objCity.listHabitant[54]), "bla bla"));
            objCity.listHabitant[32].createUrgentLetter(objCity.listHabitant[40], new RegisteredLetter(new Sender(objCity.listHabitant[32]), new Receiver(objCity.listHabitant[40]), new SimpleLetter(new Sender(objCity.listHabitant[32]), new Receiver(objCity.listHabitant[40]), "bla bla")));

            //DAY 3
            Console.WriteLine("************************************************************");
            Console.WriteLine("Day 3");
            objCity.objPostBox.distributeCourrier();

            int i = 0;
            i = i + 1;
        }
    }
}
