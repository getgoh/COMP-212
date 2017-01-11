using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300910584_Goh__ASS_1
{
    public class SendSubscriber
    {
        private String cellPhone;
        private String emailAddr;

        public SendSubscriber() {
            cellPhone = null;
            emailAddr = null;
        }        

        public void setMobile(String phone)
        {
            cellPhone = phone;
        }

        public String getMobile()
        {
            return cellPhone;
        }

        public void setEmailAddr(String emailAddr)
        {
            this.emailAddr = emailAddr;
        }

        public String getEmailAddr()
        {
            return emailAddr;
        }

        private void sendMessage(string msg)
        {
            Console.WriteLine("The message " + "\"" + msg + "\" has already texted to " + cellPhone);
        }

        public void sendEmail(string msg)
        {
            Console.WriteLine("The message" + "\"" + msg + "\" has already sent to " + emailAddr);
        }

        public void Subscribe(Publisher pub)
        {
            if(emailAddr != null)
                pub.publishmsg += sendEmail;

            if(cellPhone != null)
                pub.publishmsg += sendMessage;
        }

        public void Unsubscribe(Publisher pub)
        {
            pub.publishmsg -= sendMessage;
            pub.publishmsg -= sendEmail;
        }
    }
}
