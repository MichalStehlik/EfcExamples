using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Efc02SqliteManyToManyConsole.Data
{
    class MovieActor
    {
        [Key]
        public int MovieId { get; set; }
        [Key]
        public int ActorId { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }
        [ForeignKey("ActorId")]
        public Actor Actor { get; set; }
    }
}
