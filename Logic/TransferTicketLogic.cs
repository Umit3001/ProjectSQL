using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TransferTicketLogic
    {
        private TransferTicketDao transferTicketDao;

        public TransferTicketLogic()
        {
            transferTicketDao = new TransferTicketDao();
        }

        public User GetUserById(string userId)
        {
            return transferTicketDao.GetUserById(userId);
        }

        public User GetUserByName(string name)
        {
            return transferTicketDao.GetUserByName(name);
        }
    }
}
