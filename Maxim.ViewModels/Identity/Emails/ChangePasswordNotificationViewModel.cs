using Maxim.Entities.Identity;

namespace Maxim.ViewModels.Identity.Emails
{
    public class ChangePasswordNotificationViewModel : EmailsBase
    {
        public User User { set; get; }
    }
}