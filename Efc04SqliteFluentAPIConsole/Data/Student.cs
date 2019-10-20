using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Efc04SqliteFluentAPIConsole.Data
{
    class Student
    {
        public int StudentIdentificator { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Classroom Classroom { get; set; }
        public int ClassroomId { get; set; }
    }
}
