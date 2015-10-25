using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcourrier
{
    class PromissoryNote : Letter
    {
        public PromissoryNote(Sender prmSender, Receiver prmReceiver, Content prmContent) : base(prmSender, prmReceiver, prmContent)
        {

        }
    }
}
