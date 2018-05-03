using Scratch.Interface.Mail;
using System.Collections;
using System.Linq;

namespace Scratch.Service.Mail
{
    public class MockMailService : IMailService
    {
        public IEnumerable Send(string toAddress, string subject)
        {
            string returnString = "Mocking mail to " + toAddress + ", with subject: " + subject;
            return returnString.AsEnumerable();
        }
    }
}
