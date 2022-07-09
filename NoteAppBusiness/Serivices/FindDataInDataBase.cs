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
        public List<Categorie> FindNotesByCategorie(string categorieName)
        {
            return _content.Categories.Where(categorie => categorie.Name == categorieName).ToList();
        }
    }
}
