using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Models
{
    public class Books
    {
        [Key]
        public string ISBN { get; set; }
       
        public string Title { get; set; }
       
        public string Author { get; set; }
        
        public string State { get; set; }
       
        public string Obtained_Through { get; set; }
        
        public string Publisher { get; set; }
       
        public string Genrre { get; set; }
       
        public DateTime CreatedOn { get; set; }
    }
}
