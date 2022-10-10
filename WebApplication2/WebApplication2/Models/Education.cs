using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Education
    {
        [Key]
        public int Education_ID { get; set; }
        public string Name { get; set; }
    }
}
