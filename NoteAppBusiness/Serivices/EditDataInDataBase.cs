using NoteAppRepository.Db_Content;
using NoteAppRepository.Entities;

namespace NoteAppBusiness.Serivices
{
    public class EditDataInDataBase
    {
        private DbContent _content;
        public EditDataInDataBase(DbContent dbContent)
        {
            _content = dbContent;
        }
        public void EditNote(Note newNote)
        {
            _content.Notes.Update(newNote);
            _content.SaveChanges();
        }
        public void EditNoteName(Note note, string newNoteName)
        {
            _content.Notes.Find(note).Name = newNoteName;
            _content.Notes.Update(note);
            _content.SaveChanges();
        }
        public void EditNoteRecord(Note note, string newNoteRecord)
        {
            _content.Notes.Find(note).Record = newNoteRecord;
            _content.Notes.Update(note);
            _content.SaveChanges();
        }
        public void EditCategorie(Categorie newCategorie)
        {
            _content.Categories.Update(newCategorie);
            _content.SaveChanges();
        }
        public void EditCategorieName(Categorie categorie, string newName)
        {
            _content.Categories.Find(categorie).Name = newName;
            _content.Categories.Update(categorie);
            _content.SaveChanges();
        }
    }
}
