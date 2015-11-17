using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcourrier
{
    class RegisteredLetter : Letter
    {
        int registeredLetterPrice;
        Letter letterContent;

        public RegisteredLetter(Sender prmSender, Receiver prmReceiver, Letter prmContent) : base(prmSender, prmReceiver)
        {
            price = registeredLetterPrice = 15 + prmContent.getPrice();
            //prmSender.objInhabitant.objBankAccount.setDebit(price);

            letterContent = prmContent;
        }

        public void sendAcknowledgment()
        {
            Sender objSenderAcknowledgment = new Sender(objReceiver.objInhabitant);
            Receiver objReceiverAcknowledgment = new Receiver(objSender.objInhabitant);

            Acknowledgment objAcknowledgment = new Acknowledgment(objSenderAcknowledgment, objReceiverAcknowledgment, "aknowledgment of receipt for a registered letter whose content is a simple letter whose content");
        }

        override public String putContent()
        {
            return "a " + this.getDescription() + " whose content is " + letterContent.putContent();
        }
        public override String getDescription()
        {
            return "registered letter";
        }

        public override int getPrice()
        {
            return registeredLetterPrice;
        }

        public override void executeContent()
        {
            return;
        }
    }
}
