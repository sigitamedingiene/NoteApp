using System;
using System.Collections.Generic;
using System.Linq;
using NoteAppRepository.Db_Content;
using NoteAppRepository.Entities;

namespace NoteAppBusiness.Serivices
{
    public class UserServices
    {
        private DbContent _content;
        public UserServices(DbContent dbContent)
        {
            _content = dbContent;
        }
        public void AddNewUser(string name, string surName, string logName, string logPassword)
        {
            User newUser = new(name, surName, logName, logPassword);
            _content.Add(newUser);
            _content.SaveChanges();
        }
        public void AddPublicUser()
        {
            string name = "publicName";
            string surName = "publicSurname";
            string logName = "public";
            string password = "public";
            User pablicUser = new(name, surName, logName, password);
            _content.Add(pablicUser);
            _content.SaveChanges();
        }
        public List<User> FindUserByLogInName(string logName)
        {
            return _content.Users.Where(user => user.LoginName == logName).ToList();
        }
        public User FindUserByLogNameAndPassword(string logName, string password)
        {
            var user = _content.Users.
                FirstOrDefault(user => user.LoginName == logName && user.LoginPassword == password);
            return user;
        }
        public User FindUserById(Guid userId)
        {
            var user = _content.Users.
                FirstOrDefault(user => user.Id == userId);
            return user;
        }
    }
}
