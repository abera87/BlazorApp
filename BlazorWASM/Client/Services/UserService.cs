using BlazorWASM.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWASM.Client.Services
{
    public class UserService : IUserService
    {
        string userEmail;
        public string UserEmail { get { return userEmail; } }
        public UserService()
        {
            userEmail = string.Empty;
        }
        public bool Login(LoginModel loginModel)
        {
            bool result = false;
            if (loginModel.Email != string.Empty && loginModel.Password != string.Empty)
            {
                result = true;
                userEmail = loginModel.Email;
            }

            return result;
        }

    }
}
