using System;
using NoteAppRepository.Db_Content;
using NoteAppRepository.Entities;

namespace NoteAppBusiness.Serivices
{
    public class AddDataToDataBase
    {
        private DbContent _content;
        public AddDataToDataBase(DbContent dbContent)
        {
            _content = dbContent;
        }
        public void AddNewNote(string name, string record, bool isPrivateRecord, string photoUrl, Guid categorieId, Guid userId)
        {
            Note newNote = new(name, record, isPrivateRecord, photoUrl);
            newNote.CategorieId = categorieId;
            newNote.UserId = userId;
            _content.Add(newNote);
            _content.SaveChanges();
        }
        public void AddNoteToUser(User user, Note note)
        {
            user.Notes.Add(note);
        }
        public void AddNoteToCategorie(Categorie categorie, Note note)
        {
            categorie.Notes.Add(note);
        }
        public void AddNewUser(string name, string surName, string logName, string logPassword)
        {
            User newUser = new(name, surName, logName, logPassword);
            _content.Add(newUser);
            _content.SaveChanges();
        }
        public void AddNewCategorie(string name, bool isPrivateName, string description, Guid userId)
        {
            Categorie newCategorie = new(name, description, isPrivateName);
            newCategorie.UserId = userId;
            _content.Add(newCategorie);
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
    }
}
