using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcourrier
{
    public class RegisteredLetter : Letter
    {
        int registeredLetterPrice;
        Letter letterContent;

        public RegisteredLetter(Sender prmSender, Receiver prmReceiver, Letter prmContent) : base(prmSender, prmReceiver)
        {
            price = registeredLetterPrice = 15 + prmContent.getPrice();
            //prmSender.objInhabitant.objBankAccount.setDebit(price);

            letterContent = prmContent;
        }

        override public String putContent()
        {
            return "a " + this.getDescription() + " whose content is " + letterContent.putContent();
        }
        public override String getDescription()
        {
            return "a registered letter";
        }

        public override int getPrice()
        {
            return registeredLetterPrice;
        }

        public override void executeContent()
        {
            letterContent.executeContent();
            objReceiver.objInhabitant.createAcknowledgment(objSender.objInhabitant, "acknowledgment of receipt for a registered letter whose content is " + this.letterContent.putContent());
            return;
        }
    }
}
