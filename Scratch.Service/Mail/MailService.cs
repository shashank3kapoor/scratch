using Scratch.Interface.Mail;
using System.Collections;
using System.Linq;

namespace Scratch.Service
{
    public class MailService : IMailService
    {
        public IEnumerable Send(string toAddress, string subject)
        {
            string returnString = "Sending mail to " + toAddress + ", with subject: " + subject;
            return returnString.AsEnumerable();
        }
    }
}
