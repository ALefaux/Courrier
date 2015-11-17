using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pqtcourrier;
using System.Collections.Generic;

namespace pqtcity
{
    public class PostBox
    {
        List<Letter> listCourrier;

        public PostBox()
        {
            listCourrier = new List<Letter>();
        }

        public void addCourrier(Letter prmLetter)
        {
            listCourrier.Add(prmLetter);
        }

        public int nbCourrier()
        {
            return listCourrier.Count;
        }

        public void distributeCourrier()
        {
            /*Letter tempCourrier = (Letter)listCourrierReceive[i];
            removeCourrier(i);
            return tempCourrier;*/

            foreach(Letter objLetter in listCourrier)
            {
                objLetter.objReceiver.objInhabitant.receiveLetter(objLetter);
                objLetter.executeContent();
            }
        }

        /*public void removeCourrier(int i)
        {
            listCourrier.Remove(i);
        }*/
    }
}
