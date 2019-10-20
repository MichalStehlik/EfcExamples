using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Efc04SqliteFluentAPIConsole.Data
{
    class Classroom
    {
        public int ClassroomIdentificator { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
