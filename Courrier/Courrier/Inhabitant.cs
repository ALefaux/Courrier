using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pqtcourrier;

namespace pqtcity
{
    class Inhabitant
    {
        BankAccount objBankAccount; //The count of this habitant
        City hisCity; //City where lives this habitant

        public Inhabitant(City prmHisCity)
        {
            objBankAccount = new BankAccount();
            hisCity = prmHisCity;
        }

        public void createSimpleLetter(Inhabitant prmReceiver, Content prmContent)
        {
            Letter objLetterTemp = new SimpleLetter(new Sender(this), new Receiver(prmReceiver), prmContent);
            hisCity.sendLetter(objLetterTemp);
        }

        public BankAccount getBankAccount()
        {
            return objBankAccount;
        }

        public City getCity()
        {
            return hisCity;
        }
    }
}
