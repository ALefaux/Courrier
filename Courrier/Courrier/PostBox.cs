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
        public List<Letter> listCourrierReceive;
        List<Letter> listCourrierSend;

        public PostBox()
        {
            listCourrierReceive = new List<Letter>();
        }

        public void addCourrier(Letter prmLetter)
        {
            listCourrierReceive.Add(prmLetter);
        }

        public int nbCourrier()
        {
            return listCourrierReceive.Count;
        }

        public void distributeCourrier()
        {
            listCourrierSend = listCourrierReceive.ToList();
            listCourrierReceive.Clear();

            if (listCourrierSend.Count == 0)
                Console.WriteLine("There is no letter to distribute today !");

            foreach(Letter objLetter in listCourrierSend)
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
