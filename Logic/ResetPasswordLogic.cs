using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ResetPasswordLogic
    {
        private ResetPassword resetPassword;

        public ResetPasswordLogic()
        {
            resetPassword = new ResetPassword();


        }

        public void UpdateUserPassword(string userId, string newPassword)
        {
            resetPassword.UpdatePassword(userId, newPassword);
        }
        public User GetUserByEmail(string email)
        {
            return resetPassword.GetUserByEmail(email);
        }
    }
}
