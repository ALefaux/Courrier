using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcourrier
{
    public class UrgentLetter : Letter
    {
        int urgentLetterPrice;
        Letter objLetterContent;

        public UrgentLetter(Sender prmSender, Receiver prmReceiver, Letter prmLetter):base(prmSender, prmReceiver)
        {
            urgentLetterPrice = prmLetter.getPrice() * 2;
            objLetterContent = prmLetter;
        }

        public override string getDescription()
        {
            return "an urgent letter";
        }

        public override int getPrice()
        {
            return urgentLetterPrice;
        }

        public override string putContent()
        {
            return this.getDescription() + " whose content is " + objLetterContent.putContent();
        }

        public override void executeContent()
        {
            objLetterContent.executeContent();
            return;
        }
    }
}
