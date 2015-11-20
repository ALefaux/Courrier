using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcourrier
{
    public class Acknowledgment : SimpleLetter
    {
        int acknowledgmentPrice;
        String contentLetter;
        public Acknowledgment(Sender prmSender, Receiver prmReceiver, String prmContent) : base(prmSender, prmReceiver, prmContent)
        {
            acknowledgmentPrice = 1;
            contentLetter = prmContent;
        }

        public override void executeContent()
        {
            return;
        }

        public override string getDescription()
        {
            return "an acknowledgment of receipt";
        }

        public override int getPrice()
        {
            return acknowledgmentPrice;
        }

        public override String putContent()
        {
            return this.getDescription() + " which is a simple letter whose content is a text content (" + this.contentLetter + ")";
        }
    }
}
