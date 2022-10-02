using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Education
    {
        public int Education_ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Sotrud> Sotruds { get; set; }
    }
}
