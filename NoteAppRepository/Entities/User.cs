using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NoteAppRepository.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string LoginName { get; set; }
        [Required]
        public string LoginPassword { get; set; }
        public List<Note> Notes { get; set; }
        public User(string name, string surName, string loginName, string loginPassword)
        {
            Id = Guid.NewGuid();
            Name = name;
            SurName = surName;
            LoginName = loginName;
            LoginPassword = loginPassword;
            Notes = new List<Note>();
        }
    }
}
