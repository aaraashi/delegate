using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300975376_Kim_ASS1
{
    public class SendViaMobile
    {

        public String CellPhone { get; set; }

        public SendViaMobile() { }

        public SendViaMobile(String phone)
        {
            CellPhone = phone;
        }

        private void sendMessage(string msg)
        {
            Start.result += "The message" + "\"" + msg + "\" has been sent to " + CellPhone + "\n";
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
