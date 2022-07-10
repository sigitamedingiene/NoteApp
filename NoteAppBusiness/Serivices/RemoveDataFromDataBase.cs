﻿using NoteAppRepository.Db_Content;
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
        public void RemoveCategorie(string name, bool privateName, string description, Note note)
        {
            Categorie categorie = new(name, description, privateName);
            categorie.Notes.Remove(note);
            _content.Remove(categorie);
            _content.SaveChanges();
        }
        public void RemoveNote(string name, string record, bool privateRecord, string photoUrl)
        {
            Note note = new(name, record, privateRecord, photoUrl);
            _content.Remove(note);
            _content.SaveChanges();
        }
    }
}