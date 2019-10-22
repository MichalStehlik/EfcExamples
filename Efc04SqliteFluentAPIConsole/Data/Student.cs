using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Efc04SqliteFluentAPIConsole.Data
{
    public class Student
    {
        public int StudentIdentificator { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Classroom Classroom { get; set; }
        public int ClassroomId { get; set; }
    }
}
