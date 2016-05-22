using Entities;
using System;
using System.Linq;
using Utility;

namespace DAL
{
    public class UserDAL
    {
        public bool verifyLogin(User dto)
        {
            Database ctx = new Database();

            var user = ctx.Users.Where(x => x.username == dto.username && x.password == dto.password).FirstOrDefault();
            if (user != null)
            {
                dto.image = user.image;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int saveUser(User dto)
        {
            Database ctx = new Database();
            dto.image = "";
            dto.dob = dto.dob.Date;
            dto.onCreated = DateTime.Now;
            ctx.Users.Add(dto);
            try
            {
                ctx.SaveChanges();
                return 1;
            }
            catch (Exception )
            {
                return 0;
            }
        }

        public User getUser(string uname)
        {
            Database ctx = new Database();
            return ctx.Users.Where(x => x.username == uname ).FirstOrDefault();
        }

        public User updateUser(User user)
        {
            Database ctx = new Database();
            User dto = ctx.Users.Where(x => x.username == user.username).FirstOrDefault();
      //      user.user_id = dto.user_id;

            dto.gender = user.gender;
            dto.firstName = user.firstName;
            dto.image = user.image;

            user.dob = user.dob.Date;
            ctx.Users.Attach(dto);
            var entry = ctx.Entry(dto);
            entry.State = System.Data.Entity.EntityState.Unchanged;
            entry.Property(e => e.image).IsModified = true;
            entry.Property(e => e.firstName).IsModified = true;
            entry.Property(e => e.lastName).IsModified = true;
            entry.Property(e => e.email).IsModified = true;
            entry.Property(e => e.password).IsModified = true;
            entry.Property(e => e.dob).IsModified = true;
            entry.Property(e => e.gender).IsModified = true;
            ctx.SaveChanges();
            return user;
        }
    }
}
