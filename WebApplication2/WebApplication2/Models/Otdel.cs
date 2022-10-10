using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Otdel
    {
        [Key]
        public int Otdel_ID { get; set; }

        public string Name { get; set; }

        public string Telephone { get; set; }

        public virtual ICollection<Sotrud> Sotruds { get; set; }

    }
}
