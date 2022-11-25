using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerPlayersCatalog.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        
        [Column(TypeName = "Date")]
        public DateTime BirthDate { get; set; }
        
        public int? TeamId { get; set; }
        public Team Team { get; set; }
        
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}