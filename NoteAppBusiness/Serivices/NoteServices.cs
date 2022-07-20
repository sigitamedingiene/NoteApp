using System;
using System.Collections.Generic;
using System.Linq;
using NoteAppRepository.Db_Content;
using NoteAppRepository.Entities;

namespace NoteAppBusiness.Serivices
{
    public class NoteServices
    {
        private DbContent _content;
        public NoteServices(DbContent dbContent)
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
        public void EditNote(Guid noteId, Note note)
        {   
            _content.Notes.Update(note);
            _content.SaveChanges();
        }
        public Note FindNoteById(Guid noteId)
        {
            return _content.Notes.Find(noteId);
        }
        public Note FindNoteByName(string name)
        {
            var note = _content.Notes
                .FirstOrDefault(note => note.Name == name);
            return note;
        }
        public Note FindNoteByUserAndName(Guid userId, string name)
        {
            var note = _content.Notes.
                FirstOrDefault(note => note.UserId == userId && note.Name == name);
            return note;
        }
        public List<Note> FindNotesByUser(Guid userId)
        {
            return _content.Notes.Where(note => note.UserId == userId).ToList();
        }
        public List<Note> FindNotesByCategorieName(string name)
        {
            var notes = _content.Notes.Where(note => note.Categorie.Name == name).ToList();
            return notes;
        }
        public List<Note> FindNoteByCategorieId(Guid categorieId)
        {
            return _content.Notes.Where(note => note.CategorieId == categorieId).ToList();
        }
        public void RemoveNote(Note note)
        {
            _content.Remove(note);
            _content.SaveChanges();
        }
    }
}
