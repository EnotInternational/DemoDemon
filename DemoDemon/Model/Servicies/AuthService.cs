using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDemon.Model.Servicies
{
    public class AuthService
    {
        public static AuthService Instance { get; private set; }
        public int? UserId { get; private set; }
        public string UserFio { get; private set; }
        public UserRole? UserRole { get; private set; }
        public AuthService() 
        {
            if (Instance != null)
                throw new Exception("Can`t create more than one auth service");
            Instance = this;
        }
        public void SetUserData(int userId, string fio, UserRole userRole)
        {
            this.UserId = userId;
            this.UserFio = fio;
            this.UserRole = userRole;
        }
    }

    public enum UserRole
    {
        Guest = -1,
        AuthorisedUser = 1,
        Admin = 2,
        Manager = 3
    }
}
