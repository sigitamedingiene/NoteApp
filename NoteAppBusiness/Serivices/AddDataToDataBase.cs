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
        public void AddNewUser(string name, string surName, string logName, string logPassword, Note note)
        {
            User newUser = new(name, surName, logName, logPassword);
            _content.Add(newUser);
            newUser.Notes.Add(note);
            _content.SaveChanges();
        }
        public void AddNewCategorie(string name, bool privateName, string description, Note note)
        {
            Categorie newCategorie = new(name, description, privateName);
            _content.Add(newCategorie);
            newCategorie.Notes.Add(note);
            _content.SaveChanges();
        }
        public void AddNewNote(string name, string record, bool privateRecord, string photoUrl)
        {
            Note newNote = new(name, record, privateRecord, photoUrl);
            _content.Add(newNote);
            _content.SaveChanges();
        }
    }
}
