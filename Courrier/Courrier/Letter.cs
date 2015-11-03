using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcourrier
{
    public class Letter
    {
        Sender objSender;
        Receiver objReceiver;
        Content objContent;

        public Letter(Sender prmSender, Receiver prmReceiver, Content prmContent)
        {
            objSender = prmSender;
            objReceiver = prmReceiver;
            objContent = prmContent;
        }
    }
}
