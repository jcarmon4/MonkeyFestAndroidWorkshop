using System;
using System.Collections.Generic;
using System.Text;
using MonkeyFestWorkshop.Domain.Models;

namespace MonkeyFestWorkshop.DataAccess.Repositories
{
    public interface IUserRepository
    {
        UserInfo GetUserInfo(string Id);
    }
}
