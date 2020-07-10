using System.ComponentModel.DataAnnotations;

namespace GameWebApp.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public int CreatorId { get; set; }
        public string GameName { get; set; }
        public string Description { get; set; }
        public virtual GameCreator GameCreator { get; set; }
    }
}