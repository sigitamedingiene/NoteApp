using NoteAppRepository.Db_Content;
using NoteAppRepository.Entities;

namespace NoteAppBusiness.Serivices
{
    public class RemoveDataFromDataBase
    {
        private DbContent _content;
        public RemoveDataFromDataBase(DbContent dbContent)
        {
            _content = dbContent;
        }
        public void RemoveCategorie(Categorie categorie)
        {
            _content.Remove(categorie);
            _content.SaveChanges();
        }
        public void RemoveNote(Note note)
        {
            _content.Remove(note);
            _content.SaveChanges();
        }
    }
}
