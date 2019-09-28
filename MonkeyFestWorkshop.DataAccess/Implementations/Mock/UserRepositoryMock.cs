using MonkeyFestWorkshop.DataAccess.Repositories;
using MonkeyFestWorkshop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonkeyFestWorkshop.DataAccess.Implementations.Mock
{
    public class UserRepositoryMock : IUserRepository
    {

        public UserInfo GetUserInfo(string Id)
        {
            return new UserInfo
            {
                Id = "34",
                Name = "qewe"
        };
    }
