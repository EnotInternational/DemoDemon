using DemoDemon.Forms;
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

        public UserData UserData { get; private set; }
        public AuthService() 
        {
            if (Instance != null)
                throw new Exception("Can`t create more than one auth service");
            Instance = this;
        }
        public void SetUserData(int userId, UserRole userRole)
        {
            using (MainModel model = new MainModel())
            {
                User user = model.User.Find(userId);
                switch (userRole)
                {
                    case UserRole.Guest:
                        break;
                    case UserRole.AuthorisedUser:
                        break;
                    case UserRole.Admin:
                        UserData = new UserData()
                        {
                            UserId = userId,
                            UserFio = $"{user.MiddleName} {user.FirstName} {user.FirstName}",
                            UserRole = userRole,
                            BaseForm = new ManagerForm(),
                            OrderConstraint = UserConstraint.Read | UserConstraint.Add | UserConstraint.Delete,
                            ProductConstraint = UserConstraint.Read
                        };
                        break;
                    case UserRole.Manager:
                        UserData = new UserData()
                        {
                            UserId = userId,
                            UserFio = $"{user.MiddleName} {user.FirstName} {user.FirstName}",
                            UserRole = userRole,
                            BaseForm = new ManagerForm(),
                            OrderConstraint = UserConstraint.Read | UserConstraint.Add | UserConstraint.Delete,
                            ProductConstraint = UserConstraint.Read
                        };
                        break;
                }
            }
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
