using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Services.Models.Entities;

namespace backend.Services.Methods
{
    
    public class UserService
    {
        private readonly Models.UserContext database;
        public UserService()
        {
            database = new Models.UserContext();
        }
        public List<Register> GetUser()
        {
            return database.register.ToList();
        }

        private Register getUserId(int userId)
        {
            return database.register.Where(u => u.UserId.Equals(userId)).FirstOrDefault();
        }

        public Register getUserEmail(string userEmail)
        {
            return database.register.Where(u => u.UserEmail.Equals(userEmail)).FirstOrDefault();
        }

        public Register getUserName(string userName)
        {
            return database.register.Where(u => u.UserName.Equals(userName)).FirstOrDefault();
        }

        public Register getUserPass(string userPass)
        {
            return database.register.Where(u => u.UserPass.Equals(userPass)).FirstOrDefault();
        }

        public Register getUserGender(string userGender)
        {
            return database.register.Where(u => u.UserGender.Equals(userGender)).FirstOrDefault();
        }

        public Register getUserBirthday(string userGender)
        {
            return database.register.Where(u => u.UserGender.Equals(userGender)).FirstOrDefault();
        }

        public Register getBday(string userBday)
        {
            return database.register.Where(u => u.UserBday.Equals(userBday)).FirstOrDefault();
        }

        public void AddUser(Services.Models.Entities.Register userInfo)
        {
            database.register.Add(userInfo);
            database.SaveChanges();
        }
       
    }
}

