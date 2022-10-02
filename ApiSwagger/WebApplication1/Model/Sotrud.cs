using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Sotrud
    {
        public int Sotrud_ID { get; set; }
      
        public int Otdel_ID { get; set; }
       
        public int Position_ID { get; set; }
        
        public int Education_ID {get; set;}
        public string F_Name { get; set; }
        public string L_Name { get; set; }

        public virtual Otdel Otdel { get; set; }
        public virtual Education Education { get; set; }
        public virtual Position Position { get; set; }
    }
}
