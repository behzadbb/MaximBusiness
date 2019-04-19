using System.Collections.Generic;
using Maxim.Entities.Identity;

namespace Maxim.ViewModels.Identity
{
    public class TodayBirthDaysViewModel
    {
        public List<User> Users { set; get; }

        public AgeStatViewModel AgeStat { set; get; }
    }
}