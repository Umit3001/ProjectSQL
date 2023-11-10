using DAL;
using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class UserLogic
    {
        private UserDao userDao;
       
        public UserLogic()
        {
            userDao = new UserDao();
           


        }
        public User FindUser(string username, string password)
        {
            return userDao.FindUser(username, password);
        }

        public List<User> GetAllUsers()
        {
            return userDao.GetAllUsers();
        }


        public void AddUser(User newUser)
        {
            userDao.AddUser(newUser);
        }

        public List<string> GetServiceDeskEmployeeIds()
        {
            return userDao.GetServiceDeskEmployeeIds();
        }

        public void UpdateUserPassword(string userId, string newPassword)
        {
            userDao.UpdatePassword(userId, newPassword);
        }
        public User GetUserByEmail(string email)
        {
            return userDao.GetUserByEmail(email);
        }


    }
}
