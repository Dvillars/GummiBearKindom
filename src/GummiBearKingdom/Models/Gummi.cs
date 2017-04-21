using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GummiBearKingdom.Models
{
    [Table("Gummies")]
    public class Gummi
    {
        [Key]
        public int GummiId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Image { get; set; }
        public string Country { get; set; }
    }
}
