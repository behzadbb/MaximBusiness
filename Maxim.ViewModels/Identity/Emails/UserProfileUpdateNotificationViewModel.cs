using Maxim.Entities.Identity;

namespace Maxim.ViewModels.Identity.Emails
{
    public class UserProfileUpdateNotificationViewModel : EmailsBase
    {
        public User User { set; get; }
    }
}