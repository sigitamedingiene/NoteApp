using System.Collections.Generic;
using System.Linq;
using NoteAppRepository.Db_Content;
using NoteAppRepository.Entities;

namespace NoteAppBusiness.Serivices
{
    public class FindDataInDataBase
    {
        private DbContent _content;
        public FindDataInDataBase(DbContent dbContent)
        {
            _content = dbContent;
        }
        public List<Note> FindNotesByName(string name)
        {
            return _content.Notes.Where(notes => notes.Name == name).ToList();
        }
        public List<Categorie> FindNotesByCategorie(string categorieName)//manau neteisingai, cia randa kategorija, ne uzrasus.
        {
            return _content.Categories.Where(categorie => categorie.Name == categorieName).ToList();
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
        public List<Categorie> FindAllCategories()
        {
            return _content.Categories.ToList();
        }
        public Categorie FindCategorieByName(string name)
        {
            var categorie = _content.Categories.
                FirstOrDefault(c => c.Name == name);
            return categorie;
        }
    }
}
