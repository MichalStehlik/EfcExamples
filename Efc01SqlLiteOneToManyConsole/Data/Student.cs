using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Efc01SqlLiteOneToManyConsole.Data
{
    class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // not needed
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [ForeignKey("ClassroomId")]
        public Classroom Classroom { get; set; }
        [Required]
        public int ClassroomId { get; set; }
    }
}
