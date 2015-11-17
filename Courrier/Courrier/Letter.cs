using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcourrier
{
    abstract public class Letter
    {
        public Sender objSender;
        public Receiver objReceiver;
        protected int price;

        public Letter(Sender prmSender, Receiver prmReceiver)
        {
            objSender = prmSender;
            objReceiver = prmReceiver;
        }

        abstract public String putContent();
        abstract public String getDescription();
        abstract public int getPrice();
        abstract public void executeContent();
    }
}
