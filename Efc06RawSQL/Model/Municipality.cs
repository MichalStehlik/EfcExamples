using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Efc06RawSQL.Model
{
    class Municipality
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("RegionId")]
        public Region Region { get; set; }
        [Required]
        public int RegionId { get; set; }
    }
}
