using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pqtcourrier;

namespace pqtcity
{
    class City
    {
        String nameCity;
        ArrayList listHabitant;
        PostBox objPostBox;

        public City(String prmNameCity)
        {
            nameCity = prmNameCity;
            objPostBox = new PostBox();
            listHabitant = new ArrayList() ;

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
    }
}
