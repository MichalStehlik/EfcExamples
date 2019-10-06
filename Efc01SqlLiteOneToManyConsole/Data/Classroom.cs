using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Efc01SqlLiteOneToManyConsole.Data
{
    class Classroom
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
