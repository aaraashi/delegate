using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300975376_Kim_ASS1
{
    public class SendViaEmail
    {
        internal object x;

        public static string Email2 { get; set; }

        public String Email { get; set; }
        public List<SendViaEmail> EmailList { get; private set; }

        public SendViaEmail(SendViaEmail sendViaEmail) { }

        public SendViaEmail(String email)
        {
            Email = email;
        }

        public SendViaEmail(List<SendViaEmail> emailList)
        {
            EmailList = emailList;
        }

            public SendViaEmail()
        {
        }


        public void sendEmail(string msg)
        {
            //make this value to global one, and add this message to the each object 
            Start.result += "The message" + "\"" + msg + "\" has been sent to " + Email+"\n";
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
