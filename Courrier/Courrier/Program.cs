using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pqtcity;
using pqtcourrier;

namespace pqtmain
{
    public class Courrier
    {
        public static void Main(string[] args)
        {
            //* Pour effectuer les tests
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
            objCity.distributeLetters();
            objCity.listHabitant[86].createPromissoryNote(objCity.listHabitant[27], 731);
            objCity.listHabitant[61].createRegisteredLetter(objCity.listHabitant[54], new SimpleLetter(new Sender(objCity.listHabitant[61]), new Receiver(objCity.listHabitant[54]), "bla bla"));
            objCity.listHabitant[32].createUrgentLetter(objCity.listHabitant[40], new RegisteredLetter(new Sender(objCity.listHabitant[32]), new Receiver(objCity.listHabitant[40]), new SimpleLetter(new Sender(objCity.listHabitant[32]), new Receiver(objCity.listHabitant[40]), "bla bla")));

            //DAY 3
            Console.WriteLine("************************************************************");
            Console.WriteLine("Day 3");
            objCity.distributeLetters();
            objCity.listHabitant[23].createSimpleLetter(objCity.listHabitant[5], "bla bla");
            objCity.listHabitant[65].createSimpleLetter(objCity.listHabitant[88], "bla bla");
            objCity.listHabitant[34].createUrgentLetter(objCity.listHabitant[52], new SimpleLetter(new Sender(objCity.listHabitant[34]), new Receiver(objCity.listHabitant[52]), "bla bla"));

            //DAY 4
            Console.WriteLine("************************************************************");
            Console.WriteLine("Day 4");
            objCity.distributeLetters();
            objCity.listHabitant[38].createSimpleLetter(objCity.listHabitant[54], "bla bla");
            objCity.listHabitant[21].createUrgentLetter(objCity.listHabitant[55], new RegisteredLetter(new Sender(objCity.listHabitant[21]), new Receiver(objCity.listHabitant[55]), new PromissoryNote(new Sender(objCity.listHabitant[21]), new Receiver(objCity.listHabitant[55]), 714)));
            objCity.listHabitant[46].createUrgentLetter(objCity.listHabitant[10], new PromissoryNote(new Sender(objCity.listHabitant[46]), new Receiver(objCity.listHabitant[10]), 128));

            //DAY 5
            Console.WriteLine("************************************************************");
            Console.WriteLine("Day 5");
            objCity.distributeLetters();
            objCity.listHabitant[43].createSimpleLetter(objCity.listHabitant[35], "bla bla");
            objCity.listHabitant[75].createUrgentLetter(objCity.listHabitant[10], new RegisteredLetter(new Sender(objCity.listHabitant[75]), new Receiver(objCity.listHabitant[10]), new SimpleLetter(new Sender(objCity.listHabitant[75]), new Receiver(objCity.listHabitant[10]), "bla bla")));
            objCity.listHabitant[56].createPromissoryNote(objCity.listHabitant[52], 296);

            //DAY 6
            Console.WriteLine("************************************************************");
            Console.WriteLine("Day 6");
            objCity.distributeLetters();
            objCity.listHabitant[62].createRegisteredLetter(objCity.listHabitant[41], new SimpleLetter(new Sender(objCity.listHabitant[62]), new Receiver(objCity.listHabitant[41]), "bla bla"));
            objCity.listHabitant[59].createRegisteredLetter(objCity.listHabitant[1], new SimpleLetter(new Sender(objCity.listHabitant[59]), new Receiver(objCity.listHabitant[1]), "bla bla"));

            //DAY 7
            Console.WriteLine("************************************************************");
            Console.WriteLine("Day 7");
            objCity.distributeLetters();

            //DAY 8
            Console.WriteLine("************************************************************");
            Console.WriteLine("Day 8");
            objCity.distributeLetters();

            //DAY 9
            Console.WriteLine("************************************************************");
            Console.WriteLine("Day 9");
            objCity.distributeLetters();

            int i = 0;
            i = i + 1;

            //*/
        }
    }
}
