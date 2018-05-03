using Scratch.Interface.Mail;
using Scratch.Service.Mail;

namespace Scratch.Database
{
    public class DataModuleBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IMailService>().To<MockMailService>().InTransientScope();
        }
    }
}
