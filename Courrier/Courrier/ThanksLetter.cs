using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcourrier
{
    public class ThanksLetter : SimpleLetter
    {
        int thanksLetterPrice;
        string thanksLetterContent;

        public ThanksLetter(Sender prmSender, Receiver prmReceiver, String prmContent):base(prmSender, prmReceiver, prmContent)
        {
            thanksLetterPrice = 1;
            thanksLetterContent = prmContent;
        }
        public override void executeContent()
        {
            return;
        }

        public override string getDescription()
        {
            return "a thanks letter";
        }

        public override int getPrice()
        {
            return thanksLetterPrice;
        }

        public override string putContent()
        {
            return this.getDescription() + " which is a simple letter whose content is a text content (" + this.thanksLetterContent + ")";
        }
    }
}
