using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Efc02SqliteManyToManyConsole.Data
{
    class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
