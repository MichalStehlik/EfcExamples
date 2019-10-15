using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Efc02SqliteManyToManyConsole.Data
{
    class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
