using System.Collections;

namespace Scratch.Interface.Mail
{
    public interface IMailService
    {
        IEnumerable Send(string toAddress, string subject);
    }
}
