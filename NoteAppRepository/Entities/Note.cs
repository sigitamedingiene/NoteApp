using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteAppRepository.Entities
{
    public class Note
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Record { get; set; }
        [Required]
        public bool PrivateRecord { get; set; }
        public string PhotoUrl { get; set; }
        [ForeignKey("Categorie")]
        public Guid CategorieId { get; set; }
        public Categorie Categorie { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Note(string name, string record, bool privateRecord, string photoUrl)
        {
            Id = Guid.NewGuid();
            Name = name;
            Record = record;
            PrivateRecord = privateRecord;
            PhotoUrl = photoUrl;
        }
    }
}
