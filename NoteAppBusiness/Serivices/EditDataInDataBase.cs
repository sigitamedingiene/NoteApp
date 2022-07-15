using System;
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
        public void EditNote(Guid noteId, Note note)
        {   
            _content.Notes.Update(note);
            _content.SaveChanges();
        }
        public void EditCategorie(Guid categorieId, Categorie categorie)
        {
            _content.Categories.Update(categorie);
            _content.SaveChanges();
        }
    }
}
