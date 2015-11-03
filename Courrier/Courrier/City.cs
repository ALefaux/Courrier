using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pqtcourrier;

namespace pqtcity
{
    public class City
    {
        String nameCity;
        ArrayList listHabitant;
        PostBox objPostBox;

        public City(String prmNameCity)
        {
            Console.WriteLine("Creating " + prmNameCity + " city");
            nameCity = prmNameCity;
            objPostBox = new PostBox();
            listHabitant = new ArrayList() ;

            Console.WriteLine("Creating 100 inhabitants");
            for(int i = 0; i < 100; i++)
            {
                listHabitant.Add(new Inhabitant(this));
            }
        }

        public void sendLetter(Letter prmLetter)
        {
            objPostBox.addCourrier(prmLetter);
        }

        public void distributeLetters()
        {

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
