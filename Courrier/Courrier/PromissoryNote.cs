using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pqtcourrier
{
    public class PromissoryNote : Letter
    {
        int promissoryNotePrice;
        public int AmountSendContent;

        public PromissoryNote(Sender prmSender, Receiver prmReceiver, int prmAmountSend) : base(prmSender, prmReceiver)
        {
            double letterCost = (double)prmAmountSend / 100;
            price = promissoryNotePrice = 1 + (int)letterCost;
            AmountSendContent = prmAmountSend;
        }

        override public String putContent()
        {
            return this.getDescription() + " whose content is a money content (" + AmountSendContent + ")";
        }
        public override String getDescription()
        {
            return "a promissory note letter";
        }

        public override int getPrice()
        {
            return promissoryNotePrice;
        }

        public override void executeContent()
        {
            objSender.objInhabitant.objBankAccount.setDebit(AmountSendContent);
            Console.WriteLine("   - " + AmountSendContent + " euros are debites from inhabitant-" + objSender.objInhabitant.number + " account whose balance is now " + objSender.objInhabitant.objBankAccount.getAmount() + " euros");
            objReceiver.objInhabitant.objBankAccount.setCredit(AmountSendContent);
            Console.WriteLine("   + inhabitant-" + objReceiver.objInhabitant.number + " account is credited with " + AmountSendContent + " euros; its balance is now " + objReceiver.objInhabitant.objBankAccount.getAmount() + " euros");

            objReceiver.objInhabitant.createThanksLetter(objSender.objInhabitant, "thanks for a promissory note letter whose content is a money content (" + AmountSendContent + ")");
            return;
        }
    }
}
