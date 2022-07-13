using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NoteAppRepository.Entities
{
    public class Categorie
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool PrivateName { get; set; }
        [Required]
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<Note> Notes { get; set; }
        public Categorie(string name, string description, bool privateName)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            PrivateName = privateName;
            Notes = new List<Note>();
        }
    }
}
