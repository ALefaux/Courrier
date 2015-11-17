using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcourrier
{
    class Acknowledgment : Letter
    {
        int acknowledgmentPrice;
        String contentLetter;
        public Acknowledgment(Sender prmSender, Receiver prmReceiver, String prmContent) : base(prmSender, prmReceiver)
        {
            price = acknowledgmentPrice = 1;
            contentLetter = prmContent;
        }

        public override void executeContent()
        {
            return;
        }

        public override string getDescription()
        {
            return "Acknowledgment";
        }

        public override int getPrice()
        {
            throw new NotImplementedException();
        }

        public override String putContent()
        {
            return "witch is ";
        }
    }
}
