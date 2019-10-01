using System.ComponentModel.DataAnnotations;

namespace Efc00SqlLiteConsole.Data
{
    class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
