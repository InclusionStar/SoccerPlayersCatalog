using System.Collections.Generic;

namespace SoccerPlayersCatalog.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public IEnumerable<Player> Players { get; set; }
    }
}