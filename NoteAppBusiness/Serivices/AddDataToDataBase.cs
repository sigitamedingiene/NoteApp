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
        public void AddNewNote(string name, string record, bool privateRecord, string photoUrl)
        {
            Note newNote = new(name, record, privateRecord, photoUrl);
            _content.Add(newNote);
            _content.SaveChanges();
        }
        public void AddNewUser(string name, string surName, string logName, string logPassword)
        {
            User newUser = new(name, surName, logName, logPassword);
            _content.Add(newUser);
            _content.SaveChanges();
            //Note note = new(_note.Name, _note.Record, _note.PrivateRecord, _note.PhotoUrl);
            //newUser.Notes.Add(note);            
        }
        public void AddNewCategorie(string name, bool privateName, string description)
        {
            Categorie newCategorie = new(name, description, privateName);
            _content.Add(newCategorie);
            //Note note = new(_note.Name, _note.Record, _note.PrivateRecord, _note.PhotoUrl);
            //newCategorie.Notes.Add(note);
            _content.SaveChanges();
        }
    }
}
