using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Position
    {
        [Key]
        public int Position_ID { get; set; }
        public int PositionName_ID { get; set; }
        public int? Oklad { get; set; }
        public int? Status { get; set; }

    }
}
