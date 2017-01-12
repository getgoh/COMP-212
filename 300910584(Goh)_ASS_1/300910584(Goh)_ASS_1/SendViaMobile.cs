using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _300910584_Goh__ASS_1
{
    public class SendViaMobile
    {
        private String cellPhone;

        public SendViaMobile() { }

        public SendViaMobile(String phone)
        {
            cellPhone = phone;
        }

        public void setMobile(String phone)
        {
            cellPhone = phone;
        }

        public String getMobile()
        {
            return cellPhone;
        }

        private void sendMessage(string msg)
        {
            Console.WriteLine("The message " + "\"" + msg + "\" has already texted to " + cellPhone);
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendMessage;
        }

        public void Unsubscribe(Publisher pub)
        {
            pub.publishmsg -= sendMessage;
        }
    }
}
