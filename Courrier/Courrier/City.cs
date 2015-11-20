using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pqtcourrier;
using System.Collections.Generic;

namespace pqtcity
{
    public class City
    {
        String nameCity;
        public List<Inhabitant> listHabitant;
        public PostBox objPostBox;

        public City(String prmNameCity)
        {
            Console.WriteLine("Creating " + prmNameCity + " city");
            nameCity = prmNameCity;
            objPostBox = new PostBox();
            listHabitant = new List<Inhabitant>() ;

            Console.WriteLine("Creating 100 inhabitants");
            for(int i = 1; i <= 100; i++)
            {
                listHabitant.Add(new Inhabitant(this, i));
            }
        }

        public void sendLetter(Letter prmLetter)
        {
            objPostBox.addCourrier(prmLetter);
        }

        public void distributeLetters()
        {
            objPostBox.distributeCourrier();
        }

        public string getNameCity()
        {
            return this.nameCity;
        }

        public int getNumberOfInhabitants()
        {
            return listHabitant.Count;
        }

        public int getNumberOfLetter()
        {
            return objPostBox.nbCourrier();
        }
    }
}
