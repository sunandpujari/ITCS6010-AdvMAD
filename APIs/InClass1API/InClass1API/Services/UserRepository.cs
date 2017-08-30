using InClass1API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InClass1API.Services
{
    public interface IUserRepository {

    }

    public class UserRepository : IUserRepository
    {
        private readonly Func<IUserData> userData;
        private readonly Func<EncryptUtil> encryptUtil;

        public UserRepository(Func<IUserData> userData, Func<EncryptUtil> encryptUtil)
        {
            this.userData = userData;
            this.encryptUtil = encryptUtil;
        }

        public void SignUp(string name, int age, string gender, string password) {
            password = encryptUtil().Encrypt(password);

        }

        public void Login(int id, string password) {
            password = encryptUtil().Encrypt(password);

        }

        public void GetUserProfile(int id, string token) {

        }
    }
}