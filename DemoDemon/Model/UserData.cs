using DemoDemon.Forms;
using DemoDemon.Model.Servicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDemon.Model
{
    public class UserData
    {
        public int? UserId;
        public string UserFio;
        public UserRole? UserRole;
        public BaseForm BaseForm;

        public UserConstraint ProductConstraint;
        public UserConstraint OrderConstraint;
    }

    public enum UserConstraint
    {
       Read = 0,
       Edit = 1,
       Add = 2,
       Delete = 4,
    }
}
