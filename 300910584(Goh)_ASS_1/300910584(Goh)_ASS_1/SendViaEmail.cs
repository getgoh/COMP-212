using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300910584_Goh__ASS_1
{
    public class SendViaEmail
    {
        private String emailAddr;

        public SendViaEmail() { }

        public SendViaEmail(String emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public void setEmailAddr(String emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public String getEmailAddr()
        {
            return emailAddr;
        }

        public void sendEmail(string msg)
        {
           // Debug.WriteLine("asd");
            Console.WriteLine("The message" + "\"" + msg + "\" has already sent to " + emailAddr);
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendEmail;
        }

        public void Unsubscribe(Publisher pub)
        {
            pub.publishmsg -= sendEmail;
        }
    }
}
