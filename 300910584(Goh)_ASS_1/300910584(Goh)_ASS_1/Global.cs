using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300910584_Goh__ASS_1
{
    static class Global
    {
        private static List<SendViaEmail> _emailList = new List<SendViaEmail>();
        private static List<SendViaMobile> _mobileList = new List<SendViaMobile>();

        public static List<SendViaEmail> EmailList
        {
            get { return _emailList; }
            set { _emailList = value; }
        }

        public static List<SendViaMobile> MobileList
        {
            get { return _mobileList; }
            set { _mobileList = value; }
        }        
    }
}
