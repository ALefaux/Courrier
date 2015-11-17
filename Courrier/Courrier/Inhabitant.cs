using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pqtcourrier;

namespace pqtcity
{
    public class Inhabitant
    {
        public BankAccount objBankAccount; //The count of this habitant
        City hisCity; //City where lives this habitant
        public int number;

        public Inhabitant(City prmHisCity, int prmNumber)
        {
            objBankAccount = new BankAccount();
            hisCity = prmHisCity;
            number = prmNumber;
        }

        public void createSimpleLetter(Inhabitant prmReceiver, String prmContent)
        {
            Letter objLetterTemp = new SimpleLetter(new Sender(this), new Receiver(prmReceiver), prmContent);
            this.postLetter(prmReceiver, objLetterTemp);
        }

        public void createUrgentLetter(Inhabitant prmReceiver, Letter prmLetter)
        {
            Letter objUrgentLetter = new UrgentLetter(new Sender(this), new Receiver(prmReceiver), prmLetter);
            this.postLetter(prmReceiver, objUrgentLetter);
        }

        public void createPromissoryNote(Inhabitant prmReceiver, int prmNote)
        {
            Letter objPromissoryNote = new PromissoryNote(new Sender(this), new Receiver(prmReceiver), prmNote);
            this.postLetter(prmReceiver, objPromissoryNote);
        }

        public void createRegisteredLetter(Inhabitant prmReceiver, Letter prmLetter)
        {
            Letter objRegisteredLetter = new RegisteredLetter(new Sender(this), new Receiver(prmReceiver), prmLetter);
            this.postLetter(prmReceiver, objRegisteredLetter);
        }

        public BankAccount getBankAccount()
        {
            return objBankAccount;
        }

        public City getCity()
        {
            return hisCity;
        }

        public void postLetter(Inhabitant prmReceiver, Letter prmLetter)
        {
            hisCity.sendLetter(prmLetter);
            this.getBankAccount().setDebit(prmLetter.getPrice());

            Console.WriteLine("-> inhabitant-" + this.number + " mails " + prmLetter.putContent() + " to inhabitant-" + prmReceiver.number + " for a cost of " + prmLetter.getPrice() + " euros");
            Console.WriteLine("   - " + prmLetter.getPrice() + " euros are debited from inhabitant-" + this.number + " account whose balance is now " + this.getBankAccount().getAmount() + " euros");
        }

        public void receiveLetter(Letter prmLetter)
        {
            Console.WriteLine("<- inhabitant-" + this.number + " receive " + prmLetter.putContent() + " from inhabitant-"+ prmLetter.objSender.objInhabitant.number);
        }
    }
}
