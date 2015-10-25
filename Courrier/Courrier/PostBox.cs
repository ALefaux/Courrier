using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pqtcourrier;

namespace pqtcity
{
    class PostBox
    {
        ArrayList listCourrier;

        public PostBox()
        {
            listCourrier = new ArrayList();
        }

        public void addCourrier(Letter prmLetter)
        {
            listCourrier.Add(prmLetter);
        }

        public int nbCourrier()
        {
            return listCourrier.LastIndexOf(this);
        }

        public Letter getCourrier(int i)
        {
            Letter tempCourrier = (Letter)listCourrier[i];
            removeCourrier(i);
            return tempCourrier;
        }

        public void removeCourrier(int i)
        {
            listCourrier.Remove(i);
        }
    }
}
