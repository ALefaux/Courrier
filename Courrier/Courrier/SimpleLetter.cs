using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcourrier
{
    class SimpleLetter : Letter
    {
        int simpleLetterPrice = 1;
        String simpleLetterMessage;

        public SimpleLetter(Sender prmSender, Receiver prmReceiver, String prmContent) : base(prmSender, prmReceiver)
        {
            price = simpleLetterPrice;
            simpleLetterMessage = prmContent;
        }

        override public String putContent()
        {
            return this.getDescription() + " whose content is a text content (" + simpleLetterMessage + ")" ;
        }
        public override String getDescription()
        {
            return "a simple letter";
        }

        public override int getPrice()
        {
            return simpleLetterPrice;
        }

        public override void executeContent()
        {
            //Do nothing
            return;
        }
    }
}
