using System;
using System.Collections.Generic;
using System.Linq;
using NoteAppRepository.Db_Content;
using NoteAppRepository.Entities;

namespace NoteAppBusiness.Serivices
{
    public class CategorieServices
    {
        private DbContent _content;
        public CategorieServices(DbContent dbContent)
        {
            _content = dbContent;
        }
        public void AddNewCategorie(string name, bool isPrivateName, string description, Guid userId)
        {
            Categorie newCategorie = new(name, description, isPrivateName);
            newCategorie.UserId = userId;
            _content.Add(newCategorie);
            _content.SaveChanges();
        }
        public void EditCategorie(Guid categorieId, Categorie categorie)
        {
            _content.Categories.Update(categorie);
            _content.SaveChanges();
        }
        public Categorie FindCategorieById(Guid categorieId)
        {
            return _content.Categories.Find(categorieId);
        }
        public Categorie FindCategorieByUserAndName(Guid userId, string name)
        {
            var categorie = _content.Categories.
                FirstOrDefault(categorie => categorie.UserId == userId && categorie.Name == name);
            return categorie;
        }
        public Categorie FindCategorieByName(string name)
        {
            var categorie = _content.Categories.
                FirstOrDefault(c => c.Name == name);
            return categorie;
        }
        public List<Categorie> FindCategorieByUserId(Guid userId)
        {
            return _content.Categories.Where(categorie => categorie.UserId == userId).ToList();
        }
        public void RemoveCategorie(Categorie categorie)
        {
            _content.Remove(categorie);
            _content.SaveChanges();
        }
        public Categorie FindPublicCategorieByName(string name)
        {
            var categorie = _content.Categories.
                FirstOrDefault(categorie => categorie.Name == name && categorie.PrivateName == false);
            return categorie;
        }
    }
}
