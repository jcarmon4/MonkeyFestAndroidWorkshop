using MonkeyFestWorkshop.DataAccess.Repositories;
using MonkeyFestWorkshop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonkeyFestWorkshop.DataAccess.Implementations.Real
{
    public class UserRepository : IUserRepository
    {
        private readonly List<UserInfo> users;

        public UserRepository()
        {
            users = new List<UserInfo>();

            var user1 = new UserInfo()
            {
                Id = "1",
                Name = "dfghjk"
            };
            users.Add(user1);

            var user2 = new UserInfo()
            {
                Id = "2",
                Name = "sfdghj"
            };
            users.Add(user2);

            var user3 = new UserInfo()
            {
                Id = "3",
                Name = "cvbnm,"
            };
            users.Add(user3);
        }

        public UserInfo GetUserInfo(string Id)
        {
            return new UserInfo()
            {
                Id = "34",
                Name = "wfdgf"
            };
        }
    }
}
