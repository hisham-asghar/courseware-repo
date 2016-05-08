using Entities;
using System;
using DAL;

namespace BAL
{
    public class UserBAL
    {
        UserDAL dal = new UserDAL();
        public Boolean verifyLogin(User dto)
        {
            return dal.verifyLogin(dto);
        }

        public int saveUser(User dto)
        {
            return dal.saveUser(dto);
        }

        public User getUser(string uname)
        {
            return dal.getUser(uname);
        }

        public User updateUser(User user)
        {
            return dal.updateUser(user);
        }
    }
}
