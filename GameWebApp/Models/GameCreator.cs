using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameWebApp.Models
{
    public class GameCreator
    {
        [Key]
        public int CreatorId { get; set; }
        public string CreatorName { get; set; }
        public string  Description { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
