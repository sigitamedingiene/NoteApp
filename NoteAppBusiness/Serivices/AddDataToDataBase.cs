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
        public void AddNewNote(string name, string record, bool privateRecord, string photoUrl, Guid categorieId, Guid userId)
        {
            Note newNote = new(name, record, privateRecord, photoUrl);
            newNote.CategorieId = categorieId;
            newNote.UserId = userId;
            _content.Add(newNote);
            _content.SaveChanges();
        }
        public void AddNewUser(string name, string surName, string logName, string logPassword)
        {
            User newUser = new(name, surName, logName, logPassword);
            _content.Add(newUser);
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
        public void AddNewCategorie(string name, bool privateName, string description)
        {
            Categorie newCategorie = new(name, description, privateName);
            _content.Add(newCategorie);
            _content.SaveChanges();
        }
    }
}
